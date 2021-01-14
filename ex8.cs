using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet8
{
    class Animal
    {
        public virtual void Eat() {
            Console.WriteLine("Every animal eats something ");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animal dose something");
        }
    }
    class Cat : Animal
    {
        //Class Cat overrides Eat()method of class Animal
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
    
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
        }
    }
}
