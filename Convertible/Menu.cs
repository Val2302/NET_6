
using static System.Console;

namespace Convertible
{
	public class Menu
	{
		public void Show ( )
		{
			WriteLine( "Program Convertible: \n" );
			var programConverters = CreateProgramConverters( );
			CheckExtendedIConvertable( programConverters );
			ReadKey( );
		}
		
		private ProgramConverter[] CreateProgramConverters(  ) {
			return new ProgramConverter[ ] {
				new ProgramConverter(),
				new ProgramHelper()
			};
		}

		private void CheckExtendedIConvertable ( ProgramConverter[] programConverters )
		{
			foreach ( var item in programConverters )
			{
				if ( item is ICodeChecker )
				{
					WriteLine( $"Item {item} inherits ICodeChecker" );
				}
				else
				{
					WriteLine( $"Item {item} not inherits ICodeChecker" );
				}
			}
		}
	}
}
