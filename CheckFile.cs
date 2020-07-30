using System;
using static.System.Console;

namespace FileCheck
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			var filePath = @"C:\\tmp\\file.txt"
			var exists = File.Exists(filePath);
			Writeline(exists);
			
		}

	}
}
