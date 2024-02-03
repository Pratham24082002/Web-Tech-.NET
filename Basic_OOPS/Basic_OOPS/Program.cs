namespace Basic_oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(roll:1,name:"Atharv");
            Console.WriteLine($"Student RollNo {myStudent.Roll}");
            // Setter Roll
            myStudent.Roll = 112;
            Console.WriteLine($"Student Name {myStudent.Name}");

            Console.WriteLine("\n=============================\n");

            // String Operations 2
            string s1 = "Hello";
            char[] s2 = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s3 = new string(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s1);
            Console.WriteLine(s3.ToLower());
            Console.WriteLine(s3.ToUpper());


            //Struct Arrays

            
        }
    }
}
