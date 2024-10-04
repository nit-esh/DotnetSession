namespace School

{
    public class Student
    {
        
        public static void Main()
        {
            //Console.WriteLine("Hello from Student");
            //Console.WriteLine("****************************************");

            //Teacher.GetTeacherData();
            //var teacher = new Teacher();
            //teacher.GetNames("Himani");

            //var student = new Student();
            //student.GetAge();
            //teacher.GetPrincipalAge(56);
            //teacher.GetSalary();
            //student.GetDirectorName();


            //Fest fest = new();

            //fest.ShowGreetings();
            //fest.ShowGreetings("Welcome to Annual fest");
            //fest.ShowGreetings("Welcome to Convocation");
            //fest.ShowGreetings();
            //fest.ShowGreetings("Hello 123...");

            //Fest.Greetings("Vanlal", "Ampuii");

            //fest.ShowGreetings("Welcome to the party", "!!!");
            //fest.ShowGreetings("hello", "!", 3);

            //Animal animal = new();
            //animal.Speak();

            //Dog dog = new Dog();
            //dog.Speak();

            //Cat cat = new Cat();
            //cat.Speak();


            //Person person = new Person("Vanlal",12);
            //Console.WriteLine(person.Name);


            //person.DisplayInfo();

            //Country country = new("India",-96.32);
            //Console.WriteLine(country.Name);
            //Console.WriteLine(country.Area);

            //Dog dog = new("German Shepherd", -7);
            //Console.WriteLine(dog.Breed);
            //Console.WriteLine(dog.Height_CM);

            //Triangle triangle = new Triangle(3, 5);
            //var triangleArea= triangle.Area();
            //var trianglePerimeter= triangle.Perimeter();

            //Console.WriteLine($"Triangle: Area={triangleArea}, Perimeter={trianglePerimeter}");
            //Console.WriteLine("Triangle: Area={1}, Perimeter={0}",trianglePerimeter,triangleArea);
            //Console.WriteLine("==========================================================");

            //Square square = new Square(5);
            //var squareArea= square.Area();
            //var squarePerimeter= square.Perimeter();
            //Console.WriteLine($"Square: Area={squareArea}, Perimeter={squarePerimeter}");
            //Console.WriteLine("Sqaure: Area={0}, Perimeter={1}", squareArea, squarePerimeter);

            //Console.WriteLine("Hello");

            //Demo demo= new Demo();
            //demo.ReadUserValue();
            //demo.UserOutput();

            for (int i = 5 ; i>0; i--)
            {

               
                for (int j =1; j <=i-1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k<=6-i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine();


            }
           







        }
    }
}
