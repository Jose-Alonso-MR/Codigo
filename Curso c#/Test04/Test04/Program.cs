using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //bool resultado = DevuelveUnNumero("una cadena");
           

            //TestIfTernario();
            //TestStringIsNullOrEmpty();
            //TestBoolReverse();
            //TestIfElse();
            //BoolParse();
            //JoinStrings();
            //TestToString();
            //TestCadenaNumero();

        }


        private static bool DevuelveUnNumero(string unParametro)
        {
            return unParametro.Length > 0;
        }


        private static void TestSwitch()
        {
            int numero = 5;
            string resultado = "";
            switch (numero)
            {
                case 1:

                    resultado = "El número es 1";
                    break;

                case 2:

                    break;

                default:

                    break;
            }


        }


        private static void TestIfTernario()
        {

            string nombre = "";
            string saludo = "Hola ";


            string resultado = string.IsNullOrEmpty(nombre) ? "desconocido" : nombre;


            Console.WriteLine(saludo + resultado);


            Console.ReadLine();

        }

        private static void TestStringIsNullOrEmpty()
        {

            string nombre = "";
            string saludo = "Hola ";


            if (string.IsNullOrEmpty(nombre))
            {
                saludo += "desconocido";
            }
            else
            {
                saludo += nombre;
            }



            Console.WriteLine(saludo);
            Console.ReadLine();

        }



        private static void TestBoolReverse()
        {
            bool esVerdadero = true;

            Console.WriteLine(esVerdadero);
            esVerdadero = !esVerdadero;
            Console.WriteLine(esVerdadero);

            esVerdadero = !esVerdadero;
            Console.WriteLine(esVerdadero);


            Console.ReadLine();
        }


        private static void TestIfElse()
        {

            int numero = 7;
            if (numero == 10)
            {
                Console.WriteLine("El numero vale 10");
            }
            else if (numero == 5)
            {
                Console.WriteLine("El numero vale 5");
            }
            else
            {
                Console.WriteLine("El numero no vale ni 10 ni 5");
            }

        }


        private static void BoolParse()
        {
            bool conversion = bool.Parse("False");
            Console.WriteLine(conversion);

            conversion = bool.Parse("True");
            Console.WriteLine(conversion);

            Console.ReadLine();
        }



        private static void JoinStrings()
        {
            string saludo = "hola";

            string nombre = " Alonso";

            string mensaje = saludo + nombre + " hola otra vez " + " hola otra vez" + nombre +
                "nombre nombre rallalalla" + nombre + saludo;

            Console.WriteLine(mensaje);
            Console.ReadLine();

        }



        private static void TestToString()
        {
            DateTime fecha1 = new DateTime(2015, 05, 11);
            Console.WriteLine(fecha1);

            int numero = 100000000;
            Console.WriteLine(numero);

            DateTime fecha2 = DateTime.Now;
            Console.WriteLine(fecha2.ToString());
        }


        private static void TestCadenaNumero()
        {
            int numero2 = 10;
            string cadena = "hola";

            string saludo = cadena + numero2;
            string saludoInverso = numero2 + cadena;

            Console.WriteLine(saludo);
            Console.WriteLine(saludoInverso);

            Console.ReadLine();
        }

    }
}
