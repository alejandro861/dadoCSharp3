using System;

namespace dadoCSharp3
{
    class Program
    {
        static void DibujarDado(int caraSuperior, int caraCentral, int caraDerecha)
        {

            Console.WriteLine("                    ===========");
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    =    {0}    =", caraSuperior);
            Console.WriteLine("                    =         =");
            Console.WriteLine("=========================================");
            Console.WriteLine("=         =         =         =         =");
            Console.WriteLine("=    {0}    =    {1}    =    {2}    =    {3}    #", 7 - caraCentral, 7 - caraDerecha, caraCentral, caraDerecha);
            Console.WriteLine("=         =         =         =         =");
            Console.WriteLine("=========================================");  
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    =    {0}    =", 7 - caraSuperior);
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    ===========");

        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Primer tirada de dados...");
            DibujarDado(1, 2, 3);
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
