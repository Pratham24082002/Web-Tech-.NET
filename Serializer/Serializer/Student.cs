using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    [Serializable]
    public class Student
    {
        public int roll;
        public string name;

        public Student(int roll, string name) {

            this.roll = roll;
            this.name = name;

        }


        public static void mySerializer(Student student)
        {
            FileStream fileStream = new FileStream(@"C:\Users\exam\Desktop\NEW LOL\lol.txt", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, student);
            fileStream.Close();
        }

        public static void mySerialized()
        {
            FileStream fileStream = new FileStream(@"C:\Users\exam\Desktop\NEW LOL\lol.txt", FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(fileStream);
            Console.WriteLine($"Student Roll: {s.roll}");
            Console.WriteLine($"Student: {s.name}");
            fileStream.Close();
        }

    }
}
