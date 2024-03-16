namespace RandomWrites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Quick Fox Jumps over the Dawg";
            string fileName = @"D:\Greet.txt";

            //Open the file
            TextWriter writer = new StreamWriter(fileName);   
            writer.WriteLine(msg);
            writer.Close();


            TextReader reader = new StreamReader(fileName);
            Console.WriteLine("Before " + reader.ReadLine());
            reader.Close();

            //Using Replcae
            string str = File.ReadAllText(fileName);
            str = str.Replace("Fox","Brown Fox");
            str = str.Replace("Dawg", "Lazy Dawg");
            File.WriteAllText(fileName, str);

            TextReader readerAfter = new StreamReader(fileName);
            Console.WriteLine("After" + readerAfter.ReadLine());
            readerAfter.Close();
        }
    }
}
