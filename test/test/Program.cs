using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Tabla__For_
{
    class Program
    {
        static void Main(string[] args)
        {
namespace Programa_Tabla__For_
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Declarar variables
                int tabla = 0, opc = 0;
                string nombre = "";
                //Leer variables
                Console.Write("Para empezar el programa, introduzca su nombre: ");
                nombre = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ahora empezaremos el programa " + nombre);
                    Console.Write("¿Que tabla le gustaria calcular? ");
                    tabla = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine(tabla + " X " + i + " = " + (i * tabla));
                    }
                    Console.WriteLine("¿Desea sacar el valor de alguna otra tabla? \n 1.Si \n 2.No");
                    Console.Write("Introduzca la opcion seleccionada: ");
                    opc = int.Parse(Console.ReadLine());
                    if (opc == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Write("El programa procedera a cerrarse");
                    }
                } while (opc == 1);
                Console.ReadKey();
            }
        }
    }
}
    }
}
