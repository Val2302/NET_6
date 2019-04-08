using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDecorator
{
	public partial class PasswordForm : Form
	{
		private int key;

		public PasswordForm ( int key )
		{
			InitializeComponent( );

			this.key = key;
		}

		private void ButtonOk_Click ( object sender, EventArgs e )
		{
			int key = Coder.PasswordToKey( textBoxPassword.Text );

			if ( this.key == key )
			{
				DialogResult = DialogResult.OK;
				Close( );
			} 
			else
			{
				textBoxPassword.Text = string.Empty;
				labelIncorectPassword.Show( );
			}
		}

		private void ButtonCancel_Click ( object sender, EventArgs e )
		{
			Close( );
		}
	}
}
