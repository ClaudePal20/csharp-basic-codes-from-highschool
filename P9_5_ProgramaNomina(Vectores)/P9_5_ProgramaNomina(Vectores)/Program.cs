using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_5_ProgramaNomina_Vectores_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombres = "", departamento = "";
            int NE = 0, tipodesueldo2 = 0, opc = 0;
            float salariodrio = 0;
            do
            {
                Console.WriteLine("Calculadora de nómina\n\nDeme el nombre del departamento:");
                departamento = Console.ReadLine();
                Console.Write("\nDigite el numero de empleados:");
                NE = int.Parse(Console.ReadLine());
                Console.Clear();
                string[] nombresdeemp = new string[NE];
                float[] salario = new float[NE];
                int[] tipodesueldo = new int[NE];
                Console.Clear();
                for (int i = 0; i < NE; i++)
                {
                    Console.WriteLine("Deme el nombre del empleado no. {0}", i + 1);
                    nombres = Console.ReadLine();
                    nombresdeemp[i] = nombres;
                    Console.Write("\nDeme el salario diario del empleado: ");
                    salariodrio = float.Parse(Console.ReadLine());
                    Console.Write("\n¿Cuál es el tipo de sueldo del empleado? (Escríbalo)\n1.Quincenal\n2.Semanal");
                    tipodesueldo2 = int.Parse(Console.ReadLine());
                    tipodesueldo[i] = tipodesueldo2;
                    if (tipodesueldo2 == 1)
                    {
                     salariodrio = salariodrio * 15;
                     salario[i] = salariodrio;
                    }
                    else if (tipodesueldo2 == 2)
                    {
                     salariodrio = salariodrio * 7;
                     salario[i] = salariodrio;
                    }
                }
                Console.Clear();
                Console.WriteLine("Departamento: {0}\n", departamento);
                for (int i = 0; i < NE; i++)
                {
                    tipodesueldo2 = tipodesueldo[i];
                    if (tipodesueldo2 == 1)
                    {
                        Console.WriteLine("El empleado {0}, tiene un sueldo quincenal de {1}", nombresdeemp[i], salario[i]);
                    }
                    else if (tipodesueldo2 == 2)
                    {
                        Console.WriteLine("El empleado {0}, tiene un sueldo semanal de {1}", nombresdeemp[i], salario[i]);
                    }
                }
                Console.WriteLine("\n¿Desea volver a usar la herramienta?\n1. Si \n2. No");
                opc = int.Parse(Console.ReadLine());
            } while (opc == 1);
            Console.WriteLine("Presiona ENTER para salir del programa");
            Console.ReadKey();
        }
    }
}
