using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //public Manager(string name, decimal deptNo, string designation, decimal basic) 
            Manager m = new Manager("jit", 04, "man", 2500);
            Console.WriteLine(m.Name+" "+m.DeptNo+ " " +m.Designation+ " " +m.Basic);

            //GeneralManager(string name, short deptNo, decimal basic, string perks) : base(name, deptNo, basic)
            GeneralManager gm = new GeneralManager("jit", 04, 25000, "allow");
            Console.WriteLine(gm.Name + " " + gm.DeptNo + " " + gm.Perks + " " + gm.Basic);
            //Ceo(string name = "unnamed", short deptNo = 5, decimal basic = 100000)
            Ceo c = new Ceo();
            Console.WriteLine(c.Name + " " + c.DeptNo + " "  + " " + c.Basic);
        }
    }
    public abstract class Employee
    {
        public Employee(string name, short deptNo, decimal basic)
        {
            this.Name = name;
            this.DeptNo = deptNo;
            empNo = ++count;
            this.Basic = basic;
        }
        private string name;
        private static int count;
        private int empNo;
        private short deptNo;
       protected decimal basic;
        public string Name
        {
            set
            {
                if (value != " ")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be blank");
                }
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Department no must be grater than zero");
                }
            }
            get
            {
                return deptNo;
            }
        }

        public abstract decimal Basic
        {
            get;
            set;
        }
        public abstract decimal CalcNetSalary();
    }
    public class Manager : Employee
    {
        
        private string designation;
        public Manager(string name = "unnamed", short deptNo=5, string designation="unknwn", decimal basic=1000) : base (name, deptNo, basic)
        {
            
            this.Designation = designation;
            
        }
        public string Designation
        {
            set
            {
                if (value != " ")
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Designation cannot be blank");
                }
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic
        {
            set
            {
                if(value >= 1000 && value <= 10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 12;
        }
    }
    public class GeneralManager : Employee
    {
        public GeneralManager(string name = "unnamed", short deptNo = 5, decimal basic=10000, string perks="unknown") : base(name, deptNo, basic)
        {
            this.Perks = perks;
        }
        private string perks;
        
        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }
        public override decimal Basic
        {
            set
            {
                if (value >= 10000 && value <= 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 12;
        }
    }
    public class Ceo : Employee
    {
    
        public Ceo(string name = "unnamed", short deptNo = 5, decimal basic= 100000) : base(name,deptNo,basic)
        {
            //this.Basic = basic;
        }
        public override decimal Basic
        {
            set
            {
                if (value >= 100000 && value <= 1000000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            get
            {
                return basic;
            }
        }

        public sealed override decimal CalcNetSalary()
        {
            return Basic*12;
        }
    }

}
