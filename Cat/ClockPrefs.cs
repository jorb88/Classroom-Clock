using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cat
{
	[Serializable]
	public class ClockPrefs : IPreferenceData
	{
		public Color BackColor { get; set; } = Color.Black;
		public Color ForeColor { get; set; } = Color.White;
		public Color ArcColor { get; set; } = Color.Red;
	}
}
