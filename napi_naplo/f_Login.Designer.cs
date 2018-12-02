namespace napi_naplo
{
	partial class f_Login
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
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.tb_Pass = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_NewUser = new System.Windows.Forms.Button();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Forgot = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password: ";
			// 
			// tb_Username
			// 
			this.tb_Username.Location = new System.Drawing.Point(77, 6);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(305, 20);
			this.tb_Username.TabIndex = 2;
			this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Username_KeyDown);
			// 
			// tb_Pass
			// 
			this.tb_Pass.Location = new System.Drawing.Point(77, 33);
			this.tb_Pass.Name = "tb_Pass";
			this.tb_Pass.PasswordChar = '*';
			this.tb_Pass.Size = new System.Drawing.Size(305, 20);
			this.tb_Pass.TabIndex = 3;
			this.tb_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Username_KeyDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(15, 63);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(88, 23);
			this.btn_Cancel.TabIndex = 4;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_NewUser
			// 
			this.btn_NewUser.Location = new System.Drawing.Point(106, 63);
			this.btn_NewUser.Name = "btn_NewUser";
			this.btn_NewUser.Size = new System.Drawing.Size(88, 23);
			this.btn_NewUser.TabIndex = 5;
			this.btn_NewUser.Text = "New User";
			this.btn_NewUser.UseVisualStyleBackColor = true;
			this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(294, 63);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(88, 23);
			this.btn_Login.TabIndex = 6;
			this.btn_Login.Text = "Log in";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Forgot
			// 
			this.btn_Forgot.Location = new System.Drawing.Point(200, 63);
			this.btn_Forgot.Name = "btn_Forgot";
			this.btn_Forgot.Size = new System.Drawing.Size(88, 23);
			this.btn_Forgot.TabIndex = 7;
			this.btn_Forgot.Text = "Reminder";
			this.btn_Forgot.UseVisualStyleBackColor = true;
			this.btn_Forgot.Click += new System.EventHandler(this.btn_Forgot_Click);
			// 
			// f_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 98);
			this.ControlBox = false;
			this.Controls.Add(this.btn_Forgot);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.btn_NewUser);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.tb_Pass);
			this.Controls.Add(this.tb_Username);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "f_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Username;
		private System.Windows.Forms.TextBox tb_Pass;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_NewUser;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Button btn_Forgot;
	}
}