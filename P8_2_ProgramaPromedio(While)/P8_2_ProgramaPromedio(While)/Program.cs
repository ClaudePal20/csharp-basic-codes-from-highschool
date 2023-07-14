using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_2_ProgramaPromedio_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            float cal = 0, suma = 0, promedio = 0;
            int numcal = 0, opc = 0, ciclo = 0;
            Console.WriteLine("Programa iterativo para obtener promedios\n");
            Console.WriteLine("¿Cuántas calificaciones quieres promediar?\n");
            numcal = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame las calificaciones de manera consecuente\n");
            for (ciclo = 0; ciclo < numcal; ciclo++)
            {
                cal = float.Parse(Console.ReadLine());
                suma = suma + cal;
            }
            promedio = suma / numcal;
            Console.WriteLine("\nTu promedio es de {0}\n¿Deseas obtener otro promedio?\n1.Si\n2.No", promedio);

            opc = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }

    }
}
