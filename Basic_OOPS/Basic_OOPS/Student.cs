using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_oops
{
    internal class Student
    {
        private int roll;
        private string name;


        public Student(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }

        //Getters & Setters
        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        public string Name { 
            get { return name; }
            set { name = value; }
        }
 
    }
}
