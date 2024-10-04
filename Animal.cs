using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace School
{
    public abstract class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound...."); //logic=1
        }

        public abstract int Count(); //logic= 0

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
