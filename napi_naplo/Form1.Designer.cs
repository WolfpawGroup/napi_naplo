namespace napi_naplo
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.btn_Search = new System.Windows.Forms.ToolStripButton();
			this.btn_Print = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.mc_Calendar = new System.Windows.Forms.MonthCalendar();
			this.tb_Data = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(737, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 480);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(737, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
			this.toolStripStatusLabel1.Text = "Logged in as: ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.btn_Search,
            this.btn_Print});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(737, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
			// 
			// btn_Search
			// 
			this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
			this.btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(62, 22);
			this.btn_Search.Text = "Search";
			// 
			// btn_Print
			// 
			this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
			this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.Size = new System.Drawing.Size(52, 22);
			this.btn_Print.Text = "Print";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.mc_Calendar);
			this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tb_Data);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(737, 431);
			this.splitContainer1.SplitterDistance = 171;
			this.splitContainer1.TabIndex = 4;
			// 
			// mc_Calendar
			// 
			this.mc_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mc_Calendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2018, 3, 23, 0, 0, 0, 0)};
			this.mc_Calendar.CalendarDimensions = new System.Drawing.Size(4, 1);
			this.mc_Calendar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mc_Calendar.Location = new System.Drawing.Point(7, 5);
			this.mc_Calendar.MaxSelectionCount = 1;
			this.mc_Calendar.Name = "mc_Calendar";
			this.mc_Calendar.TabIndex = 0;
			this.mc_Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_Calendar_DateSelected);
			// 
			// tb_Data
			// 
			this.tb_Data.AcceptsReturn = true;
			this.tb_Data.AcceptsTab = true;
			this.tb_Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Data.Location = new System.Drawing.Point(0, 0);
			this.tb_Data.Multiline = true;
			this.tb_Data.Name = "tb_Data";
			this.tb_Data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_Data.Size = new System.Drawing.Size(737, 229);
			this.tb_Data.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbl_Date);
			this.panel1.Controls.Add(this.btn_Save);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 229);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(737, 27);
			this.panel1.TabIndex = 1;
			// 
			// lbl_Date
			// 
			this.lbl_Date.AutoSize = true;
			this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Date.Location = new System.Drawing.Point(367, 4);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(140, 18);
			this.lbl_Date.TabIndex = 1;
			this.lbl_Date.Text = "No Selected Date";
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(558, 2);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(175, 23);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 502);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Napi Napló";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripButton btn_Search;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MonthCalendar mc_Calendar;
		private System.Windows.Forms.TextBox tb_Data;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.ToolStripButton btn_Print;
		private System.Windows.Forms.Label lbl_Date;
	}
}

