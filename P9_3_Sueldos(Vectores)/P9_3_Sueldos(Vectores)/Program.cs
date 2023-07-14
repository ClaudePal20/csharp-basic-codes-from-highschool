using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_3_Sueldos_Vectores_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            float sueldomensual = 0, sueldoanual = 0;
            string nombre = "", puesto = "";
            float[] sueldomensual2 = new float[12];
            do
            {
                Console.WriteLine("Dame tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Escribe tu puesto");
                puesto = Console.ReadLine();
                for (int i = 0; i <= 11; i++)
                {
                    Console.WriteLine("Digita tu sueldo mensual del mes: {0}", i+1);
                    sueldomensual = float.Parse(Console.ReadLine());
                    sueldoanual = sueldoanual + sueldomensual;
                    sueldomensual2[i] = sueldomensual;
                }
                Console.Clear();
                for (int i = 0; i <= 11; i++)
                {
                    sueldomensual = sueldomensual2[i];
                    Console.WriteLine("El sueldo mensual del mes {0} es {1}", i+1, sueldomensual);
                }
                Console.WriteLine("\nTu nombre es {0} con el puesto de {1} y tu sueldo anual es de: {2}\n", nombre, puesto, sueldoanual);
                do
                {
                    Console.WriteLine("¿Deseas volver a utilizar la herramienta?\n1.Si\n2.No");
                    opc = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opc < 1)
                    {
                        opc = 3;
                    }
                    if (opc > 2)
                    {
                        opc = 3;
                    }
                } while (opc == 3);
                Console.Clear();
            } while (opc == 1);
            Console.WriteLine("Presiona ENTER para salir del programa");
            Console.ReadKey();
        }
    }
}
