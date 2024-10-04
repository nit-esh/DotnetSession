using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Country
    {
        //private string _name;
        private double _area;

        public string Name { get; set; }

        public double Area 
        { 
            get 
            { 
                return _area; 
            }
            set 
            { 
                if(value>0)
                   _area = value;
                else
                    Console.WriteLine("Area cannot be less than or equal to zero.");
            }
        }

        public Country(string name, double area)
        {
            Console.WriteLine("Hello from CTOR!!!");
            Name=name;
            Area = area;
        }


    }
}
