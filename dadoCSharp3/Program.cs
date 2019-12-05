using System;

namespace dadoCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("Hello World!");

            do
            {

                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Nueva visualización...");
                }
                else if(tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("La tecla no cumple ningun comando...");
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
