using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napi_naplo
{
	public partial class c_MyCalendar : MonthCalendar
	{
		public c_MyCalendar()
		{
			InitializeComponent();
			
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			
		}
	}
}
