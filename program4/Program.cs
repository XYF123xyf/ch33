namespace program4
{
    internal class Program
    {
        class Mymath
        {
            public double Pi = Math.PI;
            public void Perimeter(double r)//周长
            {
                Console.WriteLine(2 * r * Pi);
            }
            public void Area(double r)//面积
            {
                Console.WriteLine(r * r * Pi);
            }
        }
        static void Main(string[] args)
        {
            Mymath circle1 = new Mymath(); //创建对象
            Console.Write("请输入圆的半径:");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("圆的周长为：");
            circle1.Perimeter(r1);
            Console.WriteLine();
            Console.Write("圆的面积为：");
            circle1.Area(r1);
            Console.WriteLine();
        }
    }
}