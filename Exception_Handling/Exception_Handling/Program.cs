namespace Exception_Handling
{
    internal class Program
    {
        public static void division()
        {
            int a = 10; int b = 5, c = 5;
            float x = 0;
            try
            {
                x = a / (b - c);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Cannot Divide by Zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Cannot Divide by Zero Caught Inside Method");
            }
            finally
            {
                Console.WriteLine(x.ToString());
                Console.WriteLine("Computation Done Caught Inside Method");
            }
        }
        
        static void Main(string[] args)
        {
          int a = 10; int b = 5 , c = 1;
            float x = 0;
            try
            {
                x =  a / (b - c);
                division();
            }
            catch(ArithmeticException ex) 
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Cannot Divide by Zero  Caught by Main");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Cannot Divide by Zero Caught by Main");
            }
            finally
            {
                Console.WriteLine(x.ToString());    
                Console.WriteLine("Computation Done");
            }
        }
    }
}
