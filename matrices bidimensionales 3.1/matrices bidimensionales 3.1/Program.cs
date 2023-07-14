using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices_bidimensionales_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc2 = 0, noal = 0, alumno = 0, numcal = 0;
            float calif = 0, sum = 0, promedio = 0;
            string nombre = "";
            do
            {
                Console.WriteLine("Introduce el numero de estudiantes");
                noal = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el numero de calificaciones");
                numcal = int.Parse(Console.ReadLine());
                Console.Clear();
                float[,]califs = new float[noal, numcal];
                string[] nombres = new string[noal];
                float[] promedios = new float[noal];
                for (int i = 0; i < noal; i++) 
                {
                    //Alumno, conteo
                    Console.WriteLine("Introduce el nombre del alumno no. {0}:", i + 1); 
                    nombre = Console.ReadLine();
                    nombres[i] = nombre;
                    Console.Clear();
                    Console.WriteLine("Introduce las calificaciones del estudiante");
                    for (int j = 0; j<numcal; j++) 
                    {
                        //Calificaciones del alumno, conteo
                        Console.Write("Calif {0}:", j + 1);
                        calif = float.Parse(Console.ReadLine());
                        sum = sum + calif;
                        califs[i, j] = calif;
                    }
                    promedio = sum / numcal;
                    promedios[i] = promedio;
                    sum = 0;
                    Console.Clear();
                }
                Console.Clear();
                do 
                {
                    Console.WriteLine("Elige el estudiante a revisar");
                    for (int i = 0; i < noal; i++) 
                    {
                        nombre = nombres[i];
                        Console.WriteLine("{0}. {1}", i + 1, nombres[i]);
                    }
                    alumno = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("{0}", nombres[alumno-1]);
                    for (int i = 0; i < numcal; i++)
                    {
                        Console.WriteLine("Calif {0}: {1}", i + 1, califs[alumno - 1, i]);
                    }
                    Console.WriteLine("Promedio: {0}", promedios[alumno-1]);
                    Console.WriteLine("\n¿Deseas volver a revisar otros datos?\n1. Si 2. No");
                    opc2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (opc2 == 1);
                Console.WriteLine("¿Desea registrar otros alumnos?\n1. Si 2. No");
                opc = int.Parse(Console.ReadLine());
            }
            while (opc == 1);
            Console.WriteLine("Presione ENTER para abandonar el programa");
            Console.ReadKey();
        }
    }
}
