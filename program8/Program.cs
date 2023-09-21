using static program8.Program;

namespace program8
{
    internal class Program
    {
        public interface InterfaceA
        {
            void printCapitalLetter();
        }

        public interface InterfaceB
        {
            void printLowercaseLetter();
        }
        public class Print implements InterfaceA, InterfaceB{



    public void printLowercaseLetter()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                System.out.print(i + " ");
            }
            System.out.println();
        }


    public void printCapitalLetter()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                System.out.print(i + " ");
            }
            System.out.println();
        }

    }
    public class InterfaceDemo3
    {

        public static void main(String[] args)
        {
            InterfaceA a = new Print();
            a.printCapitalLetter();

            InterfaceB b = new Print();
            b.printLowercaseLetter();

        }
    }
    static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}