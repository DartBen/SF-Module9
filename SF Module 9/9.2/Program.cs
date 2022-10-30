using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            throw new ArgumentOutOfRangeException("Ошибка");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            WriteLine("Исключение :ArgumentOutOfRangeException");
        }
        finally
        {

        }

        try
        {
            throw new RankException("");
        }
        catch (RankException ex)
        {
            WriteLine(ex.GetType());
        }
        finally
        {
        }



    }
}

