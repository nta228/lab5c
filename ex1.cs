using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code

{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
    }
    class Manmal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Manmals give birth to young ones.");
        }
    }
    class Dog : Manmal
    {
        public void Noise()
        {
            Console.WriteLine("DogBarks.");
        }
     static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
}
