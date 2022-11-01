using System.Xml.Linq;

internal class Program
{
    public delegate void delegat(Child c);

    public static void ParentInfo(Parent p)
    {
        Console.WriteLine(p.GetType());
    }


    private static void Main(string[] args)
    {
        delegat del = ParentInfo;

        del.Invoke(new Child());

    }
}

class Parent { }
class Child : Parent { }



