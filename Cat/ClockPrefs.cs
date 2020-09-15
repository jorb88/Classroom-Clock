using System;
using System.Drawing;

namespace Cat
{
	[Serializable]
	public class ClockPrefs : IPreferenceData
	{
		public Color BackColor { get; set; } = Color.DarkGreen;
		public Color ForeColor { get; set; } = Color.White;
		public Color ArcColor { get; set; } = Color.Red;
	}
}
