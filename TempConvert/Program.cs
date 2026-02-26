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
                    Console.WriteLine(temperaturaFC + " C = " + (temperaturaFC * 1.8 + 32) + " F");
                    Console.WriteLine(Math.Abs(temperaturaFC));

                    break;

                case "F":

                    double temperaturaFF = Convert.ToDouble(temperatura);
                    Console.WriteLine(temperaturaFF + " F = " + ((temperaturaFF - 32)/1.8) + " C");
                    Console.WriteLine(Math.Abs(temperaturaFF));

                    break;

                default:

                    break;

            }
        }
    }
}
