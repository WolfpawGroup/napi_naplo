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
	public partial class Form1 : Form
	{

		public SQLiteConnection sqlc { get; set; }
		public string loggedInAs { get; set; }
		DateTime selectedDate = default(DateTime);

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Logged in as: " + loggedInAs;
			getDates();
		}

		public void getDates()
		{
			List<DateTime> dates = c_DBManager.getDatesWithData(sqlc, loggedInAs);
			foreach(var d in dates)
			{
				mc_Calendar.AddAnnuallyBoldedDate(d);
			}
			mc_Calendar.Font = new Font("Courier New", 12, FontStyle.Regular);
			mc_Calendar.Update();
			mc_Calendar.UpdateBoldedDates();
		}

		private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
		{
			
		}

		public void dotest()
		{
			string encdata = c_DBManager.encryptData(tb_Data.Text, loggedInAs);
			string decdata = c_DBManager.decryptData(encdata, loggedInAs);
			Console.WriteLine("=========================================");
			Console.WriteLine("ORIGINAL:  " + tb_Data.Text);
			Console.WriteLine("ENCRYPTED: " + encdata);
			Console.WriteLine("DECRYPTED: " + decdata);
			Console.WriteLine("=========================================");
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			//dotest();
			c_DBManager.addData(sqlc, selectedDate.ToShortDateString(), c_DBManager.encryptData(tb_Data.Text, loggedInAs), loggedInAs);
		}

		private void mc_Calendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			selectedDate = mc_Calendar.SelectionStart;

			lbl_Date.Text ="Selected date: " + selectedDate.ToShortDateString();
			lbl_Date.Left = btn_Save.Left - lbl_Date.Width - 10;

			tb_Data.Text = c_DBManager.decryptData(c_DBManager.getData(sqlc, selectedDate.ToShortDateString(), loggedInAs), loggedInAs);
		}
	}
}
