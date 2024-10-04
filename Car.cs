using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal abstract class Car
    {

        //Virtual Method:

        public virtual void StartCar()
        {
            Console.WriteLine("Hello from Car!");
        }


        //Abstract method
        public abstract void StopCar();
    }
}
