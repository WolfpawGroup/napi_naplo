using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace napi_naplo
{
	public partial class f_Login : Form
	{
		SQLiteConnection sqlc = null;

		public f_Login()
		{
			InitializeComponent();

			Load += F_Login_Load;
		}

		private void F_Login_Load(object sender, EventArgs e)
		{
			c_DBManager.createFile();
			sqlc = c_DBManager.connect();
			c_DBManager.createTables(sqlc);
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			//TODO: md5
			bool b = c_DBManager.login(sqlc, tb_Username.Text, c_DBManager.getHash(tb_Pass.Text));
			if (b)
			{
				Form1 f1 = new Form1();
				f1.loggedInAs = tb_Username.Text;
				f1.sqlc = sqlc;
				Hide();
				f1.ShowDialog();
				Show();
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_NewUser_Click(object sender, EventArgs e)
		{
			f_NewUsr fn = new f_NewUsr();
			fn.sqlc = sqlc;
			fn.ShowDialog();
		}

		private void tb_Username_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn_Login_Click(null, null);
			}else if(e.KeyCode == Keys.Escape)
			{
				btn_Cancel_Click(null, null);
			}
		}
	}
}
