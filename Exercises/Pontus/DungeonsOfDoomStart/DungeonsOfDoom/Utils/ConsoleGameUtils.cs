using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DungeonsOfDoom.Utils
{
    static class ConsoleGameUtils
    {
        public static void RollingText(string text, int sleepDuration = 100)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                if (c != ' ')
                {
                    Thread.Sleep(sleepDuration);
                }
            }
        }

        public static int Chance()
        {
            return -1;
        }
    }

}