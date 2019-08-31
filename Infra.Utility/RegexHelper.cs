using System.Text.RegularExpressions;

namespace Infra.Utility
{
	public class RegexHelper
	{
		public static Regex RegExpNumber = new Regex("^[0-9]+$");

		public static Regex RegSn = new Regex("^OP[0-9]+$");

	}
}
