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
		public List<DateTime> datesWithData { get; set; }
		private List<DateTime> _visibleDates { get; set; }

		private DateTime _firstVisibleDate;
		private DateTime _lastVisibleDate;

		private int _calendarWidth	= 0;
		private int _calendarHeight	= 0;
		private int _numOfMonths	= 0;
		private int _monthWidth		= 0;
		private int _monthHeight	= 0;
		private int _monthsInRow	= 0;
		private int _monthRows		= 0;
		private int _visibleMonths	= 0;


		public c_MyCalendar()
		{
			InitializeComponent();
			
			this.HandleCreated += C_MyCalendar_HandleCreated;
		}

		private void C_MyCalendar_HandleCreated(object sender, EventArgs e)
		{
			getVisibleDates();
			getDimentions();
			this.DateChanged		+= paint;
			this.SizeChanged		+= paint;
			this.LocationChanged	+= paint;
			this.LostFocus			+= paint;
			this.GotFocus			+= paint;
			this.MouseEnter			+= paint;
			this.MouseLeave			+= paint;
			this.Enter				+= paint;
			this.Leave				+= paint;
		}

		public void getVisibleDates()
		{
			_firstVisibleDate	= this.GetDisplayRange(true).Start;
			_lastVisibleDate	= this.GetDisplayRange(true).End;
			_numOfMonths		= (int)((_lastVisibleDate - _firstVisibleDate).Days / (365.25 / 12));

			_visibleDates		= new List<DateTime>();
			DateTime dd			= _firstVisibleDate;

			while(dd <= _firstVisibleDate)
			{
				_visibleDates.Add(dd);
				dd = dd.Add(new TimeSpan(1, 0, 0, 0));
			}
		}

		public void getDimentions()
		{
			_monthHeight	= this.SingleMonthSize.Height;
			_monthWidth		= this.SingleMonthSize.Width;
			_calendarHeight = this.Height;
			_calendarWidth	= this.Width;
			_monthsInRow	= _calendarWidth / _monthWidth;
			_monthRows		= _calendarHeight / _monthHeight;
			_visibleMonths	= _monthsInRow * _monthRows;
		}

		public void paint(object o1 = null, object o2 = null)
		{
			Graphics graphics = Graphics.FromHwnd(this.Handle);
			PaintEventArgs pe = new PaintEventArgs(graphics, new Rectangle(0, 0, this.Width, this.Height));
			OnPaint(pe);
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			
			if(datesWithData != null && datesWithData.Count > 0)
			{
				foreach(DateTime d in datesWithData)
				{
					if (_visibleDates.Contains(d)) { this.AddBoldedDate(d); UpdateBoldedDates(); }
				}
			}
		}
	}
}
