using System;
using System.IO;
using System.Windows.Forms;

namespace StreamDecorator
{
	public partial class MainForm : Form
	{
		public MainForm ( )
		{
			InitializeComponent( );
		}

		private void ButtonOpenFile_Click ( object sender, EventArgs e )
		{
			openFileDialog.InitialDirectory = Application.StartupPath;

			if ( openFileDialog.ShowDialog( ) == DialogResult.OK )
			{
				ReadFile( openFileDialog.FileName );
			}
		}

		private void ReadFile ( string fileName )
		{
			var password = "sizam";
			var key = Coder.PasswordToKey( password );
			var dialogResult = new PasswordForm( key ).ShowDialog( );

			if ( dialogResult == DialogResult.OK )
			{
				var streamReader = new StreamReaderDecorator( fileName, fileReadProgress );
				var readStrings = streamReader.ReadLines( );
			}
		}
	}
}
