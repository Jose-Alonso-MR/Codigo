using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] operators = new string[] { "+", "-", "*", "/" };

            Console.WriteLine("Escribe el primer número");
            string operand1 = Console.ReadLine();

            int number1 = 0;
            if(!int.TryParse(operand1, out number1))
            {
                Console.WriteLine("Número no válido");
                Console.ReadLine();
                return;
            }



            Console.WriteLine("Escribe el operador");
            string op = Console.ReadLine();

            if(!operators.Contains(op))
            {
                string resultado = "Operador no soportado, sólo";

                foreach(string opt in operators)
                {
                    resultado += " " + opt;
                }

                Console.WriteLine(resultado);
                Console.ReadLine();
                return;
            }


            Console.WriteLine("Escribe el segundo número");

            string operand2 = Console.ReadLine();

            int number2 = 0;
            if (!int.TryParse(operand2, out number2))
            {
                Console.WriteLine("Número no válido");
                Console.ReadLine();
                return;
            }


            if(op == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (op == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (op == "/")
            {
                Console.WriteLine(number1 / number2);
            }


            Console.ReadLine();


            //TestForEach();
            //TestArrayInts();
            //TestSimpleConsoleInput(args);
            //TestArrayStrings();
            //TestGoto();
            //TestDoWhile();
            //TestWhile()
            //TestFor();
        }

        private static void TestForEach()
        {

            int[] miListaNumeros = new int[] {

                1,
                2,
                3,
                4,
                5

            };


            foreach (int numero in miListaNumeros)
            {
                Console.WriteLine("hola" + numero);
            }

            Console.ReadLine();
        }


        private static void TestArrayInts()
        {

            int[] miListaNumeros = new int[] {

                1,
                2,
                3,
                4,
                5

            };


            for (int i = 0; i < miListaNumeros.Length; i++)
            {
                Console.WriteLine("hola " + miListaNumeros[i]);
            }

            Console.ReadLine();
        }

        private static void TestSimpleConsoleInput(string[] args)
        {

            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("hola " + args[i]);
                }
            }
            else
            {
                Console.WriteLine("No hay entrada");
            }

            Console.ReadLine();
        }



        private static void TestArrayStrings()
        {
            string[] listaCadenas = new string[] {

                "hola",
                "adios",
                "juanito",
                "otrovalor",
                "juanito",
                "otrovalor",
                "juanito",
                "otrovalor"

            };

            string[] listaCadenasGrande = new string[15];

            listaCadenas.CopyTo(listaCadenasGrande, 0);

            for (int i = 0; i < listaCadenasGrande.Length; i++)
            {

                Console.WriteLine(listaCadenasGrande[i]);
            }


            Console.ReadLine();

        }


        private static void TestGoto()
        {
            int i = 1;

            principio:

            if (i == 10)
            {
                goto final;
            }

            i++;

            goto principio;

            final:


            Console.WriteLine("El valor de i = " + i);
            Console.ReadLine();
        }


        private static void TestDoWhile()
        {
            int i = 10;

            do
            {
                i++;

                Console.WriteLine("El valor de i = " + i);

            } while (i <= 10);

            Console.ReadLine();
        }


        private static void TestWhile()
        {
            int i = 11;
            while (i <= 10)
            {
                i++;

                if (i % 2 == 0)
                {
                    break;
                }

                Console.WriteLine("El valor de i = " + i);
            }

            Console.ReadLine();
        }

        private static void TestFor()
        {
            for (int i = 0, j = 0; i < 10 || j >= -9; i++, j--)
            {

                Console.WriteLine("El valor de i = " + i);
                Console.WriteLine("El valor de j = " + j);

            }

            Console.ReadLine();
        }

    }
}
