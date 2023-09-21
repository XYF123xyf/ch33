using program7;
using static program7.Program;
using System.Xml.Linq;

namespace program7
{
    internal class Program
    {
        public abstract class Animal
        {
            String name;
            public Animal()
            {

            }
            public Animal(String name)
            {
                this.name = name;
            }
            abstract public void enjoy();
        }

        class Cat extends Animal
        {
            String eyesColor;

    public Cat() { }
        public Cat(String eyesColor, String name)
        {
            this.eyesColor = eyesColor;
            this.name = name;
        }
        @Override
    public void enjoy()
        {
            System.out.println("miao~,我叫" + name + ",我的眼睛是" + eyesColor + ",我很快乐");
        }
    }
    class Dog extends Animal
    {
        String furColor;

    public Dog() { }
    public Dog(String name, String furColor)
    {
        this.name = name;
        this.furColor = furColor;
    }
    @Override
    public void enjoy()
    {
        System.out.println("wang~,我叫" + name + ",我的皮毛是" + furColor + ",我很快乐");
    }
}
public class Lady
{
    String name;
    Animal pet;
    public Lady() { }
    public Lady(String name, Animal pet)
    {
        this.name = name;
        this.pet = pet;
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public Animal getPet()
    {
        return pet;
    }
    public void setPet(Animal pet)
    {
        this.pet = pet;
    }
    public void myPetEnjoy()
    {
        pet.enjoy();
        System.out.println("我叫" + this.name + ",我的宠物很高兴,我也很高兴");
    }
}
public class AbstractClassTest2
{

    static void Main(string[] args)
    {
        Animal a = new Dog("旺财", "豹纹");
        Lady lady = new Lady("凤姐", a);
        lady.myPetEnjoy();

        System.out.println("过了10多年,旺财不幸去世了,凤姐又领养了一只宠物");
        Animal b = new Cat("粉色", "喵星人");
        lady.setPet(b);
        lady.myPetEnjoy();

        Lady lady2 = new Lady();
        lady2.setName("芙蓉姐姐");
        lady2.setPet(new Dog("辛巴", "huase"));
        lady2.myPetEnjoy();
    }

}

    }
}