using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, numero = 0, multiplicacion = 0;
            while (opc == 1)
            {
                Console.WriteLine("Tabla de multiplicar del 1 al 20, introduzca un numero");
                numero = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numero; i++)
                {
                    multiplicacion = numero * i;
                    Console.WriteLine("2 x {0} = {1}", i, multiplicacion);
                }
                Console.WriteLine("¿Deseas sacar otra tabla?/n1. Si/n2. No");
                opc = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
