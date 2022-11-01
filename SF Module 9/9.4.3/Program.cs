internal class Program
{

    public delegate Car del();
    public static Car CarHandler()
    {
        return null;
    }

    public static Lexus LexusHandler()
    {
        return null;
    }

    private static void Main(string[] args)
    {
        del del = LexusHandler;
    }
}

class Car { }
class Lexus : Car { }