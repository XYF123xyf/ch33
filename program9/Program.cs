using System.Drawing;

namespace program9
{
    internal class Program
    {

        interface A
        {               // 定义第1个接口
            double PI = 3.14;
            double getArea();
        }
        interface B
        {               // 定义第2个接口
            void setColor(String c);
        }
        interface C extendsA, B { // 接口的多重继承
    void getVolume();
    }
    class Cylinderimplements C {       // 以第3个接口实现类
    double radius;
    double height;
    String color;
    public Cylinder(double r, double h)
    {
        radius = r;
        height = h;
    }
    public double getArea()
    {       // 实现第1个接口的方法
        return PI * radius * radius;
    }
    public void setColor(String c)
    { // 实现第2个接口的方法
        color = c;
        System.out.println("形状的颜色：" + color);
    }
    public void getVolume()
    {       // 实现第3个接口的方法
        System.out.println("圆柱体的体积：" + getArea() * height);
    }
}
class Test
{
    public static void main(String args[])
    {
        Cylinder One = new Cylinder(3.0, 5);
        One.setColor("红色");
        One.getVolume();
    }
}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}