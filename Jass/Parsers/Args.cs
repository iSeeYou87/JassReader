using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Args : IParser
	{
		public const string Pattern = @".*";

		private string args;

		public void Parse(string text)
		{
			args = text.Trim();
		}
		
		public override string ToString()
		{
			return args;
		}
	}
}