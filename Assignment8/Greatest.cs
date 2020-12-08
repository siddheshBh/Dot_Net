using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterSmallerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            GrtrSmalr gs = new GrtrSmalr(no1, no2);

            
            //Func< int, int, bool> res = (a, b) => a > b ? true : false;
            //Console.WriteLine(res(no1, no2));

            Predicate<GrtrSmalr> cmp = (GrtrSmalr ga) =>  (ga.No1 > ga.No2 ? true : false) ;
            Console.WriteLine(cmp(gs));

        }
    }
    class GrtrSmalr
    {
        public GrtrSmalr(int no1, int no2)
        {
            this.No1 = no1;
            this.No2 = no2;
        }
        private int no1;
        private int no2;

        public int No1
        {
            set
            {
                no1 = value;
            }
            get
            {
                return no1;
            }
        }
        public int No2
        {
            set
            {
                no2 = value;
            }
            get
            {
                return no2;
            }
        }
    }
}
