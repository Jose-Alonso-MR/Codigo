using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClases
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();


            Student estudianteJorge = 
                new Student("Jorge", "González", "C/ Buen Orden 24");
            students.Add(estudianteJorge);

            Student estudianteFrancisco = 
                new Student("Francisco", "Martínez", "Avda Primero Mayo");
            students.Add(estudianteFrancisco);


            PrintStudentNames(students);


            Console.ReadLine();

        }

        private static void PrintStudentNames(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
