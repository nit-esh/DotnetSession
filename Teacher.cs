
using School;

namespace School

{
    public class Teacher
    {
       
        public static void GetTeacherData()
        {
            Console.WriteLine("Hello from Teacher");
        }

        public string GetNames(string name)
        {
            return name;
        }

        internal string GetNames()
        {
            return "";
        }

        protected internal void GetSalary()
        {
            Console.WriteLine("Salary :1100");
            GetNames("Good Day");
        }
        public void TeacherMessage()
        {
            Console.WriteLine("Greetings from Teacher");
            GetAge();
        }

        protected void GetAge()
        {
            Console.WriteLine("29");
        }

        protected internal void GetPrincipalAge(int age)
        {
            Console.WriteLine(age);
        }

        private protected void GetDirectorName()
        {
            Console.WriteLine("D K Singh");
        }
    }

    
    

}


