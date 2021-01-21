using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethodsProject
{
    class MethodBench
    {

        public void FirstMethod()
        {
            Console.WriteLine("Marry Methods");
        }

        public void SecondMethod(string value)
        {
            Console.WriteLine(value);
        }

        public void ThirdMethod(string str, bool value)
        {
            string input;

            if (value == true)
                input = str.ToUpper();
            else
                input = str.ToLower();

            SecondMethod(input);
        }

        public bool FourthMethod()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            bool isValid = false;

            do
            {
                if (cki.Key == ConsoleKey.S)
                {
                    isValid = true;
                    return true;
                }
                else if (cki.Key == ConsoleKey.W)
                {
                    isValid = true;
                    return false;
                }
                else
                    isValid = false;

            } while (!isValid);
            return false;
        }

        public Tuple<string, bool> SixthMethod()
        {
            string Name = Console.ReadLine();
            bool LengthyName = (Name.Length > 5) ? true : false;

            var tuple = new Tuple<string, bool>(Name, LengthyName);
            
            return tuple;
        }
    }
}
