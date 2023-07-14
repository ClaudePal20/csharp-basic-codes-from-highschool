using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices_bidimensionales_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, numalum = 0, nm = 0;
            string nombre = "", nombremateria = "";
            float suma = 0, suma2 = 0, calif = 0, promedio = 0, progrup = 0;
            do
            {
                //Divido el programa en: determinar longitud del almacenamiento de datos, introduccion de datos y despliegue de datos

                //Introduccion de datos
                Console.WriteLine("Programa para desplegar boletas de alumnos, " +
                "segun cantidad de materias, calificaciones y de alumnos");
                Console.Write("\nIngrese la cantidad de alumnos a evaluar: "); //Cantidad de alumnos a procesar
                numalum = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el numero de materias a evaluar: "); //Cantidad de materias a procesar
                nm = int.Parse(Console.ReadLine());

                string [] nombres = new string[numalum]; //Vector de nombres de los alumnos 
                string[] nombresmaterias = new string[nm]; //Vector de nombres de las materias
                float[,] calificaciones = new float[numalum, nm]; //Matriz para introducir las calificaciones de las materias
                float[] promedios = new float[numalum]; //Vector para almacenar los promedios de cada alumno
                Console.Clear();

                //Iteracion para introducir nombres de los alumnos
                Console.WriteLine("Introduccion de nombres de alumnos");
                for (int i = 0; i < numalum; i++) 
                {
                    Console.WriteLine("\nIngrese el nombre del alumno no. {0}", i+1);
                    nombre = Console.ReadLine();
                    nombres[i] = nombre;
                } 
                
                //Iteracion para ingresar nombres de materias
                Console.Clear();
                Console.WriteLine("Introduccion de nombres de materias");
                for (int i = 0; i < nm; i++) 
                {
                    Console.WriteLine("\nEscribe el nombre de la materia no. {0}", i + 1);
                    nombremateria = Console.ReadLine();
                    nombresmaterias[i] = nombremateria;
                }  
                
                Console.Clear();
                for (int i = 0; i < numalum; i++) 
                {
                    nombre = nombres[i];
                    Console.WriteLine("Calificaciones de: {0}", nombres[i]);
                    //Iteracion para ingresar las calificaciones y realizar un promedio de cada alumno.
                    for (int j = 0; j < nm; j++) 
                    {
                        nombre = nombresmaterias[j];
                        Console.WriteLine("\nDame la calificación de la materia de {0}:", nombresmaterias[j]);
                        calif = float.Parse(Console.ReadLine());
                        calificaciones[i, j] = calif;
                        suma = suma + calif;
                    }
                    promedio = suma / nm;
                    suma2 = suma2 + promedio;
                    suma = 0;
                    promedios[i] = promedio;
                    Console.Clear();
                } 
                
                Console.Clear();
                progrup = suma2 / numalum; //Promedio grupal
                
                
                //Despliege final de datos
                Console.WriteLine("Boletas finales"); //Encabezado
                for (int i = 0; i < numalum; i++)
                {
                    nombre = nombres[i];
                    Console.WriteLine("\nCalificaciones de: {0}", nombres[i]); //Nombre del alumno
                    for (int j = 0; j < nm; j++) //Iteracion para desplegar las calificaciones del alumno
                    {

                        nombremateria = nombresmaterias[j];
                        calif = calificaciones[i, j];
                        Console.WriteLine("Calificacion de la materia "+"{0}"+": {1}", nombresmaterias[j], calificaciones[i, j]);
                    }
                    Console.WriteLine("Promedio: {0}", promedios [i]); //Promedio del alumno
                }
                Console.WriteLine("\nPromedio de la boleta: {0}", progrup);
                Console.WriteLine("\n¿Deseas volver a utilizar la herramienta?\n1.Si 2.No");
                opc = int.Parse(Console.ReadLine());
            } while (opc == 1);
            Console.Write("\nPresione ENTER para abandonar el programa");
            Console.ReadKey();
        }
    }
}
