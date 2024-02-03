namespace MethodOverriding
{

    public class Employee
    {
        public float salary = 40000.00f;
        public Employee() { Console.WriteLine("Employee Intailiez");  }

        

    }

    public class Programmer : Employee {

        public float bonus = 10000.00f;
        public Programmer() {

            Console.WriteLine("Programmer Intailized");  
        }


    }

    public class Tester : Employee
    {

        public float TA = 3000.00f;
        public Tester()
        {

            Console.WriteLine("Tester Intailized");
        }
    }

    public class Developer : Employee
    {

        public int holidays = 30;
        public Developer()
        {

            Console.WriteLine("Developer Intailized");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // DDM Dynamic Dispatch Method Resolution
            Employee myEmp = new Developer();
            Console.WriteLine(myEmp.salary);

            Console.WriteLine("-------------------------------------------------------------");
            Programmer programmer = new Programmer();
            Console.WriteLine("Salary : " + programmer.salary);
            Console.WriteLine("Bonus : " + programmer.bonus);

            Console.WriteLine("-------------------------------------------------------------");
            Tester tester = new Tester();
            Console.WriteLine("Salary :" + tester.salary);
            Console.WriteLine("Testing Allowance : " + tester.TA);

            Console.WriteLine("------------------------------------------------------------");
            Developer developer = new Developer();  
            Console.WriteLine("Salary : " + developer.salary);
            Console.WriteLine("Holidays : " + developer.holidays);

        }
    }
}
