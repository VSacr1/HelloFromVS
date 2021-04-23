using System;
using System.IO;
namespace DataFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Dev\test2.txt.bac";
            //var doesFileExist = File.Exists(filePath);
            //Console.WriteLine($"{filePath} exists?: {doesFileExist}"); ;
            File.Delete(filePath);
        }
    }
}
