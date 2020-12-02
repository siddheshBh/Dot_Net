using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main( )
        {
            Employee emp = new Employee("hesh", 123456, 10);
            Console.WriteLine(emp.NAME+" "+emp.BASIC+" "+emp.DEPTNO+" "+emp.EMPNO);

            Employee emp1 = new Employee("hesh", 123456);
            Console.WriteLine(emp1.NAME + " " + emp1.BASIC + " " + emp1.DEPTNO + " " + emp1.EMPNO);

            Employee emp2 = new Employee("hes");
            Console.WriteLine(emp2.NAME + " " + emp2.BASIC + " " + emp2.DEPTNO + " " + emp2.EMPNO);

            Employee emp3 = new Employee();
            Console.WriteLine(emp3.NAME + " " + emp3.BASIC + " " + emp3.DEPTNO + " " + emp3.EMPNO);

            Console.WriteLine(emp3.EMPNO);
            Console.WriteLine(emp2.EMPNO);
            Console.WriteLine(emp1.EMPNO);
            Console.WriteLine(emp.EMPNO);
            Console.ReadLine();
        }
    }
    class Employee
    {
        //CONSTROCTOR
        
        public Employee(string name = "noname", decimal basic = 100000, short deptNo=2)
        {
            this.NAME = name;
            empNo = ++latestVlaue;
            this.BASIC = basic;
            this.DEPTNO = deptNo;
        }

        private string name;
        private  int empNo;
        private decimal basic;
        private short deptNo;
        private static int latestVlaue;
        
        public string NAME
        {
            set
            {
                if (value != " ")
                    name = value;
                else
                    Console.WriteLine("Name cannot be blank");
            }
            get
            {
                return name;
            }
        }
        public  int EMPNO
        {
            get
            {
                return empNo;
            }
        }
        public decimal BASIC
        {
            set
            {
                if (value >= 100000 && value <= 1000000)
                    basic = value;
                else
                    Console.WriteLine("out of range");
            }
            get
            {
                return basic;
            }
        }
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Department number must be greater than zero");
            }
            get
            {
                return deptNo;
            }
        }

        //METHODS

        public decimal GetNetSalary(int empNo, decimal basic)
        {
            return 12 * basic;
        }

        
    }
}
