using System;
using System.IO;

namespace FileManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\zcorp\Desktop\MyFile.txt";
            string textString = $"Line 1{Environment.NewLine}Line 2\nLine 3";

            File.WriteAllText(filePath, textString);

            //As a single string
            Console.WriteLine(File.ReadAllText(filePath));

            //As a string array, each line is one array entry.
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines.Length);
        }
    }
}
