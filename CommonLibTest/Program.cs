using System;
using RosalindCommonLib;
using System.IO;
using System.Collections.Generic;

namespace CommonLibTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string filePath = @"../../../test_data.txt";

			Dictionary<string,string> genStrDict = new FASTAParser(filePath).ParseToDictionary();

			foreach(var kvp in genStrDict) 
			{
				Console.WriteLine ("Key:" + kvp.Key + " Value:" + kvp.Value);
			}

			Console.Read();
		}
	}
}
