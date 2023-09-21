using program6;
using System.Net.NetworkInformation;

namespace program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        abstract class Animal
                        {
                            public abstract void voice();
                        }
                        class Pig implements Animal
                        {
                    public void voice()
                        {
                            System.out.println("henghengheng");
                        }
                    }
                    class Dog implements Animal
                    {
                    public void voice()
                    {
                        System.out.println("wangwangwang");
                    }
                }
                class Cat implements Animal
                {
                    public void voice()
                {
                    System.out.println("喵喵喵");
                }
                }
                class Store
                {
                    public Animal getInstance(String name)
                    {
                        if ("Pig".equals(name))
                        {
                            return new Pig();
                        }
                        else if ("Dog".equals(name))
                        {
                            return new Dog();
                        }
                        else
                        {
                            return new Cat();
                        }
                    }
                }

            Console.WriteLine("Hello, World!");
        }
    }
}