namespace Cat
{
	partial class ColorSchemeDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbYellowOnNavy = new System.Windows.Forms.RadioButton();
			this.rbWhiteOnGreen = new System.Windows.Forms.RadioButton();
			this.rbWhiteOnBlack = new System.Windows.Forms.RadioButton();
			this.btnSave = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.rbYellowOnNavy);
			this.groupBox1.Controls.Add(this.rbWhiteOnGreen);
			this.groupBox1.Controls.Add(this.rbWhiteOnBlack);
			this.groupBox1.Location = new System.Drawing.Point(15, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(339, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color Scheme";
			// 
			// rbYellowOnNavy
			// 
			this.rbYellowOnNavy.AutoSize = true;
			this.rbYellowOnNavy.Location = new System.Drawing.Point(10, 87);
			this.rbYellowOnNavy.Name = "rbYellowOnNavy";
			this.rbYellowOnNavy.Size = new System.Drawing.Size(140, 24);
			this.rbYellowOnNavy.TabIndex = 2;
			this.rbYellowOnNavy.TabStop = true;
			this.rbYellowOnNavy.Text = "Yellow on Navy";
			this.rbYellowOnNavy.UseVisualStyleBackColor = true;
			// 
			// rbWhiteOnGreen
			// 
			this.rbWhiteOnGreen.AutoSize = true;
			this.rbWhiteOnGreen.Location = new System.Drawing.Point(10, 57);
			this.rbWhiteOnGreen.Name = "rbWhiteOnGreen";
			this.rbWhiteOnGreen.Size = new System.Drawing.Size(146, 24);
			this.rbWhiteOnGreen.TabIndex = 1;
			this.rbWhiteOnGreen.TabStop = true;
			this.rbWhiteOnGreen.Text = "White on Green";
			this.rbWhiteOnGreen.UseVisualStyleBackColor = true;
			// 
			// rbWhiteOnBlack
			// 
			this.rbWhiteOnBlack.AutoSize = true;
			this.rbWhiteOnBlack.Location = new System.Drawing.Point(10, 26);
			this.rbWhiteOnBlack.Name = "rbWhiteOnBlack";
			this.rbWhiteOnBlack.Size = new System.Drawing.Size(140, 24);
			this.rbWhiteOnBlack.TabIndex = 0;
			this.rbWhiteOnBlack.TabStop = true;
			this.rbWhiteOnBlack.Text = "White on Black";
			this.rbWhiteOnBlack.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.Location = new System.Drawing.Point(150, 146);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 32);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Change";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(175, 25);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(140, 24);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Black on White";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(176, 57);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(137, 24);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Black on Silver";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(176, 86);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(138, 24);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Black on Khaki";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// ColorSchemeDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(375, 190);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ColorSchemeDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Color Scheme";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RadioButton rbYellowOnNavy;
		private System.Windows.Forms.RadioButton rbWhiteOnGreen;
		private System.Windows.Forms.RadioButton rbWhiteOnBlack;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}