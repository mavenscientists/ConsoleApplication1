using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]); 
            }

            Console.ReadLine();

        }
    }
}
