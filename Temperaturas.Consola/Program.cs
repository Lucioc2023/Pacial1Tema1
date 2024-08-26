using Temperaturas.Entidades;

namespace Temperaturas.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celcius = new Celsius();
            Fahrenheit fahrenheit = new Fahrenheit();

            Celsius celcius2 = celcius+ fahrenheit;
            Console.WriteLine(celcius2);

            Fahrenheit fahrenheit2 = fahrenheit + celcius;
            Console.WriteLine(fahrenheit2);

        }
    }
}
