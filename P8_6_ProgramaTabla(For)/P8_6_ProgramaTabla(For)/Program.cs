using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_6_ProgramaTabla_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla = 0, res = 0, num = 1;
            Console.WriteLine("¿Qué tabla desea calcular?");
            tabla = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTabla del {0}\n",num);
            for (num = 1; num <= 10; num++)
            {
                res = num * tabla;
                Console.WriteLine(num + "x" + tabla + "=" + res);
            }
            Console.ReadKey();
        }
    }
}
