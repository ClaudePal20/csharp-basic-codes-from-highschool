using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir = "Si";
            do
            {
                Console.Clear();
                //delarar variables
                string nombre, apellido, semestre, capacitacion;
                int opc;
                Console.WriteLine("MENU");
                Console.WriteLine("1.Componente basico");
                Console.WriteLine("2.Formacion para el trabajo");
                Console.Write("Ingrese la opcion deseada: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Write("Escriba su nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ahora ingrese su apellido: ");
                        apellido = Console.ReadLine();
                        Console.Write("Que semestre cursa actualmente: ");
                        semestre = Console.ReadLine();
                        Console.WriteLine("Su nombre es " + nombre + " " + apellido + " del " + semestre + " semestre ");
                        break;
                    case 2:
                        Console.Write("Escriba su nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ahora ingrese su apellido: ");
                        apellido = Console.ReadLine();
                        Console.Write("Que semestre cursa actualmente: ");
                        semestre = Console.ReadLine();
                        Console.Write("Ingrese su capacitacion: ");
                        capacitacion = Console.ReadLine();
                        Console.WriteLine("Su nombre es " + nombre + " " + apellido + " del " + semestre + " semestre de la carrera " + capacitacion);
                        break;
                }
                Console.Write("¿Desea leer el registro de otro alumno? ");
                repetir = Console.ReadLine();
            } while (repetir == "Si");
        }
    }
}
