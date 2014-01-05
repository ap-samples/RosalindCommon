using System;
using System.IO;


namespace RosalindCommonLib
{
	public static class FileHelper
	{
		public static readonly string HOME_FOLDER = 
			Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

		public static void WriteContentToFile(string content, string filePath)
		{
			using(StreamWriter sw = new StreamWriter(filePath)) 
			{
				sw.Write(content);
			}
		}
	}
}

