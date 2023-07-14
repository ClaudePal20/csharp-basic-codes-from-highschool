using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicar_10x10
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0, cantnum = 0;
            Console.WriteLine("Programa para obtener tablas de multiplicar");
            Console.Write("Indique hasta que tabla quiere desplegar: ");
            cantnum = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            cantnum = cantnum + 1;
            int[,] numeros = new int[cantnum, 11]; 
            //Automatización de las tablas
            for (int i = 1; i < cantnum; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    resultado = i * j;
                    numeros[i, j] = resultado;
                }
            }
            //Despliegue visual de las tablas
            for (int i = 1; i < cantnum; i++)
            {
                Console.WriteLine("Tabla del {0}", i);
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine("{0} x {1}: {2}", i, j, numeros[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
