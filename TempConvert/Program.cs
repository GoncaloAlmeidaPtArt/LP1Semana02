using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //A pedido do professor
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //Peço a temperatura
            Console.Write("Temperature: ");
            string temperatura = Console.ReadLine();

            //Peço o tipo de temperatura
            Console.Write("Unit (C/F): ");
            string unidade = Console.ReadLine();

            switch (unidade)
            {
                case "C":

                    //mostra como double a temperatura escolhida, a versão oposta 
                    //da escolhida e o Absolute da escolhida 
                    double temperaturaFC = Convert.ToDouble(temperatura);
                    Console.WriteLine($"{temperaturaFC:f2} C = {temperaturaFC * 1.8 + 32:f2} F");
                    Console.WriteLine($"Absolute Value: {Math.Abs(temperaturaFC * 1.8 + 32):f2}");

                    break;

                case "F":

                    //mostra como double a temperatura escolhida, a versão oposta 
                    //da escolhida e o Absolute da escolhida 
                    double temperaturaFF = Convert.ToDouble(temperatura);
                    Console.WriteLine($"{temperaturaFF:f2} F = {(temperaturaFF - 32)/1.8:f2} C");
                    Console.WriteLine($"Absolute Value: {Math.Abs((temperaturaFF - 32)/1.8):f2}");

                    break;

                default:
                    
                    //Indica que o utilizador não escolheu nenhuma das opções
                    Console.WriteLine("Invalid unit.");

                    break;

            }
        }
    }
}
