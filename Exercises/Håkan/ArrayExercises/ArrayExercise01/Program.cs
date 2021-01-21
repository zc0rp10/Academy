using System;

namespace ArrayExercise01
{
    static class Program
    {
        static void Main(string[] args)
        {

            // Skriv en metod med namnet ReverseArray som tar en int array
            // parameter och reverserar elementen i array:en.
            //     Före: [1][2][3][4][5]. Efter: [5][4][3][2][1].
            // Använd inte den statiska metoden Array.Reverse() för att
            // implementera metoden ReverseArray.
            int[] arr;
            arr = new int[5] { 1, 2, 3, 4, 5 };
            //ReverseArray(arr);

            // Skriv en metod med namnet PushLeft som tar en array-parameter och en int-parametrar. PushLeft ska
            // flytta elementen i array-parametern ett visst antal steg till vänster i array:en. Antalet steg anges av
            // int-parametern. Exempel: PushLeft(arr, 2). Före: [1][2][3][4][5]. Efter: [3][4][5][4][5].
            arr = new int[6] { 1, 2, 3, 4, 5, 6 };
            //PushLeft(arr, 5);

            // Skriv en metod med namnet PushRight som tar en array-parameter och en int-parametrar. PushRight ska
            // flytta elementen i array-parametern ett visst antal steg till höger i array:en. Antalet steg anges av
            // int-parametern. Exempel: PushRight(arr, 2). Före: [1][2][3][4][5]. Efter: [1][2][1][2][3].
            arr = new int[5] { 1, 2, 3, 4, 5 };
            //PushRight(arr, 2);

            // Skriv en metod med namnet SwapPairs som tar en array-parameter. SwapPairs ska byta plats på elementen
            // par för par.
            // Exempel: SwapPairs(arr). Före: [1][2][3][4][5]. Efter: [2][1][4][3][5].
            arr = new int[5] { 1, 2, 3, 4, 5 };
            //SwapPairs(arr);

            // Skriv en metod med namnet IsPalindrome som tar en char array
            // parameter och returnerar en bool. Om tecknen i char
            // array-argumentet bildar ett palindrom, d.v.s. ett ord som har
            // samma betydelse vare sig vi läser ordet framlänges eller
            // baklänges (ex. NaturrutaN, RadaR, AbadabA, etc.) så ska
            // metoden returnera true och i annat fall false. Använda inte
            // den statiska metoden Array.Reverse() för att implementera
            // metoden IsPalindrome.
            //string s = "Naturrutan";
            //if (IsPalindrome(s.ToLower().ToCharArray()))
            //    Console.WriteLine($"Ordet \"{s}\" är ett palindrom.");
            //else
            //    Console.WriteLine($"Ordet \"{s}\" är inte ett palindrom.");
            //
            // Implementera en metod med namnet InitArray1 som tar en array av typen int som parameter.
            // Tilldela var tredje element ett inkrementellt värde av 1 med start från 1.
            // Exempel: InitArray1(intArr). Före: [0][0][0][0][0][0][0][0][0]. Efter: [0][0][1][0][0][2][0][0][3].
            int[] intArr = new int[12];
            InitArr1(intArr);
            Console.ReadKey();
        }
        private static void ReverseArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[(arr.Length - 1) - i];
            }
        }

        private static void PushLeft(int[] arr, int step)
        {
            for (int i = 0; i < arr.Length - step; i++)
            {
                arr[i] = arr[i + step];
            }
        }

        private static void PushRight(int[] arr, int step)
        {
            // int-parametern. Exempel: PushRight(arr, 2). Före: [1][2][3][4][5]. Efter: [1][2][1][2][3].
            for (int i = arr.Length - 1; i - step >= 0; i--)
            {
                arr[i] = arr[i - step];
            }

        }

        private static void SwapPairs(int[] arr)
        {
            // Skriv en metod med namnet SwapPairs som tar en array-parameter. SwapPairs ska byta plats på elementen
            // par för par.
            // Exempel: SwapPairs(arr). Före: [1][2][3][4][5]. Efter: [2][1][4][3][5].

            for (int i = 0; i < arr.Length; i += 2)
            {
                if (i + 1 < arr.Length)
                {

                    int x = arr[i];
                    int y = arr[i + 1];

                    arr[i + 1] = x;
                    arr[i] = y;
                }
            }
        }

        private static bool IsPalindrome(char[] chars)
        {
            string normal = "";
            string reverse = "";

            for (int i = 0; i < chars.Length; i++)
            {
                normal += chars[i];
            }

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reverse += chars[i];
            }
            if (normal == reverse)
                return true;

            return false;

        }

        private static void InitArr1(int[] intArr)
        {
            // Implementera en metod med namnet InitArray1 som tar en array av typen int som parameter.
            // Tilldela var tredje element ett inkrementellt värde av 1 med start från 1.
            // Exempel: InitArray1(intArr). Före: [0][0][0][0][0][0][0][0][0]. Efter: [0][0][1][0][0][2][0][0][3].

            int ink = 1;
            for (int i = 0; i < intArr.Length; i++)
            {
                if ((i+1) % 3 == 0)
                    intArr[i] = +ink++;
            }

            foreach (var item in intArr)
            {
                Console.Write($"[{item}]");
            }
        }
    }
}