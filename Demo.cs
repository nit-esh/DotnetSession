namespace School
{
    internal class Demo
    {
        int userInput;

        public int UserInput
        {
            get
            {
                return userInput;
            }
            set
            {
                if (value > 0)
                    userInput = value;
                else
                    Console.WriteLine(" Please enter value greater than 0");
            }
        }



        public void ReadUserValue()
            {
            Console.Write("Enter any value: ");
            UserInput = int.Parse(Console.ReadLine());
            
            }
        public void UserOutput()
        {
            if (userInput > 0)
            {
                if (userInput % 2 == 0)
                {
                    Console.WriteLine("User has given even number as Input");
                    for (int i = 2; i <= (userInput * 2); i += 2)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.WriteLine("User has given odd number as Input");
                    for (int i = 1; i <= ((userInput * 2) - 1); i += 2)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
