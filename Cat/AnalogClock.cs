using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cat
{
	public class AnalogClock : UserControl
	{
		private DateTime lastTimeShown;
		private DateTime newTime;
		private int lastBreakEndMinute = -1;
		private int timerEndMinute = -1;
		private int hoursToGo = 0;
		private DateTime timerEndTime = new DateTime(0);
		public DateTime TimerEndTime
		{
			get { return timerEndTime; }
			set
			{
				timerEndTime = value;
				int sec = timerEndTime.Second;
				if (sec == 0) return;
				if (sec < 30) timerEndTime = timerEndTime.AddSeconds(-sec);
				else timerEndTime = timerEndTime.AddSeconds(60 - sec);
			}
		}
		public Color ArcColor { get; set; } = Color.Red;
		public AnalogClock()
		{
			Graphics grfx = CreateGraphics();
			InitializeCoordinates(grfx);
			Pen bpen = new Pen(BackColor);
			Pen fpen = new Pen(ForeColor);
			Brush fbrush = new SolidBrush(ForeColor);
			Brush bbrush = new SolidBrush(BackColor);
			lastTimeShown = new DateTime(0);
			newTime = DateTime.Now;
			lastBreakEndMinute = -1;
			timerEndMinute = -1;
			ResizeRedraw = true;
			Enabled = false;
			grfx.Dispose();
		}
		void InitializeCoordinates(Graphics grfx)
		{
			if (Width == 0 || Height == 0) return;
			grfx.TranslateTransform(Width / 2, Height / 2);
			float fInches = Math.Min(Width / grfx.DpiX, Height / grfx.DpiY);
			grfx.ScaleTransform(fInches * grfx.DpiX / 2000, fInches * grfx.DpiY / 2000);
		}
		public void Tick()
		{
			Graphics grfx = CreateGraphics();
			InitializeCoordinates(grfx);
			newTime = DateTime.Now;
			if (timerEndTime < newTime)
			{
				timerEndMinute = -1;
				hoursToGo = 0;
			}
			else
			{
				timerEndMinute = timerEndTime.Minute;
				hoursToGo = (timerEndTime - DateTime.Now).Hours;
			}
			Pen bpen = new Pen(BackColor);
			Pen fpen = new Pen(ForeColor);
			Brush fbrush = new SolidBrush(ForeColor);
			Brush bbrush = new SolidBrush(BackColor);
			if (lastTimeShown.Hour != newTime.Hour)
			{
				DrawHourHand(lastTimeShown, grfx, bpen, bbrush);
			}
			if (lastTimeShown.Minute != newTime.Minute)
			{
				ClearBreakArc(grfx);
				DrawHourHand(lastTimeShown, grfx, bpen, bbrush);
				DrawMinuteHand(lastTimeShown, grfx, bpen, bbrush);
			}
			if (lastTimeShown.Second != newTime.Second)
			{
				DrawSecondHand(lastTimeShown, grfx, bpen);
			}
			if (timerEndMinute != lastBreakEndMinute)
			{
				ClearBreakArc(grfx);
				lastBreakEndMinute = timerEndMinute;
			}
			if (timerEndTime > DateTime.Now) DrawBreakArc(grfx, ArcColor);
			DrawHourHand(newTime, grfx, fpen, fbrush);
			DrawMinuteHand(newTime, grfx, fpen, fbrush);
			DrawSecondHand(newTime, grfx, fpen);
			lastTimeShown = newTime;
			grfx.Dispose();
		}
		protected override void OnPaint(PaintEventArgs pea)
		{
			Graphics grfx = pea.Graphics;
			Pen pen = new Pen(ForeColor);
			Brush brush = new SolidBrush(ForeColor);
			InitializeCoordinates(grfx);
			DrawDots(grfx, brush);
			DrawHourHand(newTime, grfx, pen, brush);
			DrawMinuteHand(newTime, grfx, pen, brush);
		}
		void DrawDots(Graphics grfx, Brush brush)
		{
			for (int i = 0; i < 60; i++)
			{
				int iSize = i % 5 == 0 ? 100 : 30;
				grfx.FillEllipse(brush, 0 - iSize / 2, -900 - iSize / 2, iSize, iSize);
				grfx.RotateTransform(6);
			}
		}
		protected virtual void DrawHourHand(DateTime time, Graphics grfx, Pen pen, Brush brush)
		{
			GraphicsState gs = grfx.Save();
			grfx.RotateTransform(360f * time.Hour / 12 + 30f * time.Minute / 60);
			Point[] points = { new Point(0, 150), new Point(100, 0), new Point(0, -600), new Point(-100, 0) };
			grfx.FillPolygon(brush, points);
			grfx.Restore(gs);
		}
		protected virtual void DrawMinuteHand(DateTime time, Graphics grfx, Pen pen, Brush brush)
		{
			GraphicsState gs = grfx.Save();
			grfx.RotateTransform(360f * time.Minute / 60);
			Point[] points = { new Point(0, 200), new Point(50, 0), new Point(0, -800), new Point(-50, 0) };
			grfx.FillPolygon(brush, points);
			grfx.Restore(gs);
		}
		protected virtual void DrawSecondHand(DateTime time, Graphics grfx, Pen pen)
		{
			Pen p = pen;
			p = new Pen(pen.Color, 10.0f);
			GraphicsState gs = grfx.Save();
			grfx.RotateTransform(360f * (float)time.Second / (float)60); // + 6f * time.Millisecond / 1000);
			grfx.DrawLine(p, 0, 0, 0, -800);
			grfx.Restore(gs);
		}
		private int fudge = -700; // Draw fudge factor
		protected virtual void DrawBreakArc(Graphics grfx, Color color)
		{
			if (timerEndMinute < 0) return;
			//if ((timerEndSecond != 0) && (hoursToGo < 1))
			//{
			//	TimeSpan remaining = TimerEndTime - DateTime.Now;
			//	if (remaining.Seconds < timerEndSecond)
			//		return;
			//}
			Pen p = new Pen(color, 60.0f);
			float min = newTime.Minute + .5f;
			if (hoursToGo >= 1) min = timerEndMinute + .5f;
			if (min > 60.0f) min = min - 60.0f;
			while (timerEndMinute != min)
			{
				int len = fudge;
				if (min == (float)newTime.Minute) len = -800;
				DrawArcSegment(grfx, p, len, min);
				min += .5f;
				if (min >= 60.0f) min = 0.0f;
			}
			p = new Pen(ForeColor, 20.0f);
			DrawArcSegment(grfx, p, fudge, timerEndMinute);
			DrawArcSegment(grfx, p, fudge, timerEndMinute - .2f);
		}
		protected virtual void ClearBreakArc(Graphics grfx)
		{
			Pen p = new Pen(BackColor, 60.0f);
			for (int min = 0; min < 120; min++)
			{
				float d = min / 2.0f;
				GraphicsState gs = grfx.Save();
				grfx.RotateTransform(360f * d / 60);
				grfx.DrawLine(p, 0, fudge, 0, -825);
				grfx.Restore(gs);
			}
		}
		private void DrawArcSegment(Graphics grfx, Pen p, int len, float min)
		{
			GraphicsState gs = grfx.Save();
			grfx.RotateTransform(360f * min / 60);
			grfx.DrawLine(p, 0, len, 0, -825);
			grfx.Restore(gs);
		}
		public int GetNearestMinuteToCoordinate(int x, int y)
		{
			int min = -1;
			try
			{
				double x0 = Location.X;
				double y0 = Location.Y;
				double w = Width;
				double h = Height;
				double xc = w / 2 + x0;
				double yc = h / 2 + y0;
				double ang = -Math.Atan2(xc - x, yc - y);
				ang = ang * Math.PI * Math.PI;
				if ((ang > -0.66) && (ang < 0.66)) min = 0;
				else if (ang < 0.0) min = 60 + (int)ang;
				else if (ang > 0.0) min = (int)(ang);
			}
			catch (Exception e)
			{
				return -e.GetHashCode();
			}
			return min;
		}
	}
}
