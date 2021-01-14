using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sinppet6
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal contructor without parameters");

        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameters");
        }
    }
    class Canine : Animal
    {
        //base() takes a string value called"Lion"
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");

        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Canine objCanine = new Canine();
        }

    }
}
