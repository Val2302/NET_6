using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDecorator
{
	public class StreamReaderDecorator
	{
		private StreamReader streamReader;
		private ProgressBar progressBar;

		public StreamReaderDecorator ( string path, ProgressBar progressBar )
		{
			this.progressBar = progressBar;
			streamReader = new StreamReader( path );
			var fileAttributes = File.GetAttributes( path );
		}

		public List<string> ReadLines ( )
		{
			var firstReadLine = streamReader.ReadLine( );
			var isCasted = int.TryParse( firstReadLine, out var countLines );

			if ( !isCasted )
			{
				throw new InvalidCastException( "First read line not casted" );
			}

			progressBar.Maximum = countLines;
			progressBar.Value = 0;

			var readLines = new List<string>( );
			var line = string.Empty;

			for ( int i = 0; i < countLines && ( line = streamReader.ReadLine( ) ) != null; i++ )
			{
				readLines.Add( line );
				progressBar.Value = i + 1;
			}

			progressBar.Value++;

			return readLines;
		}
	}
}
