using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

using System.Data.SQLite;

namespace napi_naplo
{
	public static class c_DBManager
	{
		private static MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
		private static TripleDESCryptoServiceProvider ts = new TripleDESCryptoServiceProvider();

		public static byte[] key = new byte[24];
		public static byte[] IV = new byte[8];

		public static string getHash(string data)
		{
			byte[] b = Encoding.UTF8.GetBytes(data);
			byte[] md5b = md5.ComputeHash(b);

			string tmp = "";

			foreach(byte bb in md5b)
			{
				tmp += bb.ToString("X2");
			}

			return tmp;
		}

		public static string decryptData(string data, string user)
		{
			try
			{
				generateTripleDes(user);

				string ret = "";

				ICryptoTransform trans = ts.CreateDecryptor();

				byte[] toDecryptArray = Convert.FromBase64String(data);

				byte[] text = trans.TransformFinalBlock
				(toDecryptArray, 0, toDecryptArray.Length);

				ret = Encoding.UTF8.GetString(text);

				return ret;
			}
			catch
			{
				return "";
			}
		}

		public static string encryptData(string text, string user)
		{
			generateTripleDes(user);

			string ret = "";
			
			ICryptoTransform trans = ts.CreateEncryptor();
			
			byte[] toEncryptArray = Encoding.UTF8.GetBytes(text);

			byte[] data = trans.TransformFinalBlock
			(toEncryptArray, 0, toEncryptArray.Length);

			ret = Convert.ToBase64String(data, 0, data.Length);
			
			return ret;
		}

		public static void createFile()
		{
			if (!File.Exists("db.sqlite"))
			{
				File.Create("db.sqlite").Close();
			}
		}

		public static void generateTripleDes(string user)
		{
			generateKey(user);
			generateIV(user);
			byte[] keybytes = key;
			ts.Key = keybytes;
			ts.Mode = CipherMode.CBC;
			ts.Padding = PaddingMode.ISO10126;
			ts.IV = IV;
		}

		public static void generateIV(string user)
		{
			byte[] ba = md5.ComputeHash(Encoding.UTF8.GetBytes(user));

			for (int i = 0; i < 8; i++)
			{
				IV[i] = ba[i];
			}
		}

		public static void generateKey(string user)
		{
			string s = Math.Truncate(Math.PI * 3.33).ToString();
			string ss = "";

			foreach(byte b in md5.ComputeHash(Encoding.UTF8.GetBytes(user)))
			{
				ss += b.ToString("X2").ToUpper();
			}
			
			byte[] bbbbb = new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(s + ss + "|WOLFPAW"));

			for (int i = 0; i < 24; i++)
			{
				key[i] = bbbbb[i];
			}
		}

		public static SQLiteConnection connect()
		{
			SQLiteConnection sqlc = new SQLiteConnection("Data Source=db.sqlite;Version=3;");
			sqlc.Open();
			return sqlc;
		}

		public static bool tableExists(SQLiteConnection sqlc, string table_name)
		{
			bool ret = true;
			
			SQLiteCommand sqlk = new SQLiteCommand() { Connection = sqlc };
			sqlk.CommandText = ("SELECT name FROM sqlite_master WHERE type='table' AND name='" + table_name + "'");
			if (sqlk.ExecuteScalar() is null) { ret = false; }
			
			return ret;
		}

		public static void createTables(SQLiteConnection sqlc)
		{
			if(sqlc.State != ConnectionState.Open) { return; }
			SQLiteCommand sqlk = new SQLiteCommand();

			if (!tableExists(sqlc, "users"))
			{
				sqlk = new SQLiteCommand("CREATE TABLE users (id INTEGER PRIMARY KEY AUTOINCREMENT, username TEXT, password TEXT, email TEXT, date INTEGER);", sqlc);
				sqlk.ExecuteNonQuery();
			}

			if (!tableExists(sqlc, "data"))
			{
				sqlk = new SQLiteCommand("CREATE TABLE data (id INTEGER PRIMARY KEY AUTOINCREMENT, date TEXT, data TEXT, userid INTEGER);", sqlc);
				sqlk.ExecuteNonQuery();
			}
		}

		public static string addUser(SQLiteConnection sqlc, string username, string pass, string date, string email)
		{
			if (sqlc.State != ConnectionState.Open) { return "ERROR:NoOpenConnection"; }

			SQLiteCommand sqlk = new SQLiteCommand("SELECT username FROM users", sqlc);
			var r = sqlk.ExecuteReader();

			while (r.Read())
			{
				if(r.GetString(r.GetOrdinal("username")).ToLower() == username.ToLower()) { return "ERROR:UsernameExists"; }
			}

			sqlk = new SQLiteCommand(string.Format("INSERT INTO users (username, password, email, date) VALUES ('{0}','{1}','{2}','{3}')", username, pass, email, date), sqlc);
			sqlk.ExecuteNonQuery();

			return "SUCCESS:UserCreated";
		}

