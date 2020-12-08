using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Predicate<int> evnOdd = a =>  a % 2 == 0 ? true : false;

            Console.WriteLine(evnOdd(no1));
        }

    }
}
