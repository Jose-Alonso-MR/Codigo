using System;


namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colordelaconsola = ConsoleColor.DarkMagenta;

            colordelaconsola = ConsoleColor.DarkGreen;

            string textodevienvenida = "Hola mundo soy Alonso";
            string otrotexto = " en c#";

            //Cambiar el color de la consola
            Console.BackgroundColor = colordelaconsola;
            Console.WriteLine(textodevienvenida + otrotexto);
            Console.ReadLine();
        }
    }
}
