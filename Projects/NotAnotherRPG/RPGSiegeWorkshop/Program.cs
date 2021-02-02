using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPGSiegeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //RepeatCharacter("a", 95);
            //CountCharacter("");
            ASCIItoArray("value");
            //Build2D(95);
        }

        private static void Build2D(int x)
        {

            var sb = new StringBuilder();
            for (int i = 0; i < x; i++)
            {
                sb.Append(new char[] { '"', ' ', '"', ',' });
            }
            Console.WriteLine(sb.ToString());
        }

        private static void ASCIItoArray(string value)
        {
            string input = @"c:\temp\NotAnotherRPG\test.txt";
            string output = @"c:\temp\NotAnotherRPG\" + value + ".txt";
            string[] readText = File.ReadAllLines(input); // Reads file one line at a time. Saves each line as a seperate string in an array of strings.
            var stringList = new List<string>();

            for (int i = 0; i < readText.Length; i++) // Loops the full string
            {
                var sb = new StringBuilder();
                sb.Append('{');

                for (int j = 0; j < readText[i].Length; j++) // Loops every char in each string
                {

                    if (j == readText[i].Length - 1)
                        sb.Append(new char[] { '"', readText[i][j], '"' });
                    else if (readText[i][j] == '\\')
                        sb.Append(new char[] { '@', '"', readText[i][j], '"', ',' });
                    else
                        sb.Append(new char[] { '"', readText[i][j], '"', ',' });
                }
                sb.Append("},");
                stringList.Add(sb.ToString()); // Adds manipulated string to list.
            }
            File.WriteAllLines(output, stringList);
        }

        private static void CountCharacter(string value)
        {
            int count = 0;
            foreach (var item in value)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        static void RepeatCharacter(string str, int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write(str);
            }
        }

    }
}
