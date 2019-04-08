using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertible
{
	public class ProgramConverter : IConvertible
	{
		public virtual string ConvertToCSharp ( string code )
		{
			return $@"ProgramConverter convert code ""{code}"" converted to CSharp";
		}

		public virtual string ConvertToVB ( string code )
		{
			return $@"ProgramConverter convert code ""{code}"" converted to VB";
		}
	}
}
