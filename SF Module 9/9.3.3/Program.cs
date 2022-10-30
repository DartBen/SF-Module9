internal class Program
{

    public delegate int DecDelegate(int A, int B);
    private static void Main(string[] args)
    {
        DecDelegate DecDelegate = Dec;
        int result = DecDelegate.Invoke(6, 5);
        Console.WriteLine(result);

        result = DecDelegate(6, 5);
        Console.WriteLine(result);
    }

    public static int Dec(int A, int B)
    {
        return B - A;
    }

}