using System.Collections;
using System.Collections.Generic;

namespace Dictionary_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, ArrayList> myDict = new Dictionary<int,ArrayList>();
            // or 
            //  Dictionary<int, ArrayList> myDict

            myDict.TryAdd(1, new ArrayList() { 1,234 });
            myDict.TryAdd(3, new ArrayList() { 1,234 });
            myDict.TryAdd(4, new ArrayList() { 1,234 });
            myDict.TryAdd(6, new ArrayList() { 1,234 });
            myDict.TryAdd(8, new ArrayList() { 1,234 });
        
        
            foreach(KeyValuePair<int, ArrayList> kvp in myDict)
            {
                Console.WriteLine("Key " + kvp.Key);
                Console.WriteLine("Values ========");
                foreach(var ele in kvp.Value)
                {
                    Console.WriteLine(ele);
                }
                Console.WriteLine("============");
            }
        }
    }
}
