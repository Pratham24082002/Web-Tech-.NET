namespace CustomException
{
    public class InvalidMarksException : Exception
    {
        private string msg;

        public InvalidMarksException(String msg) : base(msg) {
            this.msg = msg;
        }

        public string showMsg()
        {
            return this.msg;
        }
    }


    internal class Program
    {

        public static void validate(int marks) { 
         if (marks > 100)
            {
                throw new InvalidMarksException("Marks Cannot be greater than 100");
            }
        }
        
        static void Main(string[] args)
        {
            int marks = 199;

            Voters kamlesh = new Voters(8,999999);
            Voters rajesh = new Voters(22,999999);

            try
            {
               // validate(marks);
                Console.WriteLine(marks);

                kamlesh.Validate();
                rajesh.Validate();

            }catch (InvalidMarksException e) { 

                Console.WriteLine(e.ToString() + "\n");    
                Console.WriteLine(e.StackTrace + "\n");    
                Console.WriteLine(e.Message + "\n");    

                Console.WriteLine(e.showMsg() + "\n");    
            }
            catch(VoterException ex)
            {
                Console.WriteLine(ex.ToString() + "\n");
            }
            finally {

                Console.WriteLine("Done");

            }
        }
    }
}
