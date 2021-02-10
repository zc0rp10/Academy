using System;

namespace ClassLibraryProject
{
    public static class MethodCollection
    {
        public static bool IsOdd(int number)
        {
            return (number%2 == 1);
        }

        public static int WordCount(string sentence)
        {
            string[] stringArr = sentence.Split(' ', '.', ';');
            return stringArr.Length;
        }

        public static bool IsPrimeNumber(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            if (i == number)
            {
                return true;
            }
            return false;
        }
    }
}