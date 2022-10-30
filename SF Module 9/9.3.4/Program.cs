internal class Program
{
    private static void Main(string[] args)
    {
        del del = Method1;
        del += Method2;

        del(5, 5);

        del -= Method1;

        del (6,6);
    }
    delegate void del(int a, int b);

    public static void Method1(int A, int B)
    {
        int result = A - B;
        Console.WriteLine(result);
    }

    public static void Method2(int A, int B)
    {
        int result = A + B;
        Console.WriteLine(result);
    }
}