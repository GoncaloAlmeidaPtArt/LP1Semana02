using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Temperature: ");
            string temperatura = Console.ReadLine();

            Console.Write("Unit (C/F): ");
            string unidade = Console.ReadLine();

            switch (unidade)
            {
                case "C":

                    double temperaturaFC = Convert.ToDouble(temperatura);
                    Console.WriteLine($"{temperaturaFC:f2} C = {temperaturaFC * 1.8 + 32:f2} F");
                    Console.WriteLine($"Absolute Value: {Math.Abs(temperaturaFC * 1.8 + 32):f2}");

                    break;

                case "F":

                    double temperaturaFF = Convert.ToDouble(temperatura);
                    Console.WriteLine($"{temperaturaFF:f2} F = {(temperaturaFF - 32)/1.8:f2} C");
                    Console.WriteLine($"Absolute Value: {Math.Abs((temperaturaFF - 32)/1.8):f2}");

                    break;

                default:

                    Console.WriteLine("Invalid unit.");

                    break;

            }
        }
    }
}
