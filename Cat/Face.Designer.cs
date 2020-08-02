namespace Cat
{
	partial class Face
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Face));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.txtTimeToGo = new System.Windows.Forms.TextBox();
			this.txtEndTime = new System.Windows.Forms.TextBox();
			this.lblEnd = new System.Windows.Forms.Label();
			this.lblLeft = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorSchemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arcColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.add60MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.breakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lunchDinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.doNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupDiscussionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exercise11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTodaysDate = new System.Windows.Forms.TextBox();
			this.txtRightNow = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtTimeToGo
			// 
			this.txtTimeToGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTimeToGo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTimeToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimeToGo.Location = new System.Drawing.Point(526, 372);
			this.txtTimeToGo.Name = "txtTimeToGo";
			this.txtTimeToGo.Size = new System.Drawing.Size(120, 37);
			this.txtTimeToGo.TabIndex = 17;
			this.txtTimeToGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTimeToGo.Visible = false;
			// 
			// txtEndTime
			// 
			this.txtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndTime.Location = new System.Drawing.Point(483, 328);
			this.txtEndTime.Name = "txtEndTime";
			this.txtEndTime.Size = new System.Drawing.Size(164, 37);
			this.txtEndTime.TabIndex = 16;
			this.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtEndTime.Visible = false;
			// 
			// lblEnd
			// 
			this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEnd.AutoSize = true;
			this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnd.Location = new System.Drawing.Point(394, 328);
			this.lblEnd.Name = "lblEnd";
			this.lblEnd.Size = new System.Drawing.Size(83, 37);
			this.lblEnd.TabIndex = 19;
			this.lblEnd.Text = "End:";
			// 
			// lblLeft
			// 
			this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLeft.AutoSize = true;
			this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeft.Location = new System.Drawing.Point(394, 369);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(135, 37);
			this.lblLeft.TabIndex = 20;
			this.lblLeft.Text = "Remain:";
			// 
			// txtNotes
			// 
			this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Location = new System.Drawing.Point(406, 78);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(246, 249);
			this.txtNotes.TabIndex = 27;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.prefsToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(664, 33);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// prefsToolStripMenuItem
			// 
			this.prefsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSchemesToolStripMenuItem,
            this.arcColorToolStripMenuItem,
            this.resetToolStripMenuItem});
			this.prefsToolStripMenuItem.Name = "prefsToolStripMenuItem";
			this.prefsToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
			this.prefsToolStripMenuItem.Text = "&Prefs";
			// 
			// colorSchemesToolStripMenuItem
			// 
			this.colorSchemesToolStripMenuItem.Name = "colorSchemesToolStripMenuItem";
			this.colorSchemesToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
			this.colorSchemesToolStripMenuItem.Text = "&Color Schemes";
			this.colorSchemesToolStripMenuItem.Click += new System.EventHandler(this.colorSchemesToolStripMenuItem_Click);
			// 
			// arcColorToolStripMenuItem
			// 
			this.arcColorToolStripMenuItem.Name = "arcColorToolStripMenuItem";
			this.arcColorToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
			this.arcColorToolStripMenuItem.Text = "&Arc Color";
			this.arcColorToolStripMenuItem.Click += new System.EventHandler(this.arcColorToolStripMenuItem_Click);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
			this.resetToolStripMenuItem.Text = "&Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// timerToolStripMenuItem
			// 
			this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add60MinutesToolStripMenuItem,
            this.stopTimerToolStripMenuItem});
			this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
			this.timerToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
			this.timerToolStripMenuItem.Text = "&Timer";
			// 
			// add60MinutesToolStripMenuItem
			// 
			this.add60MinutesToolStripMenuItem.Name = "add60MinutesToolStripMenuItem";
			this.add60MinutesToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
			this.add60MinutesToolStripMenuItem.Text = "&Add 60 Minutes";
			this.add60MinutesToolStripMenuItem.Click += new System.EventHandler(this.add60MinutesToolStripMenuItem_Click);
			// 
			// stopTimerToolStripMenuItem
			// 
			this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
			this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
			this.stopTimerToolStripMenuItem.Text = "&Stop Timer";
			this.stopTimerToolStripMenuItem.Click += new System.EventHandler(this.stopTimerToolStripMenuItem_Click);
			// 
			// activityToolStripMenuItem
			// 
			this.activityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.breakToolStripMenuItem,
            this.lunchDinnerToolStripMenuItem,
            this.doNowToolStripMenuItem,
            this.groupDiscussionToolStripMenuItem,
            this.exercise11ToolStripMenuItem,
            this.startAtToolStripMenuItem});
			this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
			this.activityToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
			this.activityToolStripMenuItem.Text = "&Activity";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 34);
			this.toolStripMenuItem1.Text = "Activity";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// breakToolStripMenuItem
			// 
			this.breakToolStripMenuItem.Name = "breakToolStripMenuItem";
			this.breakToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.breakToolStripMenuItem.Text = "&Break";
			this.breakToolStripMenuItem.Click += new System.EventHandler(this.breakToolStripMenuItem_Click);
			// 
			// lunchDinnerToolStripMenuItem
			// 
			this.lunchDinnerToolStripMenuItem.Name = "lunchDinnerToolStripMenuItem";
			this.lunchDinnerToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.lunchDinnerToolStripMenuItem.Text = "&Lunch/Dinner";
			this.lunchDinnerToolStripMenuItem.Click += new System.EventHandler(this.lunchDinnerToolStripMenuItem_Click);
			// 
			// doNowToolStripMenuItem
			// 
			this.doNowToolStripMenuItem.Name = "doNowToolStripMenuItem";
			this.doNowToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.doNowToolStripMenuItem.Text = "Do Now";
			this.doNowToolStripMenuItem.Click += new System.EventHandler(this.doNowToolStripMenuItem_Click);
			// 
			// groupDiscussionToolStripMenuItem
			// 
			this.groupDiscussionToolStripMenuItem.Name = "groupDiscussionToolStripMenuItem";
			this.groupDiscussionToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.groupDiscussionToolStripMenuItem.Text = "Discussion";
			this.groupDiscussionToolStripMenuItem.Click += new System.EventHandler(this.groupDiscussionToolStripMenuItem_Click);
			// 
			// exercise11ToolStripMenuItem
			// 
			this.exercise11ToolStripMenuItem.Name = "exercise11ToolStripMenuItem";
			this.exercise11ToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.exercise11ToolStripMenuItem.Text = "Exercise";
			this.exercise11ToolStripMenuItem.Click += new System.EventHandler(this.exercise11ToolStripMenuItem_Click);
			// 
			// startAtToolStripMenuItem
			// 
			this.startAtToolStripMenuItem.Name = "startAtToolStripMenuItem";
			this.startAtToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
			this.startAtToolStripMenuItem.Text = "&Start At";
			this.startAtToolStripMenuItem.Click += new System.EventHandler(this.startAtToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// howToUseToolStripMenuItem
			// 
			this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
			this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
			this.howToUseToolStripMenuItem.Text = "&How to Use";
			this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
			// 
			// txtTodaysDate
			// 
			this.txtTodaysDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTodaysDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTodaysDate.Location = new System.Drawing.Point(360, 6);
			this.txtTodaysDate.Name = "txtTodaysDate";
			this.txtTodaysDate.Size = new System.Drawing.Size(279, 23);
			this.txtTodaysDate.TabIndex = 30;
			this.txtTodaysDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtRightNow
			// 
			this.txtRightNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRightNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRightNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRightNow.Location = new System.Drawing.Point(394, 35);
			this.txtRightNow.Name = "txtRightNow";
			this.txtRightNow.Size = new System.Drawing.Size(246, 37);
			this.txtRightNow.TabIndex = 31;
			this.txtRightNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Face
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(664, 423);
			this.Controls.Add(this.txtRightNow);
			this.Controls.Add(this.txtTodaysDate);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtTimeToGo);
			this.Controls.Add(this.txtEndTime);
			this.Controls.Add(this.lblEnd);
			this.Controls.Add(this.lblLeft);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "Face";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Classroom Clock and Timer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.TextBox txtTimeToGo;
		private System.Windows.Forms.TextBox txtEndTime;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.Label lblLeft;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prefsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorSchemesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arcColorToolStripMenuItem;
		private System.Windows.Forms.TextBox txtTodaysDate;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem add60MinutesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem breakToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lunchDinnerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem doNowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem groupDiscussionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exercise11ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem startAtToolStripMenuItem;
		private System.Windows.Forms.TextBox txtRightNow;
	}
}

