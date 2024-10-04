using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
       //private string name;
       private int poi;
       public string Name { get; set; }
       
       public int Age
        {
            get => poi;
            set
            {
                if(value >= 0)
                poi = value;
            }
        }

        public Person(string abc, int age)
        {
            Name = abc;
            Age = age;
        }

        public void DisplayInfo()
        {
          
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Age: {0}",Age);
        }
    }

    
}
