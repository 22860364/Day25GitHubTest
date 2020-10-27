using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Car();
            Console.WriteLine("Hello World");
            Console.Read();
        }
    }

    class Animal
    {
        public void Car()
        {
            Console.WriteLine("喵喵喵");
        }
    }
    
}
