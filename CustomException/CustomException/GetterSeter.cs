using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class Human
    {
        private string _name;
        private int _age;

        public Human(String Name, int Age)
        {
            this._name = Name;
            this._age = Age;
        }

        public void eat()
        {
            Console.WriteLine(this._name + " Eat");
        }

        public void sleep()
        {
            Console.WriteLine(this._name + " Sleep");
        }

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { this._age = value; }
        }
    }

    internal class GetterSeter
    {
        public static void Main(string[] args)
        {
            Human human1 = new Human("Atharv", 22);
        }

    }
}
