using System.Collections;
using System.Collections.Generic;

namespace Struct
{
    internal class Program
    {
        public struct Student
        {
            public int Id;
            public string Name,Course,DOB;
        }

        public static void AddStudent(ref ArrayList arrayList,Student stu)
        {
            arrayList.Add(stu);
        }

        static void Main(string[] args)
        {
            int count;
            ArrayList StuList = new ArrayList();

            Console.WriteLine("Num of Student");
            count = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < count; i++) {
            
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string course = Console.ReadLine();
                string dob = Console.ReadLine();

                AddStudent(ref StuList, new Student() { Id = id, Course = course, Name = name, DOB = dob });
            }

            foreach (Student stu in StuList)
            {
                Console.WriteLine($"Student ID {stu.Id}");
                Console.WriteLine($"Student Course {stu.Course}");
                Console.WriteLine($"Student Name {stu.Name}");
                Console.WriteLine($"Student DOB {stu.DOB}");
            }
        }
    }
}
