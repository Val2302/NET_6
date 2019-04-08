namespace StreamDecorator
{
	partial class MainForm
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
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.fileReadProgress = new System.Windows.Forms.ProgressBar();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(97, 23);
			this.buttonOpenFile.TabIndex = 0;
			this.buttonOpenFile.Text = "Open file";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
			// 
			// fileReadProgress
			// 
			this.fileReadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileReadProgress.Location = new System.Drawing.Point(12, 50);
			this.fileReadProgress.Name = "fileReadProgress";
			this.fileReadProgress.Size = new System.Drawing.Size(280, 25);
			this.fileReadProgress.Step = 1;
			this.fileReadProgress.TabIndex = 1;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "file";
			this.openFileDialog.Title = "Open file";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 87);
			this.Controls.Add(this.fileReadProgress);
			this.Controls.Add(this.buttonOpenFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream decorator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		public System.Windows.Forms.ProgressBar fileReadProgress;
	}
}

