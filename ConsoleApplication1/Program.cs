using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static void Multiplicate ()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Произведение чисел " + a + " и " + b + " равняется " + a * b);
        }
        //public static string CreateFIO(string surname, string name, string otchestvo)
        //{
        //    string fio = surname + " " + name + " " + otchestvo;
        //    return fio;
        //}
        static void Main(string[] args)
        {

            //Person person1 = new Person("Ефимов", "Андрей", "Васильевич");
            //Person person2 = new Person("Пушкин", "Александр", "Сергеевич");

            //Console.WriteLine(person1.GetFIO());
            //Console.WriteLine(person2.GetFIO());

            

            Multiplicate();

            Multiplicate();

            Console.WriteLine();

            Console.ReadLine();

        }
    }

    public class Person
    {
        public string Name = "";
        public string Surname = "";
        public string Otchestvo = "";

        public Person(string surname, string name, string otchestvo)
        {
            Name = name;
            Surname = surname;
            Otchestvo = otchestvo;
        }

        public string GetFIO()
        {
            string fio = Surname + " " + Name + " " + Otchestvo;
            return fio;
        }
    }
}
