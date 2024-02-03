using System.Collections;

namespace Dynaimic_Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Normal Array
            string[] myArr = new string[] { "Lol","LOl1","Lol2","Lol34" };

            //ArrayList
            var myArr1 = new ArrayList() { 1,"Super Saiyan" ,null , true , 12.2323f ,'a', 'A' };


            Console.WriteLine("Array\n");
            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }


            Console.WriteLine("=========================================================\n");
            

            Console.WriteLine("ArrayList\n");
            foreach(var ele in myArr1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
