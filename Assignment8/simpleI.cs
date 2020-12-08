using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P: ");
            decimal p = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter N: ");
            decimal r = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter R: ");
            decimal n = Convert.ToDecimal(Console.ReadLine());

            Func<decimal, decimal, decimal, decimal> simpleI = (a, b, c) =>  ((a * b * c) / 100);
            Console.WriteLine("Simple Interset is: "+simpleI (p, r, n));

            Console.ReadLine();
        }
    }
}
