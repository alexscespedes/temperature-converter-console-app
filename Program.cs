namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool confirmation = true;
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
                        do
                        {
                        Console.WriteLine("Celsius to Fahrenheit");
                        Console.Write("Insert the temperature to convert: ");
                        if (!int.TryParse(Console.ReadLine(), out int celsius)) 
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                                break;
                            } 
                        var fahrenheit = temperatureConverted.CelsiusToFahrenheit(celsius);
                        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
                        Console.Write("Do you want to perform another another conversion (Y/N): ");
                        string userConfirmation = Console.ReadLine();
                        if (userConfirmation == "N" || userConfirmation == "No")
                        {
                            confirmation = false;
                        }
                        else if (userConfirmation != "Y" || userConfirmation != "Yes")
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        } while (confirmation);
                        break;
                    case 2:
                        do
                        {
                        Console.WriteLine("Fahrenheit to Celsius");
                        Console.Write("Insert the temperature to convert: ");
                        if (!int.TryParse(Console.ReadLine(), out int fahrenheit)) 
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                                break;
                            }
                        var celsius = temperatureConverted.FahrenheitToCelsius(fahrenheit);
                        Console.WriteLine($"{fahrenheit}°C is equal to {celsius}°F");
                        Console.Write("Do you want to perform another another conversion (Y/N): ");
                        string userConfirmation = Console.ReadLine();
                        if (userConfirmation == "N" || userConfirmation == "No")
                        {
                            confirmation = false;
                        }
                        else if (userConfirmation != "Y" || userConfirmation != "Yes")
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        } while (confirmation);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
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