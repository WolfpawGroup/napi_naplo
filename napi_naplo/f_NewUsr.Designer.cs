namespace napi_naplo
{
	partial class f_NewUsr
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
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.tb_Pass = new System.Windows.Forms.TextBox();
			this.tb_Email = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Create = new System.Windows.Forms.Button();
			this.lbl_Result = new System.Windows.Forms.Label();
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
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email: ";
			// 
			// tb_Username
			// 
			this.tb_Username.Location = new System.Drawing.Point(79, 6);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(188, 20);
			this.tb_Username.TabIndex = 3;
			// 
			// tb_Pass
			// 
			this.tb_Pass.Location = new System.Drawing.Point(79, 32);
			this.tb_Pass.Name = "tb_Pass";
			this.tb_Pass.Size = new System.Drawing.Size(188, 20);
			this.tb_Pass.TabIndex = 4;
			// 
			// tb_Email
			// 
			this.tb_Email.Location = new System.Drawing.Point(79, 58);
			this.tb_Email.Name = "tb_Email";
			this.tb_Email.Size = new System.Drawing.Size(188, 20);
			this.tb_Email.TabIndex = 5;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(15, 106);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Create
			// 
			this.btn_Create.Location = new System.Drawing.Point(192, 106);
			this.btn_Create.Name = "btn_Create";
			this.btn_Create.Size = new System.Drawing.Size(75, 23);
			this.btn_Create.TabIndex = 7;
			this.btn_Create.Text = "Create";
			this.btn_Create.UseVisualStyleBackColor = true;
			this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
			// 
			// lbl_Result
			// 
			this.lbl_Result.AutoSize = true;
			this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_Result.ForeColor = System.Drawing.Color.DarkRed;
			this.lbl_Result.Location = new System.Drawing.Point(18, 87);
			this.lbl_Result.Name = "lbl_Result";
			this.lbl_Result.Size = new System.Drawing.Size(0, 16);
			this.lbl_Result.TabIndex = 8;
			// 
			// f_NewUsr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 141);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_Result);
			this.Controls.Add(this.btn_Create);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.tb_Email);
			this.Controls.Add(this.tb_Pass);
			this.Controls.Add(this.tb_Username);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "f_NewUsr";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Username;
		private System.Windows.Forms.TextBox tb_Pass;
		private System.Windows.Forms.TextBox tb_Email;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Create;
		private System.Windows.Forms.Label lbl_Result;
	}
}