using System;
using static program5.Program;

namespace program5
{
    internal class Program
    {

        public class Rect
        {
            protected double width;
            protected double height;
            Rect(double width, double height)
            {
                this.height = height;
                this.width = width;
            }
            Rect()
            {
                this.height = 10;
                this.width = 10;
            }
            double area()
            {
                return height * width;
            }
            double perimeter()
            {
                return 2 * height + 2 * width;
            }
        }

        public class PlainRect extends Rect
        {

    double startX;//左上角坐标
        double startY;
        PlainRect()
        {
            startX = 0;
            startY = 0;
            width = 0;
            height = 0;
        }
        PlainRect(double startX, double startY, double width, double height)
        {
            this.height = height;
            this.width = width;
            this.startX = startX;
            this.startY = startY;
        }
        boolean isInside(double x, double y)
        {
            if (x >= startX && x <= (startX + width) && y < startX && y >= (startY - height))
            {
                System.out.println("该点在矩形中！");
                return true;
            }
            else
            {
                System.out.println("该点不在矩形中！");
                return false;
            }
        }
    }
    static void Main(string[] args)
        

public class PlainRecttest
    {
        public static void main(String[] args)
        {
            PlainRect P = new PlainRect(10, 10, 10, 20);
            System.out.println("矩形的面积为：" + P.area() + "矩形的周长为：" + P.perimeter());
            P.isInside(25.5, 13);
        }
    }
}
    }
}