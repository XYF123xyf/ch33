using System.Security.Claims;

namespace program2
{
    internal class Program
    {
            public class Person
        {
            private int age;
            private String name;


            public Person()
            {
            }

            public Person(int age, String name)
            {
                this.age = age;
                this.name = name;
            }

            public int getAge()
            {
                return age;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public String getName()
            {
                return name;
            }

            public void setName(String name)
            {
                this.name = name;
            }


    public String toString()
            {
                return "Person{" +
                        "age=" + age +
                        ", name='" + name + '\'' +
                        '}';
            }
        }
        static void Main(string[] args)
        {
        Person person = new Person(38, "马蓉");
            Console.WriteLine(person);

        }
    }
}

