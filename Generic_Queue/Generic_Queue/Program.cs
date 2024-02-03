namespace Generic_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            Queue<string> myQueue = new Queue<string>();

            Console.WriteLine("Enter Number of Students");
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(" Student Name " + i);
                myQueue.Enqueue(item: Convert.ToString(Console.ReadLine()));
            }

            topStu(myQueue);
            myQueue.Dequeue();

            topStu(myQueue);
            myQueue.Dequeue();

        }


        static void topStu(Queue<string> myQueue)
        {

            Console.WriteLine("After Dequeue" + "Count "+ myQueue.Count +" "+myQueue.Peek());
        }
    }
}
