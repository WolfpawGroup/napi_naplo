using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napi_naplo
{
	public partial class f_NewUsr : Form
	{
		public SQLiteConnection sqlc { get; set; }


		public f_NewUsr()
		{
			InitializeComponent();
		}

		private void btn_Create_Click(object sender, EventArgs e)
		{
			string res = c_DBManager.addUser(sqlc, tb_Username.Text, c_DBManager.getHash(tb_Pass.Text), DateTime.Now.ToShortDateString(), tb_Email.Text);

			if (res.StartsWith("ERROR"))
			{
				lbl_Result.Text = res;
			}
			else
			{
				
				this.Close();
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_ShowHidePass_MouseDown(object sender, MouseEventArgs e)
		{
			tb_Pass.PasswordChar = '\0';
		}

		private void btn_ShowHidePass_MouseUp(object sender, MouseEventArgs e)
		{
			tb_Pass.PasswordChar = '•';
		}
	}
}
