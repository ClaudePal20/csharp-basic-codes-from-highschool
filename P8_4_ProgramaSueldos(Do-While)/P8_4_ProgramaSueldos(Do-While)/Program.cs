using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_4_ProgramaSueldos_Do_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            float SueldoDrio = 0, SueldoSem = 0, SueldoMen = 0;
            int opc = 0, opc2 = 0; //Declaramos variables

            Console.WriteLine("Programa para calcular sueldo semanal y mensual\n"); //Aqui presento el programa (es un extra)
            do
            {
                Console.WriteLine("Eliga el sueldo a calcular \n1. Sueldo semanal \n2. Sueldo Mensual ");
                opc = int.Parse(Console.ReadLine()); //Leemos la opcion
                Console.Write("\nDame tu salario diario ");  //Pedimos el salario diario
                SueldoDrio = float.Parse(Console.ReadLine()); //Leemos el salario diario
                if (opc == 1) //Ponemos que sigue si ocurre el caso uno, sueldo semanal
                {
                    SueldoSem = SueldoDrio * 7; //Obtenemos el sueldo semanal
                    Console.Write("\nTu sueldo semanal es " + SueldoSem); //Desplegamos el sueldo semanal
                }
                else if (opc == 2)   //Caso dos
                {
                    SueldoMen = SueldoDrio * 30; //Obtenemos el sueldo mensual
                    Console.Write("\nTu sueldo mensual es " + SueldoMen); //Desplegamos el sueldo mensual
                }
                else
                {
                    Console.WriteLine("\nOpcion no valida"); //Desplegamos que la opcion no es valida
                }
                Console.WriteLine("\n¿Deseas calcular otro sueldo? \n1. Si \n2. No\n");
                opc2 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (opc2 == 1);
            Console.ReadKey(); //Termina programa
        }
    }
}
