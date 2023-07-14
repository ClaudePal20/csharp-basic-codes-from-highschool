using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Reforzamiento_PalacioMartinez
{
    class Program
    {
        static void Main(string[] args)
        {
            int semestreopc = 0, opc2 = 0, nm = 0, nocontrol = 0; 
            float calif = 0, suma = 0, promedio = 0;
            string nombremateria = "", nombrecapacitacion = "", semestretexto = "", nombresalumno = "", apellidosalumno = "";
            //Hecho por Claudio Ratboi
            do
            {
                //Pedimos datos personales
                do
                {
                    Console.Clear();
                    Console.WriteLine("Programa para hacer una boleta");
                    Console.WriteLine("\nDame tu/s nombre/s");
                    nombresalumno = Console.ReadLine();
                    Console.WriteLine("\nDame tus apellidos");
                    apellidosalumno = Console.ReadLine();
                    Console.WriteLine("\nDame tu numero de control (Solo digitos)");
                    nocontrol = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n¿En qué nivel educativo de bachillerato te encuentras?\n1. Entre 1er y 2do semestre\n2. Entre 3er y 6to semestre");
                    semestreopc = int.Parse(Console.ReadLine());
                    if (semestreopc >2)
                    {
                        semestreopc = 3;
                    }
                    if (semestreopc <1)
                    {
                        semestreopc = 3;
                    }
                } while (semestreopc == 3);

                //Determinamos el curso del programa, 1er a 2do semestre la capacitacion es igual a 'no aplica', 3er a 6to semestre la capacitacion la escribe el usuario
                Console.WriteLine("\nEscribe exactamente en que semestre estas");  
                semestretexto = Console.ReadLine();
                if (semestreopc == 1)
                {
                    nombrecapacitacion = "No aplica";
                }
                else if (semestreopc == 2)
                {
                    Console.WriteLine("\nDame el nombre de tu capacitación");
                    nombrecapacitacion = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opcion no valida, presione ENTER");
                }

                //Pedimos el numero de materias a procesar y almacenar
                Console.WriteLine("\nIngresa el numero de materias a promediar y mostrar"); 
                nm = int.Parse(Console.ReadLine());
                Console.Clear();//Limpia de pantalla

                //Procesamos y almacenamos las materias y las calificaciones
                string[] materias = new string[nm];
                float[] calificaciones = new float[nm];
                for (int i = 0; i < nm; i++)   
                {
                    Console.WriteLine("Dame el nombre de la materia no. {0}", i + 1);
                    nombremateria = Console.ReadLine();
                    Console.WriteLine("\nDame la calificacion de la materia no. {0}", i + 1);
                    calif = float.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    suma = suma + calif;
                    materias[i] = nombremateria;
                    calificaciones[i] = calif;
                }
                Console.Clear();//Limpia de pantalla
                promedio = suma / nm;//Promedio

                //Desplegamos la tabla, comenzando con el encabezado
                Console.WriteLine("No. de Control: {0}     Nombre completo: {1} {2}     " + 
                "Semestre: {3}\n\nCapacitacion: {4}\n", nocontrol, nombresalumno, apellidosalumno, semestretexto, nombrecapacitacion); //Encabezado

                //Desplegamos las materias y las calificaciones introducidas, parte de la tabla.
                for (int i = 0; i < nm; i++)
                {
                    nombremateria = materias[i];
                    calif = calificaciones[i];
                    Console.WriteLine("Materia {0}: {1}", materias[i], calificaciones[i]);
                }

                //Desplegamos el promedio
                Console.WriteLine("\nPromedio semestral: {0}\n", promedio);

                //Preguntamos si desea repetir la herramienta
                do
                {
                    Console.WriteLine("¿Deseas volver a utilizar la herramienta?\n1. Si\n2. No");
                    opc2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opc2 > 2)
                    {
                        opc2 = 3;
                    }
                    else if (opc2 < 1)
                    {
                        opc2 = 3;
                    }
                }
                while (opc2 == 3);
            } while (opc2 == 1);
            Console.Write("Presiona ENTER para cerrar el programa");
            Console.ReadKey(); //Termina programa
        }
    }
}
