namespace StreamDecorator
{
	partial class PasswordForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.groupBoxPassword = new System.Windows.Forms.GroupBox();
			this.labelIncorectPassword = new System.Windows.Forms.Label();
			this.groupBoxPassword.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(33, 89);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "&OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(146, 89);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(16, 19);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '•';
			this.textBoxPassword.Size = new System.Drawing.Size(198, 20);
			this.textBoxPassword.TabIndex = 0;
			// 
			// groupBoxPassword
			// 
			this.groupBoxPassword.Controls.Add(this.labelIncorectPassword);
			this.groupBoxPassword.Controls.Add(this.textBoxPassword);
			this.groupBoxPassword.Location = new System.Drawing.Point(12, 12);
			this.groupBoxPassword.Name = "groupBoxPassword";
			this.groupBoxPassword.Size = new System.Drawing.Size(231, 64);
			this.groupBoxPassword.TabIndex = 0;
			this.groupBoxPassword.TabStop = false;
			this.groupBoxPassword.Text = "Password";
			// 
			// labelIncorectPassword
			// 
			this.labelIncorectPassword.AutoSize = true;
			this.labelIncorectPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.labelIncorectPassword.Location = new System.Drawing.Point(67, 42);
			this.labelIncorectPassword.Name = "labelIncorectPassword";
			this.labelIncorectPassword.Size = new System.Drawing.Size(97, 13);
			this.labelIncorectPassword.TabIndex = 1;
			this.labelIncorectPassword.Text = "Incorrect password";
			this.labelIncorectPassword.Visible = false;
			// 
			// PasswordForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(255, 124);
			this.ControlBox = false;
			this.Controls.Add(this.groupBoxPassword);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "PasswordForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter password";
			this.groupBoxPassword.ResumeLayout(false);
			this.groupBoxPassword.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.GroupBox groupBoxPassword;
		private System.Windows.Forms.Label labelIncorectPassword;
	}
}