using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCurso.NET09
{
    class Program
    {


        static void Main(string[] args)
        {

            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                stb.Append(i);
            }


            string resultado = "1"; 
            for(int i = 0; i < 100; i++)
            {
                resultado += i;
            }


            Console.WriteLine(resultado);

            Console.ReadLine();


            //TestSplit();

            //FuncionArrayNumeros(1, 2, 3, 4, 5, 6);
            //
            //FuncionArrayString(new string[] { "uno", "dos", "tres" });


            //string saludo = Saludar();

            //double numeroBase = 10;
            //double potencia = 3;
            //double resultado = ElevarPotencia(numeroBase, potencia);
            //double resultadoCuadrada = ElevarPotencia(numeroBase);



            //double operand1 = 10.5;
            //double operand2 = 50.3;
            //double resultado = Sumar(operand1, operand2);

            //int resultado = UsoReturn(numero);
            //SumarDosRef(ref numero);
            //SumarDosRef(out numero);


        }


        private static void TestSplit()
        {
            string cadena = "1;2;3;4;;;;5;6;;;";
            string[] trozos = cadena.Split(';');

            foreach (string strozo in trozos)
            {
                Console.WriteLine(strozo);
            }


        }


        private static void FuncionArrayNumeros(params int[] numeros)
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }


        private static void FuncionArrayString(params string[] cadenas)
        {
            foreach(string cadena in cadenas)
            {
                Console.WriteLine(cadena);
            }

        }






        private static string Saludar(string requerido, string nombre = null, string nombre1 = null, string nombre3 = null, string nombre4 = null)
        {
            return string.IsNullOrEmpty(nombre) ? "Hola desconocido" : "Hola " + nombre;
        }



        private static double ElevarPotencia(double numero, double potencia = 2)
        {

            return Math.Pow(numero, potencia);

        }






        private static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }


        private static double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }






        private static int UsoReturn(int numero)
        {
            if (numero == 2)
            {
                return numero * 3;
            }


            return numero * 10;
        }



        private static void SumarDosRef(ref int numero)
        {
            numero += 2;
        }


        private static void SumarDosOut(out int numero)
        {
            numero = 2;
        }


    }
}
