﻿namespace DelegatePractices
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = ()=> new Random().Next(0, 100);

            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
    }
}

