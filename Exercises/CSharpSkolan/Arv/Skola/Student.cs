using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Student : Person
    {
        int enrollmentYear;
        bool payedStudenUnionFee;

        public Student(string name, string telephone, int enrollmentYear, bool payedStudenUnionFee) : base(name, telephone)
        {
            this.enrollmentYear = enrollmentYear;
            this.payedStudenUnionFee = payedStudenUnionFee;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Telephone Nbr: {GetTelephone()}");

            if (payedStudenUnionFee)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student union fee has been payed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student union fee has not been payed!");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
