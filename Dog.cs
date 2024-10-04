using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Dog : Mammal
    {

        private double _weight;
        private int _height_cm;


        public string Breed { get; set; }
        public int Height_CM { get=>_height_cm; 
            set
            {
                _height_cm=(value>0)?value:0;
            } 
        }
        public Dog(string breed, int height)
        {
            Breed=breed;
            Height_CM = height;
        }



        public override void Speak()
        {
            Console.WriteLine("Bark...");
        }

        public override int Count()
        {
            throw new NotImplementedException();
        }
    }
}
