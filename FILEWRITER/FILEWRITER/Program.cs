using System.IO;

namespace FILEWRITER
{
    internal class Program
    {
        public static void DataWrite() {

            String PATH = "C:\\Users\\exam\\Desktop\\LOL.txt";

            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(PATH);

                Console.WriteLine("Enter the Text that you want ot write ");
                String str = Console.ReadLine();

                streamWriter.WriteLine(str);
                streamWriter.Flush();       
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                streamWriter.Close();
            }


        }


        public static void DataRead()
        {
            String PATH = @"C:\Users\exam\Desktop\LOL\LOL.txt";
            try
            {
                StreamReader streamReader = null;
                String line = null;
                streamReader = new StreamReader(PATH);
                

                while((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);    
                }

            }catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }

        static void Main(string[] args)
        {
            //DataWrite();
            
            //Writer.DataWrite();
            Writer.CreateDir();
            Writer.DirFiles();
            DataRead();
            Writer.MoveDir();
           
        }
    }
}
