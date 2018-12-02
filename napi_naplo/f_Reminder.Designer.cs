namespace napi_naplo
{
	partial class f_Reminder
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
			this.label1 = new System.Windows.Forms.Label();
			this.rb_Username = new System.Windows.Forms.RadioButton();
			this.rb_Password = new System.Windows.Forms.RadioButton();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_UseBackupEmail = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tb_BackupEmail = new System.Windows.Forms.TextBox();
			this.tb_Email = new System.Windows.Forms.TextBox();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.btn_SendEmail = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_Code = new System.Windows.Forms.TextBox();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.btn_ChangePass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "I forgot my...";
			// 
			// rb_Username
			// 
			this.rb_Username.AutoSize = true;
			this.rb_Username.Location = new System.Drawing.Point(83, 7);
			this.rb_Username.Name = "rb_Username";
			this.rb_Username.Size = new System.Drawing.Size(71, 17);
			this.rb_Username.TabIndex = 1;
			this.rb_Username.Text = "username";
			this.rb_Username.UseVisualStyleBackColor = true;
			// 
			// rb_Password
			// 
			this.rb_Password.AutoSize = true;
			this.rb_Password.Checked = true;
			this.rb_Password.Location = new System.Drawing.Point(83, 30);
			this.rb_Password.Name = "rb_Password";
			this.rb_Password.Size = new System.Drawing.Size(70, 17);
			this.rb_Password.TabIndex = 2;
			this.rb_Password.TabStop = true;
			this.rb_Password.Text = "password";
			this.rb_Password.UseVisualStyleBackColor = true;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Cancel.Location = new System.Drawing.Point(0, 213);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(521, 27);
			this.btn_Cancel.TabIndex = 4;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "My username is ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "My email address is ";
			// 
			// cb_UseBackupEmail
			// 
			this.cb_UseBackupEmail.AutoSize = true;
			this.cb_UseBackupEmail.Location = new System.Drawing.Point(15, 116);
			this.cb_UseBackupEmail.Name = "cb_UseBackupEmail";
			this.cb_UseBackupEmail.Size = new System.Drawing.Size(364, 17);
			this.cb_UseBackupEmail.TabIndex = 7;
			this.cb_UseBackupEmail.Text = "I can\'t reach that account. Please send the email to my backup address";
			this.cb_UseBackupEmail.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "My backup email address is ";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Location = new System.Drawing.Point(-2, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 3);
			this.panel1.TabIndex = 9;
			// 
			// tb_BackupEmail
			// 
			this.tb_BackupEmail.Location = new System.Drawing.Point(179, 140);
			this.tb_BackupEmail.Name = "tb_BackupEmail";
			this.tb_BackupEmail.Size = new System.Drawing.Size(330, 20);
			this.tb_BackupEmail.TabIndex = 10;
			// 
			// tb_Email
			// 
			this.tb_Email.Location = new System.Drawing.Point(179, 90);
			this.tb_Email.Name = "tb_Email";
			this.tb_Email.Size = new System.Drawing.Size(330, 20);
			this.tb_Email.TabIndex = 11;
			// 
			// tb_Username
			// 
			this.tb_Username.Location = new System.Drawing.Point(179, 67);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(330, 20);
			this.tb_Username.TabIndex = 12;
			// 
			// btn_SendEmail
			// 
			this.btn_SendEmail.Location = new System.Drawing.Point(15, 171);
			this.btn_SendEmail.Name = "btn_SendEmail";
			this.btn_SendEmail.Size = new System.Drawing.Size(494, 25);
			this.btn_SendEmail.TabIndex = 13;
			this.btn_SendEmail.Text = "Send Email";
			this.btn_SendEmail.UseVisualStyleBackColor = true;
			this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Location = new System.Drawing.Point(-5, 204);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(530, 3);
			this.panel2.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Location = new System.Drawing.Point(-5, 303);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(530, 3);
			this.panel3.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "The code I received is";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "The ID key is ";
			// 
			// tb_Code
			// 
			this.tb_Code.Location = new System.Drawing.Point(179, 216);
			this.tb_Code.Name = "tb_Code";
			this.tb_Code.Size = new System.Drawing.Size(330, 20);
			this.tb_Code.TabIndex = 18;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(179, 247);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(330, 20);
			this.tb_ID.TabIndex = 19;
			// 
			// btn_ChangePass
			// 
			this.btn_ChangePass.Location = new System.Drawing.Point(15, 274);
			this.btn_ChangePass.Name = "btn_ChangePass";
			this.btn_ChangePass.Size = new System.Drawing.Size(494, 23);
			this.btn_ChangePass.TabIndex = 20;
			this.btn_ChangePass.Text = "Change my Password";
			this.btn_ChangePass.UseVisualStyleBackColor = true;
			this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
			// 
			// f_Reminder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 240);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_SendEmail);
			this.Controls.Add(this.tb_Username);
			this.Controls.Add(this.tb_Email);
			this.Controls.Add(this.tb_BackupEmail);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cb_UseBackupEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rb_Password);
			this.Controls.Add(this.rb_Username);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_ChangePass);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.tb_Code);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "f_Reminder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Send information to my email";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rb_Username;
		private System.Windows.Forms.RadioButton rb_Password;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cb_UseBackupEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tb_BackupEmail;
		private System.Windows.Forms.TextBox tb_Email;
		private System.Windows.Forms.TextBox tb_Username;
		private System.Windows.Forms.Button btn_SendEmail;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_Code;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.Button btn_ChangePass;
	}
}