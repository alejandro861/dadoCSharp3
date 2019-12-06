using System;

namespace dadoCSharp3
{
    class Program
    {
        static void dibujarDado(int caraSuperior, int caraCentral, int caraDerecha, int caraSuperior2, int caraCentral2, int caraIzquierda)
        {
            Console.WriteLine("                    ===========                            ===========");
            Console.WriteLine("                    =         =                            =         =");
            Console.WriteLine("                    =    {0}    =                            =    {1}    =", caraSuperior, caraSuperior2);
            Console.WriteLine("                    =         =                            =         =");
            Console.WriteLine("=========================================        =========================================");
            Console.WriteLine("=         =         =         =         =        =         =         =         =         =");
            Console.WriteLine("=    {0}    =    {1}    =    {2}    =    {3}    =        =    {4}    =    {5}    =    {6}    =    {7}    =", 7 - caraCentral, 7 - caraDerecha, caraCentral, caraDerecha, caraIzquierda, caraCentral2, 7 - caraIzquierda, 7 - caraCentral2);
            Console.WriteLine("=         =         =         =         =        =         =         =         =         =");
            Console.WriteLine("=========================================        =========================================");  
            Console.WriteLine("                    =         =                            =         =");
            Console.WriteLine("                    =    {0}    =                            =    {1}    =", 7 - caraSuperior, 7-caraSuperior2);
            Console.WriteLine("                    =         =                            =         =");
            Console.WriteLine("                    ===========                            ===========");
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
            Console.WriteLine("Presione 'Enter' para tirar los dados, en cuanto desee salir presione 'Esc'...");
            int[] valores1 = ObtenerValoresAleatorios();
            int[] valores2 = ObtenerValoresAleatorios();
            do
            {

                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nueva visualización...");
                    do
                    {
                        valores1 = ObtenerValoresAleatorios();
                        valores2 = ObtenerValoresAleatorios();
                    //    Console.WriteLine("valor 1 {0} y valor 2 {1}", valores1[1], valores2[1]);  Verificación
                    } while (valores1[1] == valores2[1]);
                    dibujarDado(valores1[0], valores1[1], valores1[2], valores2[0], valores2[1], valores2[2]);
                    Console.WriteLine("");
                    Console.WriteLine("La suma de los dados es de {0}...", valores1[1] + valores2[1]);
                }
                else if(tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine("La tecla no cumple ningun comando...");
                }
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
