using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Cat : Animal
    {
        public override int Count()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            Console.WriteLine("Meow....");
        }

        public void Run()
        {
            Console.WriteLine("cat is running");
        }
    }
}
