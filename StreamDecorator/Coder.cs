using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDecorator
{
	static public class Coder
	{
		static public int PasswordToKey( string password )
		{
			return password.GetHashCode( );
		}
	}
}
