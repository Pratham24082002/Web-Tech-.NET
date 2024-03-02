namespace MultilevelInh
{
    public abstract class A {
        protected int a_mem = 10;

        public A(int x)
        {
            this.a_mem = x;
            Console.WriteLine("A Initialized");
        }

        protected abstract void AABS();
    }

    public class B : A {
        protected int b_mem = 20;
        public B(int x , int y) : base(x) 
        {
            this.b_mem = y;
            Console.WriteLine("B Initialized");
        }

        protected override void AABS()
        {
            Console.WriteLine("Class A Abs Method from B");
        }
    }

    public class C : A{
        protected int c_mem = 30;
        public C(int x , int y) : base(x)
        {
            this.c_mem = y;
            Console.WriteLine("C Initialized");
        }

        protected override void AABS()
        {
            Console.WriteLine("Class A Abs Method from C");
        }
    }

    public class D : B {
        protected int d_mem = 30;
        public D(int x, int y,int z) : base(x,y) {
            this.d_mem = z;
            Console.WriteLine("D Initialized");
        }


        public void show()
        {
            Console.WriteLine(this.a_mem);
            Console.WriteLine(this.b_mem);
            Console.WriteLine(this.d_mem);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            D d1 = new D(1,2,4);
            d1.show();
        }
    }
}
