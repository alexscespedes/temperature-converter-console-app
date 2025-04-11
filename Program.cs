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
                if (!int.TryParse(Console.ReadLine(), out int userInput)) 
                    {
                        System.Console.WriteLine("Invalid input! Please enter a valid integer");
                        continue;
                    }

                var temperatureConverted = new Temperature();

                switch(userInput) 
                {
                    case 1:
                        Console.WriteLine("Celsius to Fahrenheit");
                        Console.Write("Insert the temperature to convert: ");
                        if (!int.TryParse(Console.ReadLine(), out int celsius)) 
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                                continue;
                            }
                        var fahrenheit = temperatureConverted.CelsiusToFahrenheit(celsius);
                        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
                        break;
                    case 2:
                        Console.WriteLine("Hello 2");
                        break;
                    case 3:
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