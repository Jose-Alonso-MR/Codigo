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
            List<Person> persons = new List<Person>();


            Student estudianteJorge =
                new Student("Jorge", "González");
            persons.Add(estudianteJorge);

            Teacher profesorJuanito =
                new Teacher("Juanito", "Melenas");
            persons.Add(profesorJuanito);


            WorkWithPersons(persons);


            //List<Student> students = new List<Student>();


            //Student estudianteJorge =
            //    new Student("Jorge", "González");


            //students.Add(estudianteJorge);

            //Student estudianteFrancisco =
            //    new Student("Francisco", "Martínez");
            //students.Add(estudianteFrancisco);


            //PrintPersonNames(persons);


            Console.ReadLine();

        }


        private static void WorkWithPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                //metodo 1
                if (person is Teacher)
                {
                    Teacher teacher = (Teacher)person;
                    Console.WriteLine("Profesor " + teacher.Name);
                }
                else if (person is Student)
                {
                    Student student = (Student)person;
                    Console.WriteLine("Estudiante " + student.Name);
                }

                //metodo2
                Teacher teacherAs = person as Teacher;
                if(teacherAs != null)
                {
                    Console.WriteLine("Profesor " + teacherAs.Name);
                }
                else
                {
                    Student studentAs = person as Student;
                    Console.WriteLine("Estudiante " + studentAs.Name);
                }


            }
        }


        private static void PrintPersonNames(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Greeting());
            }
        }

        //private static void PrintStudentNames(List<Student> students)
        //{
        //    foreach (Student student in students)
        //    {
        //        Console.WriteLine(student.Name);
        //    }
        //}
    }
}
