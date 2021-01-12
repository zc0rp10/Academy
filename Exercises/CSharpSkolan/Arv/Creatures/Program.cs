using System;

namespace Creatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Alexander", "Sword");
            Dragon dragon = new Dragon("Urthemiel", "Black");

            knight.Attack();
            dragon.Attack();
        }
    }
}
