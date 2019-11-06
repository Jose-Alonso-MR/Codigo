using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorNumerosConsola
{
    class Program
    {

        private static string[] unidades = new string[]
        {
            "Cero",
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"
        };

        private static string[] onces = new string[]
        {
            "Diez", 
            "Once",
            "Doce",
            "Trece",
            "Catorce",
            "Quince",
            "Dieciseis",
            "Diecisiete",
            "Dieciocho",
            "Diecinueve",
        };

        private static string[] decenas = new string[]
        {
            "Cero",
            "Diez",
            "Veinte",
            "Treinta",
            "Cuarenta",
            "Cincuenta",
            "Sesenta",
            "Setenta",
            "Ochenta",
            "Noventa"
        };


        private static string[] centenas = new string[]
        {
            "Cero",
            "Uno",
            "Doscientos",
            "Trescientos",
            "Cuatrocientos",
            "Quinientos",
            "Seiscientos",
            "Setecientos",
            "Ochocientos",
            "Novecientos"
        };


        static void Main(string[] args)
        {
            string input = args[0];

            List<string> grupos = CrearGrupos(input);

            string resultado = "";
            for (int i = 0; i < grupos.Count; i++)
            {
                bool grupoMil = false;
                bool grupoMillon = false;

                if(  (i == 0 && grupos.Count == 2) ||  (i == 1 && grupos.Count == 3) )
                {
                    grupoMil = true;
                }

                if (i == 0 && grupos.Count == 3)
                {
                    grupoMillon = true;
                }

                resultado += CalculoTresDigitos(grupos[i], grupoMil, grupoMillon);

            }

            Console.Write(resultado);
            Console.ReadLine();

        }



        private static List<string> CrearGrupos(string input)
        {
            List<string> grupos = new List<string>();

            int numeroGrupos = input.Length / 3;
            int resto = input.Length % 3;
            int inicio = 0;

            if(resto != 0)
            {
                grupos.Add(input.Substring(0, resto));
                inicio = resto;
            }

            for(int i = inicio; i < input.Length; i += 3)
            {
                grupos.Add(input.Substring(i, 3));
            }


            return grupos;

        }



        private static string CalculoTresDigitos(string input, bool grupoMil, bool grupoMillon)
        {
            decimal numero = decimal.Parse(input);
            string resultado = "";

            bool procesarDecenas = true;
            bool procesarUnidades = true;

            //centenas
            if (input.Length == 3)
            {
                //100
                string parteCentena = input[0].ToString();
                int parteCentenaInt = int.Parse(parteCentena);

                if (numero == 100)
                {
                    resultado += "cien";
                    procesarDecenas = false;
                    procesarUnidades = false;
                }
                else if (parteCentenaInt == 1)
                {
                    resultado += "ciento";
                }
                else
                {
                    resultado += centenas[parteCentenaInt];
                }
            }

            //decenas 26
            if (input.Length >= 2 && procesarDecenas == true )
            {
                string parteDecena = input.Substring(input.Length == 3 ? 1 : 0 , 2);
                int parteDecenaInt = int.Parse(parteDecena);

                string parteDecenaA = parteDecena[0].ToString();
                string parteDecenaB = parteDecena[1].ToString();

                int parteDecenaIntA = int.Parse(parteDecenaA);
                int parteDecenaIntB = int.Parse(parteDecenaB);

                if (parteDecenaIntA <= 2)
                {
                    //10-19
                    if (parteDecenaIntA == 1)
                    {
                        resultado += onces[parteDecenaIntB];
                        procesarUnidades = false;
                    }
                    //20-29
                    else if (parteDecenaIntA == 2)
                    {
                        resultado += "veinti";
                    }
                }
                else
                {
                    resultado += decenas[parteDecenaIntA];
                }
            }


            //unidades 6
            if (procesarUnidades == true)
            {
                string parteEntera = input[input.Length - 1].ToString();
                int parteEnteraInt = int.Parse(parteEntera);

                if(grupoMillon == true && parteEnteraInt == 1)
                {
                    resultado += "un";
                }
                else if(parteEnteraInt != 1 || input.Length != 1)
                {
                    resultado += unidades[parteEnteraInt];
                }
                
            }


            //determinar miles/millones
            if (grupoMil)
            {
                resultado += "mil";
            }

            if (grupoMillon)
            {
                if (numero == 1)
                {
                    resultado += "millón";
                }
                else
                {
                    resultado += "millones";
                }
            }

            return resultado;

        }


    }
}
