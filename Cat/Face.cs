using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Cat
{
	public partial class Face : Form
	{
		private AnalogClock clock = new AnalogClock();
		private Control[] timerControls;
		private Control[] colorControls;
		private double ratio;
		private PrefsManager<ClockPrefs> prefs = new PrefsManager<ClockPrefs>();
		public Face()
		{
			InitializeComponent();
			timerControls = new Control[] { txtEndTime, lblEnd, txtTimeToGo, lblLeft};
			colorControls = new Control[] { txtTodaysDate, txtRightNow, this, menuStrip1, txtTimeToGo, txtEndTime, clock, lblEnd, lblLeft, txtNotes };
//			txtTimeNow.Text = string.Empty;
			txtTimeToGo.Text = string.Empty;
			clock.Location = new Point(10, 17);
			clock.Width = this.Height - 64;
			clock.Height = this.Height - 64;
			clock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Controls.Add(clock);
			foreach (Control c in timerControls) c.Visible = false;
			foreach (Control c in colorControls)
			{
				c.BackColor = prefs.Data.BackColor;
				c.ForeColor = prefs.Data.ForeColor;
			}
			clock.ArcColor = prefs.Data.ArcColor;
			txtRightNow.TextAlign = HorizontalAlignment.Right;
			txtTodaysDate.TextAlign = HorizontalAlignment.Right;
			timer1.Start();
			ratio = (double) this.Height / (double)this.Width;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			clock.Tick();
			UpdateDigitalTimeDisplay();
			if (clock.BreakEndTime <= DateTime.Now)
			{
				foreach (Control c in timerControls) c.Visible = false;
			}
			else
			{
				TimeSpan ttg = clock.TimerEndTime - DateTime.Now;
				string t = ttg.ToString().Substring(0, 8).Trim();
				if (t.EndsWith(".")) t = t.Substring(0, 7);
				while (t.StartsWith("0") || t.StartsWith(":"))
					t = t.Substring(1, t.Length-1);
				txtTimeToGo.Text = t;
				t = clock.TimerEndTime.ToLongTimeString().Substring(0, 8).Trim();
				txtEndTime.Text = t;
			}
		}
		private void UpdateDigitalTimeDisplay()
		{
			float xClockCenter = clock.Width / 2.0f + clock.Location.X;
			float yClockCenter = clock.Height / 2.0f + clock.Location.Y;
			float clockRadius = clock.Width / 2.0f;
			if (clock.Height < clock.Width) clockRadius = clock.Height / 2.0f;
			int xloc = (int)(xClockCenter - (clockRadius/2.5));
			int yloc = (int)(yClockCenter + (clockRadius / 3.0));
			txtRightNow.Text = DateTime.Now.ToLongTimeString() + " " + TZC(TimeZone.CurrentTimeZone.StandardName); ;
		}
		private string TZC(string standardName)
		{
			string tzc = "" + standardName[0];
			for (int i = 1; i < standardName.Length; i++)
			{
				if ((standardName[i] == ' ') && (i != standardName.Length))
				{
					tzc += standardName[i + 1];
				}
			}
			return tzc.ToUpper();
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (!ClickIsOnTheClock(e.X, e.Y)) return;
			int endMin = clock.GetNearestMinuteToCoordinate(e.X, e.Y);
			if (endMin < 0) return;
			DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, endMin, 0);
			if (endTime < DateTime.Now) endTime = endTime.AddHours(1.0);
			TimeSpan timeToGo = endTime.Subtract(DateTime.Now);
			clock.TimerEndMinute = endMin;
			clock.TimerEndTime = endTime;
			clock.TimerHoursToGo = 0;
			foreach (Control c in timerControls) c.Visible = true;
		}
		private bool ClickIsOnTheClock(int x, int y)
		{
			if (x <= clock.Location.X) return false;
			if (y <= clock.Location.Y) return false;
			int xHigh = clock.Location.X + clock.Width;
			if (x >= xHigh) return false;
			int yHigh = clock.Location.Y + clock.Height;
			if (y >= yHigh) return false;
			float xClockCenter = clock.Width / 2.0f + clock.Location.X;
			float yClockCenter = clock.Height / 2.0f + clock.Location.Y;
			float clockRadius = clock.Width / 2.0f;
			if (clock.Height < clock.Width) clockRadius = clock.Height / 2.0f;
			float xClickRelative = x - xClockCenter;
			float yClickRelative = y - yClockCenter;
			float dx = xClickRelative;// - xClockCenter;
			float dy = yClickRelative;// - yClockCenter;
			float h = (dx * dx) + (dy * dy);
			float d = (float)Math.Sqrt(h);
			float upperBound = clockRadius + 2;
			float lowerBound = upperBound * .75f;
			if ((d >= lowerBound) && (d <= upperBound)) return true;
			return false;
		}
		private void SetColor(Color back, Color fore)
		{
			foreach (Control c in colorControls)
			{
				c.BackColor = back;
				c.ForeColor = fore;
			}
		}
		private void lblBlack_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}
		private void lblBlack_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void colorSchemesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorSchemeDialog csd = new ColorSchemeDialog(prefs.Data);
			DialogResult dr = csd.ShowDialog(this);
			if (dr == DialogResult.Cancel) return;
			SetColor(prefs.Data.BackColor, prefs.Data.ForeColor);
			prefs.Save();
		}
		private void arcColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dc = new ColorDialog();
			DialogResult dr = dc.ShowDialog(this);
			if (dr == DialogResult.Cancel) return;
			prefs.Data.ArcColor = dc.Color;
			clock.ArcColor = dc.Color;
			prefs.Save();
		}
		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			prefs.DeletePrefsFile();
			prefs = new PrefsManager<ClockPrefs>();
			SetColor(prefs.Data.BackColor, prefs.Data.ForeColor);
			clock.ArcColor = prefs.Data.ArcColor;
		}
		private void add60MinutesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			clock.TimerHoursToGo++;
			if (clock.TimerEndTime < DateTime.Now)
			{
				clock.TimerEndTime = DateTime.Now;
				clock.TimerEndMinute = DateTime.Now.Minute;
			}
			clock.TimerEndTime = clock.TimerEndTime.AddHours(1);
			foreach (Control c in timerControls) c.Visible = true;
		}
		private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			clock.TimerHoursToGo = 0;
			clock.TimerEndTime = new DateTime(0);
			clock.TimerEndMinute = -1;
		}
		private void breakToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "BREAK";
		}
		private void lunchDinnerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "LUNCH or DINNER";
		}
		private void doNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "DO NOW ";
		}
		private void groupDiscussionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "DISCUSSION ";
		}
		private void exercise11ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "EXERCISE ";
		}
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine + "ACTIVITY ";
		}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			MessageBox.Show(this, "Written by Gregory Adams for Learning Tree International." + Environment.NewLine +
								   "Original release 2001/09/19" + Environment.NewLine +
								   "No copyright - Free for anyone to use,", "About the Classroom Clock V" + version,
								   MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = "Click on any minute to set timer end time." +
				Environment.NewLine + Environment.NewLine +
				"Type information notes into here.";
		}

		private void startAtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtNotes.Text = Environment.NewLine + Environment.NewLine +
				"WE WILL START AT " + clock.TimerEndTime.ToShortTimeString();
		}
	}
}

