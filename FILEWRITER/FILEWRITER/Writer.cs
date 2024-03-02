using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILEWRITER
{
    internal class Writer
    {
        public static void DataWrite()
        {

            String PATH = "C:\\Users\\exam\\Desktop\\LOL.txt";

            string[] names = new string[] { "Abc", "XYZ ", "PQR" };


            try
            {
                using (StreamWriter streamWriter = new StreamWriter(PATH))
                {

                    Console.WriteLine("Enter the Text that you want ot write for Multiple Times");
                    String str = Console.ReadLine();
                    foreach(String name in names) { 
                        streamWriter.WriteLine($"{str}  {name}");        
                    }
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
         


        }
    
        public static void CreateDir() {

            String DIR = @"C:\Users\exam\Desktop\LOL";
            Directory.CreateDirectory(DIR);
        }
        public static void DirFiles()
        {

            String DIR = @"C:\Users\exam\Desktop\LOL";
            String[] files = Directory.GetFiles(DIR);
            Console.WriteLine($"In {DIR} Files are : ");
            foreach(String file in files)
            {
                Console.WriteLine(file);
            }
        }

        public static void DeleteDir() {

            String DIR = @"C:\Users\exam\Desktop\LOL";
            if (Directory.Exists(DIR)) { 
                Directory.Delete(DIR);

                Console.WriteLine($"{DIR} Deleted");
            }
        }

        public static void MoveDir()
        {
            String SRCDIR = @"D:\LOL";
            String DESDIR = @"D:\NEWLOL";
            try
            {
                Directory.Move(SRCDIR, DESDIR);

            }catch(Exception ex) { 
                Console.WriteLine(ex.ToString());   
            }

            Console.WriteLine($"{SRCDIR} File Move to {DESDIR}");
        }
    }
}
