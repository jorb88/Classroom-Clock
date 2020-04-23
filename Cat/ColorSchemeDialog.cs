using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cat
{
	public partial class ColorSchemeDialog : Form
	{
		private ClockPrefs prefs;
		private RadioButton[] rbuttons;
		private Color[] backColors = { Color.Black, Color.DarkGreen, Color.Navy, Color.White, Color.Silver, Color.Khaki };
		private Color[] foreColors = { Color.White, Color.White, Color.Yellow, Color.Black, Color.Black, Color.Black };
		public ColorSchemeDialog(ClockPrefs prefs)
		{
			this.prefs = prefs;
			InitializeComponent();
			rbuttons = new RadioButton[] { rbWhiteOnBlack, rbWhiteOnGreen, rbYellowOnNavy, radioButton1, radioButton2, radioButton3 };
			for (int i = 0; i < rbuttons.Length; i++)
			{
				if (backColors[i] == prefs.BackColor)
				{
					rbuttons[i].Checked = true;
					break;
				}
			}
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			int i = 0;
			foreach (RadioButton rb in rbuttons)
			{
				if (rb.Checked)
				{
					prefs.BackColor = backColors[i];
					prefs.ForeColor = foreColors[i];
					break;
				}
				i++;
			}
			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}
	}
}
