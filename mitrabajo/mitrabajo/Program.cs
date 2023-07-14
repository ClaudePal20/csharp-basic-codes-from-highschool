using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mitrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0, opc2 = 0, opc3 = 0;
            float dolar = 20, monto = 0, compra = 0, venta = 0, actualizardlr = 0, compra2 = 0;
            Console.WriteLine("Casa de cambio \n(Valor del dolar en 20 pesos mexicanos)");
            do
            {
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
                Console.WriteLine("¿Deseas realizar otro cambio de divisas? \n1. Si \n2. No");
                opc3 = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (opc3 == 1);
            Console.ReadKey();
        }
    }
}
