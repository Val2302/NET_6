using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertible
{
	public interface ICodeChecker
	{
		bool CodeCheckSyntax ( string checkString, string language );
	}
}
