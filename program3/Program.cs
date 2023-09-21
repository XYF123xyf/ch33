namespace program3
{
    internal class Program
    {
        class Mymath
        {
            public void jia(int a,int b)
            {
                Console.WriteLine(a+b);
            }
            public void jian(int a, int b)
            {
                Console.WriteLine(a-b);
            }
            public void cheng(int a, int b)
            {
                Console.WriteLine(a*b);
            }
            public void chu(int a, int b)
            {
                Console.WriteLine(a/b*1.0);
            }
        }
        static void Main(string[] args)
        {
            Mymath circle1 = new Mymath();
            Console.WriteLine("Hello, World!");
            Console.Write("两个整数:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("加");
            circle1.jia(a,b);
            Console.WriteLine();

            Console.Write("减");
            circle1.jian(a, b);
            Console.WriteLine();

            Console.Write("乘");
            circle1.cheng(a, b);
            Console.WriteLine();

            Console.Write("除");
            circle1.chu(a, b);
            Console.WriteLine();
        }
    }
}