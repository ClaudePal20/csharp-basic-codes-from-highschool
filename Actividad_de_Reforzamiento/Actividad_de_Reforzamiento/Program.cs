using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_de_Reforzamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int nocontrol = 0, semestreopc = 0, opc = 0, nm = 0;
            string nombres = "", apellidos = "", semestre = "", capacitacion = "", nombremateria = "";
            float calif = 0, suma = 0, promedio = 0;  //Declaracion de variables
            do //Inicio do
            {
                do
                {
                    Console.WriteLine("Programa para obtener promedios");
                    Console.WriteLine("\nDame tu/s nombre/s");
                    nombres = Console.ReadLine();
                    Console.WriteLine("\nDame tu/s apellido/s");
                    apellidos = Console.ReadLine();
                    Console.WriteLine("\nDame tu numero de control");
                    nocontrol = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n¿Estás en componente básico de bachillerato o estás en bachillerato de formación para el trabajo?\n1. Componente Básico \n2. Preparación para el trabajo");
                    semestreopc = int.Parse(Console.ReadLine());
                    if (semestreopc == 1)
                    {
                        capacitacion = "No aplica";
                    }
                    else if (semestreopc == 2)
                    {
                        Console.WriteLine("¿En qué capacitación te encuentras?");
                        capacitacion = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida");
                    }
                    Console.Clear();
                } while (semestreopc > 2);
                Console.WriteLine("\n¿En qué semestre te encuentras?");
                semestre = Console.ReadLine();
                Console.WriteLine("¿Cuantas calificaciones va a promediar?");
                nm = int.Parse(Console.ReadLine());
                string[] nombresdematerias = new string[nm];
                float[] calificaciones = new float[nm];
                for (int i = 0; i < nm; i++)
                {
                    Console.WriteLine("Dame el nombre de la materia");
                    nombremateria = Console.ReadLine();
                    Console.WriteLine("Dame la calificacion de la materia");
                    calif = float.Parse(Console.ReadLine());
                    suma = suma + calif;
                    nombresdematerias[i] = nombremateria;
                    calificaciones[i] = calif;
                }
                Console.Clear();
                promedio = suma / nm;
                Console.WriteLine("No. de Control: {0}      Nombre: {1} {2}  Semestre: {3}\nCapacitacion: {4}", nocontrol, nombres, apellidos, semestre, capacitacion);
                for (int i = 0; i < nm; i++)
                {
                    nombremateria = nombresdematerias[i];
                    calif = calificaciones[i];
                    Console.WriteLine("Materia {0}: {1}", nombremateria, calif);
                }
                Console.WriteLine("El promedio es: {0}", promedio);
                Console.WriteLine("¿Quieres volver a utilizar la herramienta?\n1. Si\n.2 No");
            } while (opc == 1);
            Console.ReadKey();
        }
    }
}
