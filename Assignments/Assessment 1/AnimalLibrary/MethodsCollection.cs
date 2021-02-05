using System;
using System.Text;

namespace AnimalLibrary
{
    public class MethodsCollection
    {
        public static int AddThree(int n)
        {
            return n + 3;
        }

        public static int AddFourAndThenMultiplyByThree(int n)
        {
            return (n + 4) * 3;
        }

        public static string MaybeUppercaseAndDecorateText(string s, bool uppercase, bool decorate)
        {
            if (uppercase)
               s = s.ToUpper();

            if (decorate)
            {
                var sb = new StringBuilder(s);
                sb.Insert(0,"-:");
                sb.Append(":-");
                s = sb.ToString();
            }

            return s;
        }

        public static string TellRelationToHundred(int number)
        {
            if (number < 0)
                return $"{number} is a negative number";
            else if (number > 100)
                return $"{number} is greater than 100";
            else
                return $"Add {100-number} to {number} and you get 100";
        }
    }
}
