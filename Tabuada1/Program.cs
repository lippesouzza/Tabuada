using System;

namespace Tabuada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;
            Console.WriteLine("Informe o Multiplicando");
            multiplicando = int.Parse(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 10; multiplicador++ )

            {
                Console.WriteLine(multiplicando + " x " + multiplicador + " = " + (multiplicando * multiplicador));

         

            }


        }
    }
}
