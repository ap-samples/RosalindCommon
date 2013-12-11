using System;
using System.IO;

namespace RosalindCommonLib
{
	public class FileHelper
	{
		public FileHelper()
		{
		}

		public void WriteContentToFile(string content, string filePath)
		{
			using(StreamWriter sw = new StreamWriter(filePath)) 
			{
				sw.Write(content);
			}
		}
	}
}

