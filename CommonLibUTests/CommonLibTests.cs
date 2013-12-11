using NUnit.Framework;
using System;
using System.IO;
using System.Collections.Generic;

namespace CommonLibTests
{
	[TestFixture()]
	public class CommonLibTests
	{
		[Test()]
		public void TestLongGeneticString()
		{
			string longGenStrFilePath = "../../../test_data.txt";

			RosalindCommonLib.FASTAParser fp = new RosalindCommonLib.FASTAParser(longGenStrFilePath);
			Dictionary<string,string> dict = fp.ParseToDictionary();

			Assert.IsTrue(dict.Count > 0);
			IEnumerator<KeyValuePair<string,string>> dictEnum = dict.GetEnumerator();
			dictEnum.MoveNext();
			KeyValuePair<string,string> firstDictElem = dictEnum.Current;

			Assert.AreEqual("FASTA_Test", firstDictElem.Key);
		}
	}
}

