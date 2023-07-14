using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_3_ProgramaSueldosIf
{
    class Program
    {
        static void Main(string[] args)
        {
            float SueldoDrio = 0, SueldoSem = 0, SueldoMen = 0;
            int opc = 0; //Declaramos variables

            Console.WriteLine("Programa para calcular sueldo semanal y mensual"); //Aqui presento el programa (es un extra)
            Console.WriteLine("\nEliga el sueldo a calcular \n1. Sueldo semanal \n2. Sueldo Mensual "); 
            opc = int.Parse(Console.ReadLine()); //Leemos la opcion
            if (opc == 1) //Ponemos que sigue si ocurre el caso uno, sueldo semanal
            {
                Console.Write("\nDame tu salario diario "); //Pedimos el salario diario
                SueldoDrio = float.Parse(Console.ReadLine()); //Leemos el salario diario
                SueldoSem = SueldoDrio * 7; //Obtenemos el sueldo semanal
                Console.Write("\nTu sueldo semanal es " + SueldoSem); //Desplegamos el sueldo semanal
            }
            else if (opc == 2)   //Caso dos
            {
                Console.Write("\nDame tu salario diario ");  //Pedimos el salario diario
                SueldoDrio = float.Parse(Console.ReadLine()); //Leemos el salario diario
                SueldoMen = SueldoDrio * 30; //Obtenemos el sueldo mensual
                Console.Write("\nTu sueldo mensual es " +SueldoMen); //Desplegamos el sueldo mensual
            }
            else
            {
                Console.WriteLine("\nOpcion no valida"); //Desplegamos que la opcion no es valida
            }
            Console.ReadKey(); //Termina programa
        }
    }
}
