using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = args[0];

            for(int i = 0, j = word.Length - 1; i < word.Length && j >= 0 ; i++, j--)
            {
                if(word[i] != word[j])
                {
                    Console.WriteLine("La palabra " + word + " no es un palíndromo");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("La palabra " + word + " sí es un palíndromo");
            Console.ReadLine();

            //TestListRemove();

            //TestListIndex();
            //TestListContains();
            //TestList();
            //TestArrayListBoxUnbox();
        }

        private static void TestListRemove()
        {
            List<DateTime> listaFechas = new List<DateTime>()
            {
                new DateTime(2001, 10, 22),
                new DateTime(2011, 10, 22),
                new DateTime(2012, 10, 22),
            };

            int totalElementos = listaFechas.Count;
            for (int i = 0; i < listaFechas.Count; i++)
            {
                if (i == 1)
                {
                    listaFechas.RemoveAt(i);
                    totalElementos--;
                }

                Console.WriteLine(listaFechas[i]);
            }

            Console.ReadLine();


        }

        private static void TestListIndex()
        {

            List<DateTime> listaFechas = new List<DateTime>()
            {
                new DateTime(2001, 10, 22),
                new DateTime(2011, 10, 22),
                new DateTime(2012, 10, 22),
            };

            listaFechas.Add(new DateTime(2012, 10, 22));

            //Console.WriteLine(listaFechas.IndexOf(new DateTime(2012, 10, 22)));
            //Console.WriteLine(listaFechas.LastIndexOf(new DateTime(2012, 10, 22)));

            listaFechas.Insert(1, new DateTime(2003, 5, 10));

            foreach (DateTime fecha in listaFechas)
            {
                Console.WriteLine(fecha);
            }


            Console.WriteLine(listaFechas.ToString());


            Console.ReadLine();
        }

        private static void TestListContains()
        {
            List<int> miListaNumeros = new List<int>()
            {
                2, 3, 4, 5
            };


            Console.WriteLine(miListaNumeros.Contains(3));


            List<string> miListaStrings = new List<string>()
            {
                "hola",
                "adios",
                "juanito"
            };

            Console.WriteLine(miListaStrings.Contains("holafdsfds"));


            Console.ReadLine();

        }

        private static void TestList()
        {
            List<string> miListaStrings = new List<string>()
            {
                "hola",
                "adios",
                "juanito"
            };

            List<int> miListaNumeros = new List<int>()
            {
                2, 3, 4, 5
            };


            foreach (string elemento in miListaStrings)
            {
                Console.WriteLine("hola " + elemento);
            }


            Console.ReadLine();

        }


        private static void TestArrayListAddRange()
        {
            ArrayList miArrayDinamico = new ArrayList();

            int[] arrayNumeros = new int[] { 3, 4, 5 };
            ArrayList otroArrayList = new ArrayList();

            miArrayDinamico.AddRange(otroArrayList);

            Console.ReadLine();
        }


        private static void TestArrayListRemove()
        {
            ArrayList miArrayDinamico = new ArrayList();

            for (int i = 1; i <= 10; i++)
            {
                miArrayDinamico.Add(i);
            }

            miArrayDinamico.Remove(3);

            miArrayDinamico.RemoveAt(3);

            foreach (object objeto in miArrayDinamico)
            {
                int numeroExtraido = (int)objeto;
                Console.WriteLine("hola " + numeroExtraido);
            }
        }

        private static void TestArrayListBoxUnbox()
        {

            ArrayList miArrayDinamico = new ArrayList();

            int numero = 5;
            for (int i = 1; i <= 10; i++)
            {
                miArrayDinamico.Add(numero + i);
            }

            foreach (object objeto in miArrayDinamico)
            {
                int numeroExtraido = (int)objeto;

                Console.WriteLine("hola " + numeroExtraido);
            }


            Console.ReadLine();

        }

    }
}
