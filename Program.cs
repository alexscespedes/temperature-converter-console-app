namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while(!exit) 
            {
                Console.WriteLine("Welcome to the Temperature Converter Console App console that converts temperatures between Fahrenheit and Celsius");
                Console.WriteLine("1 for Celsius to Fahrenheit");
                Console.WriteLine("2 for Fahrenheit to Celsius");
                Console.WriteLine("3 for Exit the Program");
                Console.Write("Choose a conversion direction: ");
                string choice = Console.ReadLine();

                switch(choice) 
                {
                    case "1":
                        Console.WriteLine("Hello 1");
                        break;
                    case "2":
                        Console.WriteLine("Hello 2");
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }
            }

        }
    }
}