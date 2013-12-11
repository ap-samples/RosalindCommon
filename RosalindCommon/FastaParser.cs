using System;
using System.IO;
using System.Collections.Generic;

namespace RosalindCommonLib
{
	public class FASTAParser
	{
		private string FileText;

		public FASTAParser(string filePath)
		{
			this.FileText = File.ReadAllText(filePath);
		}

		/// <summary>
		/// Key - label, value - genetic string
		/// </summary>
		/// <returns>The to dictionary.</returns>
		public Dictionary<string,string> ParseToDictionary()
		{
			var ret = new Dictionary<string,string>();

			string[] labeledGenStrings = FileText.Split('>');
			foreach(string labeledGenString in labeledGenStrings) 
			{
				if(String.IsNullOrEmpty(labeledGenString)) //File always starts with '>', so 1st string is empty
					continue;
				int firstEOSidx = labeledGenString.IndexOf("\n");
				string genStr = labeledGenString.Substring(firstEOSidx + 1);
				string genLabel = labeledGenString.Substring(0, firstEOSidx);
				genStr = genStr.Replace("\n", "");

				ret.Add(genLabel, genStr);
			}

			return ret;
		}
	}
}

