using System;

namespace dadoCSharp3
{
    class Program
    {
        static void dibujarDado(int caraSuperior, int caraCentral, int caraDerecha)
        {
            Console.WriteLine("                    ===========");
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    =    {0}    =", caraSuperior);
            Console.WriteLine("                    =         =");
            Console.WriteLine("=========================================");
            Console.WriteLine("=         =         =         =         =");
            Console.WriteLine("=    {0}    =    {1}    =    {2}    =    {3}    =", 7 - caraCentral, 7 - caraDerecha, caraCentral, caraDerecha);
            Console.WriteLine("=         =         =         =         =");
            Console.WriteLine("=========================================");  
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    =    {0}    =", 7 - caraSuperior);
            Console.WriteLine("                    =         =");
            Console.WriteLine("                    ===========");
        }

        static int[] ObtenerValoresAleatorios()
        {
            Random aleatorio = new Random();
            int indice = 0;
            int[] respuesta = new int[3];

            while (indice < 3)
            {
                int nuevoAleatorio = aleatorio.Next(1, 7);

                if (nuevoAleatorio != respuesta[0] && nuevoAleatorio != respuesta[1] && nuevoAleatorio != respuesta[2] &&
                    7 - nuevoAleatorio != respuesta[0] && 7 - nuevoAleatorio != respuesta[1] && 7 - nuevoAleatorio != respuesta[2])
                {

                    respuesta[indice] = nuevoAleatorio;
                    indice++;
                }

            }
            return respuesta;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Primer tirada de dados...");
            int[] valores = ObtenerValoresAleatorios();
            dibujarDado(valores[0], valores[1], valores[2]);
            Console.WriteLine("");
            do
            {

                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nueva visualización...");
                    valores = ObtenerValoresAleatorios();
                    dibujarDado(valores[0], valores[1], valores[2]);
                    Console.WriteLine("");
                }
                else if(tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("La tecla no cumple ningun comando...");
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
