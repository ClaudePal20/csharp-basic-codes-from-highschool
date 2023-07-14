using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programamultikit__dab
{
    class Program
    {
        static void Main(string[] args)
        {
            int numcal = 0, opc = 0, opc2 = 0, opc3 = 0, opc4 = 0, ciclo = 0;
            float cal = 0, suma = 0, promedio = 0, SueldoDrio = 0, SueldoSem = 0, SueldoMen = 0, num1 = 0, num2 = 0, tabla = 0, num = 0, res = 0,
                resta = 0, div = 0, multi = 0, dolar = 20, monto = 0, compra = 0, venta = 0, actualizardlr = 0, compra2 = 0; //Variables de todos los programas
            do
            {
                Console.Clear();
                Console.WriteLine("Programa multifuncional, made by ~obomaster~");
                Console.Write("\nElige tu herramienta.\n1.Calculadora de sueldos" +
                    "\n2.Calculadora de promedios\n3.Calculadora básica\n4.Tabla de multiplicar\n5.Casa de cambio\n"); //Preguntar herramienta a usar
                opc3 = int.Parse(Console.ReadLine()); //Leer decision
                Console.Clear();
                if (opc3 == 1)
                {
                    do
                    {
                        Console.WriteLine("¿Qué sueldo deseas calcular? \n1.Sueldo semanal \n2.Sueldo mensual");
                        opc = int.Parse(Console.ReadLine());
                        Console.Write("\nDame tu salario diario "); //Pedimos el salario diario
                        SueldoDrio = float.Parse(Console.ReadLine()); //Leemos el salario diario
                        switch (opc)
                        {
                            case 1:
                                {
                                    SueldoSem = SueldoDrio * 7; //Obtenemos el sueldo semanal
                                    Console.Write("\nTu sueldo semanal es " + SueldoSem); //Desplegamos el sueldo semanal
                                    break;
                                }
                            case 2:
                                {
                                    SueldoMen = SueldoDrio * 30; //Obt  enemos el sueldo mensual
                                    Console.Write("\nTu sueldo mensual es " + SueldoMen); //Desplegamos el sueldo mensual
                                    break;
                                }
                            default:
                                {
                                    Console.Write("\nOpción no valida");
                                    break;
                                }
                        }
                        Console.WriteLine("\n¿Deseas obtener otro salario?\n1.Si \n2.No");
                        opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    while (opc == 1);
                } //Calculadora de sueldos
                else if (opc3 == 2)
                {
                    Console.WriteLine("Programa iterativo para obtener promedios\n");
                    do
                    {
                        Console.WriteLine("¿Cuántas calificaciones quieres promediar? (Digitalo)\n");

                        numcal = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame las calificaciones de manera consecuente\n");
                        for (ciclo = 0; ciclo < numcal; ciclo++)
                        {
                            cal = float.Parse(Console.ReadLine());
                            suma = suma + cal;
                        }
                        promedio = suma / numcal;
                        Console.WriteLine("\nTu promedio es de {0}\n¿Deseas obtener otro promedio?\n1.Si \n2.No", promedio);
                        opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    while (opc == 1);
                } //Calculadora de promedios
                else if (opc3 == 3)
                {
                    do
                    {
                        Console.WriteLine("Elige la operacion a realizar \n1. Suma \n2. Resta \n3. Division \n4. Multiplicacion\n ");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el primer numero\n ");
                        num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nDame el segundo numero\n ");
                        num2 = float.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            suma = num1 + num2;
                            Console.WriteLine("\nTu resultado de la suma es de " + suma);
                        }
                        else if (opc == 2)
                        {
                            resta = num1 - num2;
                            Console.WriteLine("\nTu resultado de la resta es de " + resta);
                        }
                        else if (opc == 3)
                        {
                            div = num1 / num2;
                            Console.WriteLine("\nTu resultado de la division es de " + div);
                        }
                        else if (opc == 4)
                        {
                            multi = num1 * num2;
                            Console.WriteLine("\nTu resultado de la multiplicación es de " + multi);
                        }
                        Console.WriteLine("\n¿Deseas realizar otra operación? \n1. Si \n2. No");
                        opc2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (opc2 == 1);
                } //Calculadora basica
                else if (opc3 == 4)
                {
                    Console.WriteLine("Digita el número de la tabla que quieres obtener que irá del 1 al 10.");
                    tabla = float.Parse(Console.ReadLine());
                    Console.WriteLine("\nTabla del {0}\n", num);
                    for (num = 1; num <= 10; num++)
                    {
                        res = num * tabla;
                        Console.WriteLine(num + "x" + tabla + "=" + res);
                    }
                    Console.WriteLine("¿Deseas obtener otra tabla?\n1.Si\n2.No");
                    opc2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                } //Tabla de multiplicar
                else if (opc3 == 5)
                {
                    do
                    {
                        Console.WriteLine("Casa de cambio \n(Valor del dolar en 20 pesos mexicanos)");
                        Console.WriteLine("\nElige tu opcion a realizar\n1.Compra \n2.Venta \n3.Actualizar dolar\n ");
                        opc = int.Parse(Console.ReadLine());
                        switch (opc)
                        {
                            case 1:
                                {
                                    Console.WriteLine("\n¿Cuántos pesos vas a convertir?\n ");
                                    monto = float.Parse(Console.ReadLine());
                                    compra = monto / dolar;
                                    Console.WriteLine("\nTu compra ha sido de {0} dolares y vendiste {1} pesos", compra, monto);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("\nEscribe el monto de dolares a vender\n ");
                                    monto = float.Parse(Console.ReadLine());
                                    venta = monto * dolar;
                                    Console.WriteLine("\nHas vendido {0} dolares y compraste {1} pesos ", dolar, monto);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("\nEscribe el nuevo valor del dolar\n ");
                                    actualizardlr = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Elige tu opcion a realizar \n1.Compra \n2.Venta");
                                    opc2 = int.Parse(Console.ReadLine());
                                    if (opc2 == 1)
                                    {
                                        Console.WriteLine("\n¿Cuántos pesos vas a convertir?\n ");
                                        monto = float.Parse(Console.ReadLine());
                                        compra2 = monto / actualizardlr;
                                        Console.WriteLine("\nHas comprado {0} dolares y vendiste {1} pesos ", compra2, monto);
                                    }
                                    else if (opc2 == 2)
                                    {
                                        Console.WriteLine("\nEscribe el monto de dolares a vender ");
                                        monto = float.Parse(Console.ReadLine());
                                        venta = monto * actualizardlr;
                                        Console.WriteLine("\nHas vendido {0} dolares y compraste {1} pesos ", venta, monto);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nOpcion no valida");
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("\nOpcion no valida");
                                    break;
                                }

                        }
                        Console.WriteLine("¿Deseas realizar otra operación? \n1.Si\n2.No");
                        opc2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    while (opc2 == 1);
                } //Casa de cambio
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
                Console.WriteLine("¿Deseas usar otra herramienta?\n1.Si\n2.No"); //Pedir si decide usar la multiherramienta de nuevo
                opc4 = int.Parse(Console.ReadLine()); //Leer decision
                Console.Clear();
            }
            while (opc4 == 1);
            Console.WriteLine("Presiona ENTER para salir");
            Console.ReadKey(); //Termina programa
        }
    }
}
