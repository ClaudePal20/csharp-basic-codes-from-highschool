using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_bidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, numpers = 0;
            float sueldosem = 0, sueldomensual = 0;
            string nombre = "";
            do
            {
                Console.WriteLine("Introduce la cantidad de personal");
                numpers = int.Parse(Console.ReadLine());
                string[] nombrespersonal = new string[numpers];
                float[,] sueldossemanales = new float[numpers,4];
                float[] sueldosmensuales = new float[numpers];
                for (int i = 0; i < numpers; i++) //Almacenamos datos
                {
                    Console.WriteLine("Dame el nombre del personal no {0}", i+1);
                    nombre = Console.ReadLine();
                    nombrespersonal[i] = nombre;
                    for (int j = 0; j < 4; j++) 
                    {
                        Console.WriteLine("Introduce el sueldo semanal no. {0}", j + 1);
                        sueldosem = float.Parse(Console.ReadLine());
                        sueldossemanales[i,j] = sueldosem;
                        sueldomensual = sueldomensual + sueldosem;
                    }
                    sueldosmensuales[i] = sueldomensual;
                    sueldomensual = 0;
                    Console.Clear();
                }
                for (int i = 0; i < numpers; i++) //Desplegamos datos
                {
                    nombre = nombrespersonal[i];
                    Console.WriteLine("Nombre: {0}", nombrespersonal[i]);
                    for (int j = 0; j < 4; j++)
                    {
                        sueldosem = sueldossemanales[i, j];
                        Console.WriteLine("Sueldo de la semana {0}: {1}$", j+1, sueldossemanales[i,j]);
                    }
                    sueldomensual = sueldosmensuales[i];
                    Console.WriteLine("Sueldo mensual: {0}\n", sueldosmensuales[i]);
                }
                Console.WriteLine("¿Desea volver a utilizar la herramienta?\n1. Si 2. No");
                opc = int.Parse(Console.ReadLine());
            } while (opc == 1);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadKey();
        }
    }
}
