using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string textouser = Console.ReadLine();

            int numerouser = Convert.ToInt32(textouser);

            sbyte n = Convert.ToSByte(numerouser);

            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}
