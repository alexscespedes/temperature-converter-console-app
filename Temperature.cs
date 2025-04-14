namespace TemperatureConverter
{
    public class Temperature {
        
        public double CelsiusToFahrenheit(int celsius) {
            return (celsius * 9.0/5.0) + 32;
        }

        public double FahrenheitToCelsius(int fahrenheit) {
            return Math.Round((fahrenheit - 32) * 5.0/9.0, 2);
        }
    }
}