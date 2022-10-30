internal class Program
{
    private static void Main(string[] args)
    {
        Exception exc = new Exception("Message");

        exc.Data.Add("Дата создания:",DateTime.Now);

        exc.HelpLink = "https://metanit.com/";


    }
}