using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertible
{
	public class ProgramHelper : ProgramConverter, ICodeChecker
	{
		public bool CodeCheckSyntax ( string checkString, string language )
		{
			return language == "CSharp" || language == "VB";
		}

		public override string ConvertToCSharp ( string code )
		{
			return $@"ProgramHelper convert code ""{code}"" converted to CSharp";
		}

		public override string ConvertToVB ( string code )
		{
			return $@"ProgramHelper convert code ""{code}"" converted to VB";
		}
	}
}
