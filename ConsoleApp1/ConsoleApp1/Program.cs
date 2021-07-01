using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int total = 0;
            char op = 's';

            while (op == 's')
            {
                Console.WriteLine("Suma");
                Console.Write("Ingrese el primer valor: ");

                try
                {
                    val1 = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Error, formato incorrecto");
                    Console.Write("Ingrese el primer valor: ");
                    val1 = int.Parse(Console.ReadLine());
                }


                Console.Write("Ingrese el segundo valor: ");

                try
                {
                    val2 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error, formato incorrecto");
                    Console.Write("Ingrese el segundo valor: ");
                    val2 = int.Parse(Console.ReadLine());
                }

                total = val1 + val2;

                Console.WriteLine("La suma es: " + total);
                Console.ReadKey();


                {
                    Console.WriteLine("Resta");
                    Console.Write("Ingrese el primer valor: ");

                    try
                    {
                        val1 = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el primer valor: ");
                        val1 = int.Parse(Console.ReadLine());
                    }


                    Console.Write("Ingrese el segundo valor: ");

                    try
                    {
                        val2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el segundo valor: ");
                        val2 = int.Parse(Console.ReadLine());
                    }

                    total = val1 - val2;

                    Console.WriteLine("La resta es: " + total);
                    Console.ReadKey();

                }

                {
                    Console.WriteLine("Multiplicación");
                    Console.Write("Ingrese el primer valor: ");

                    try
                    {
                        val1 = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el primer valor: ");
                        val1 = int.Parse(Console.ReadLine());
                    }


                    Console.Write("Ingrese el segundo valor: ");

                    try
                    {
                        val2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el segundo valor: ");
                        val2 = int.Parse(Console.ReadLine());
                    }

                    total = val1 * val2;

                    Console.WriteLine("La Multiplicación es: " + total);
                    Console.ReadKey();

                }
                {
                    Console.WriteLine("División");
                    Console.Write("Ingrese el primer valor: ");

                    try
                    {
                        val1 = int.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el primer valor: ");
                        val1 = int.Parse(Console.ReadLine());
                    }


                    Console.Write("Ingrese el segundo valor: ");

                    try
                    {
                        val2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error, formato incorrecto");
                        Console.Write("Ingrese el segundo valor: ");
                        val2 = int.Parse(Console.ReadLine());
                    }

                    total = val1 / val2;

                    Console.WriteLine("La división es: " + total);
                    Console.ReadKey();

                    Console.WriteLine("Desea realizar de nuevo las operaciones ['S/N']");
                    op = char.Parse(Console.ReadLine());
                    Console.Clear();

                }
               
            }
            Console.WriteLine("Fin de operaciones");
            Console.ReadKey();

        }
    }
}
