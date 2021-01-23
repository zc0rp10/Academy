using System;
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
            ASCIItoArray();
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

        private static void ASCIItoArray()
        {
            string[,] array2D = new string[3, 2] {
                { " ", "" },
                { " ", "" },
                { " ", "" }
            };

            string output = @"c:\temp\NotAnoutherRPG\asciiOUT.txt";

            string input = @"c:\temp\NotAnoutherRPG\asciiIN.txt";
            string[] readText = File.ReadAllLines(input);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
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
