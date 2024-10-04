using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Mammal : Animal
    {
        public override int Count()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }
}
