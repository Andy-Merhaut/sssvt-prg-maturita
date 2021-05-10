using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pepa = new Person();
            pepa.Name = "Josef Kapusta";
            pepa.Age = 12;

            Console.WriteLine("Jmeno: {0}, Vek {1}", pepa.Name, pepa.Age);

            Person kuba = new Person() { Name = "Jakub Kopriva", Age = 5};

            Console.WriteLine("Jmeno: {0}, Vek {1}", kuba.Name, kuba.Age);

            Console.WriteLine(kuba);

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + " Age: " + Age;
        }
    }
}
