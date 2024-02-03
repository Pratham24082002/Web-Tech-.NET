
namespace Inheritance
{
    public class myShape
    {
        public myShape() { 
            Console.WriteLine(this.ToString()); 
        } 

        public float Area(float r) {
            float res;
            if (!(r < 0))
            {
                res = (float)((float) Math.PI * Math.Pow(r, 2));
                return res;
            }
            return 0.0f;
        }

        public float Area(float l, float b)
        {
            return l * b;
        }

        public float Area(int l, int b)
        {
            return 0.5f *  l * b;
        }
    }


    internal class Mafs
    {
        public int Add(int a , int b) { 
            return a + b;
        }
        public int Add(int a , int b, int c) {
            return a + b + c; 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mafs myMafsObject = new Mafs();
            int area_1 = myMafsObject.Add(1,2);
            int area_2 = myMafsObject.Add(1,2,3);
            Console.WriteLine(area_1);
            Console.WriteLine(area_2);


            myShape myShape = new myShape();
            float area = myShape.Area(1.2f);
            Console.WriteLine(area);

            area = myShape.Area(12);
            Console.WriteLine(area);

            area = myShape.Area(12.0f, 123.2f);
            Console.WriteLine(area);
        }   
    }
}