		public static void addData(SQLiteConnection sqlc, string date, string data, string username)
		{
			if (sqlc.State != ConnectionState.Open) { return; }

			int userid = getUserId(sqlc, username);

			if (userid == -1) { return; }

			SQLiteCommand sqlk = new SQLiteCommand(string.Format("SELECT count(date) FROM data WHERE date = '{0}' AND userid = {1}", date, userid), sqlc);
			var count = sqlk.ExecuteScalar();

			if (count.ToString() == "0")
			{
				if (data != "")
				{
					sqlk = new SQLiteCommand(string.Format("INSERT INTO data (date, data, userid) VALUES ('{0}','{1}',{2})", date, data, userid), sqlc);
				}
			}
			else
			{
				if (data == "")
				{
					sqlk = new SQLiteCommand(string.Format("DELETE FROM data WHERE date='{1}' AND userid={2}", data, date, userid), sqlc);
				}
				else
				{
					sqlk = new SQLiteCommand(string.Format("UPDATE data SET data='{0}' WHERE date='{1}' AND userid={2}", data, date, userid), sqlc);
				}
			}

			sqlk.ExecuteNonQuery();
		}

		public static string deleteUser(SQLiteConnection sqlc, string username)
		{
			if (sqlc.State != ConnectionState.Open) { return "ERROR:NoOpenConnection"; }

			SQLiteCommand sqlk = new SQLiteCommand("SELECT userid FROM users WHERE username = '" + username + "'", sqlc);
			var r = sqlk.ExecuteScalar();

			if(r != null)
			{
				sqlk = new SQLiteCommand(string.Format("DELETE FROM users WHERE username = '{0}'", username), sqlc);
				sqlk.ExecuteNonQuery();

				return "SUCCESS:UserCreated";
			}
			else
			{
				return "ERROR:NoSuchUser";
			}
		}

		public static int getUserId(SQLiteConnection sqlc, string username)
		{
			if (sqlc.State != ConnectionState.Open) { return -1; }

			int ret = -1;

			SQLiteCommand sqlk = new SQLiteCommand("SELECT id FROM users WHERE username = '" + username + "'", sqlc);
			var rr = sqlk.ExecuteScalar();
			if (rr is null) { ret = -1; }
			else {
				int.TryParse(rr.ToString(), out ret);
			}

			return ret;
		}

		public static bool login(SQLiteConnection sqlc, string username, string password)
		{
			bool ret = false;
			if (sqlc.State != ConnectionState.Open) { return false; }

			SQLiteCommand sqlk = new SQLiteCommand("SELECT count(id) FROM users WHERE username = '" + username + "' and password= '" + password + "'", sqlc);
			var rr = sqlk.ExecuteScalar();
			if (rr is null || rr.ToString() == "0") { ret = false; }
			else { ret = true; }

			return ret;
		}

		public static string getData(SQLiteConnection sqlc, string date, string username)
		{
			if (sqlc.State != ConnectionState.Open) { return "ERROR:NoOpenConnection"; }

			int userid = getUserId(sqlc, username);

			if(userid == -1) { return "ERROR:NoSuchUser"; }

			string ret = "";

			SQLiteCommand sqlk = new SQLiteCommand(string.Format("SELECT count(date) FROM data WHERE date = '{0}' AND userid = {1}", date, userid), sqlc);
			var count = sqlk.ExecuteScalar();

			if (count.ToString() != "0")
			{
				sqlk = new SQLiteCommand(string.Format("SELECT data FROM data WHERE date='{0}' AND userid={1}", date, userid), sqlc);
				ret = sqlk.ExecuteScalar().ToString();
			}

			return ret;
		}

		public static List<DateTime> getDatesWithData(SQLiteConnection sqlc, string username)
		{
			if (sqlc.State != ConnectionState.Open) { return null; }
			int userid = getUserId(sqlc, username);
			if (userid == -1) { return null; }

			List<DateTime> dates = new List<DateTime>();

			SQLiteCommand sqlk = new SQLiteCommand(string.Format("SELECT date FROM data WHERE userid = {0}", userid), sqlc);
			var read = sqlk.ExecuteReader();

			while(read.NextResult())
			{
				DateTime tmp = default(DateTime);
				if(DateTime.TryParse(read.GetString(read.GetOrdinal("date")), out tmp))
				{
					dates.Add(tmp);
				}
			}

			return dates;
		}
	}
	
}
