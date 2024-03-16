using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student.mySerializer(new Student(12, "Shubavrat"));
            Student.mySerialized();

        }



    }
}
