using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Fest
    {
        //Data

        //Methods

        //Synatx for methods

        //syntax for object

        // Fest xyz = new Fest();
        // Fest xyz= new();
        // var xyz= new Fest();

        int number = 5;
        string message = "Hello";

        public Fest() 
        {

            Console.WriteLine("Hello from Fest Constructor");
        }


        public void ShowGreetings()
        {
            Console.WriteLine("Welcome to Cultural Fest");
           
        }

        internal void ShowGreetings(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowGreetings(string message, string exclaimation)
        {
            Console.WriteLine(message+" "+exclaimation);
        }

        public void ShowGreetings(string message, string exclaimation,int count)
        {
            Console.WriteLine(message + " " + exclaimation + count);
            
        }

        public static void Greetings(string first_name,string last_name)
        {
            Console.WriteLine("Welcome {0} {1}",last_name,first_name);
            Console.WriteLine($"Welcome {first_name} {last_name}");
        }
    }
}
