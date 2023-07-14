using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_2_Promedio_Vectores_
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 3;
            for (int i = 1; i<=365; i++)
            {
                Console.WriteLine("Dia: {0},{1} centavos", i, sum);
                sum = sum + (2 * sum);
            }
            sum = sum / 100;
            Console.WriteLine("Ahorro anual: {0} pesos", sum);
            Console.ReadKey();
        }
    }
}
