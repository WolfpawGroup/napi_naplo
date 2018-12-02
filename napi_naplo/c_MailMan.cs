using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napi_naplo
{
	public static class c_MailMan
	{
		public static bool sendmail(string address, string data)
		{
			bool success = false;

			//todo: Email stuff here

			return success;
		}

		public static bool sendUsernameEmail(string address, string username)
		{
			return sendmail(address, generateUsernameData(username));
		}

		public static string[] sendPasswordEmail(string address, string username)
		{
			string[] keys = generateKeysForEmail(username);
			if (sendmail(address, generatePasswordResetData(keys)))
			{
				return keys;
			}
			else
			{
				return null;
			}
		}

		public static string generateUsernameData(string username)
		{
			string html = "";

			//TODO: Generate username html

			return html;
		}

		public static string generatePasswordResetData(string[] keys)
		{
			string html = "";

			//TODO: Generate password html

			return html;
		}

		public static string[] generateKeysForEmail(string username)
		{
			string[] ret = new string[] { "", "" };

			//TODO: Generate keys

			return ret;
		}
	}
}
