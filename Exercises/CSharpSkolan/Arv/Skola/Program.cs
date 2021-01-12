using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Student kalle = new Student("Kalle Persson", "070-1234567", 2005, true);
            Student linda = new Student("Linda Nilsson", "070-1234567", 2002, false);

            kalle.PrintInfo();
            linda.PrintInfo();
        }
    }
}
