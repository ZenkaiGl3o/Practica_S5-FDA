using System;


namespace Practica_S5_FDA_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();
        }
        static void ejer1()
        {
            int Producto = 27, CantidadProducto, CodigoCliente;
            double Descuento1, Descuento2, PrecioSinDescuento;
            string TipoCliente;

            Console.WriteLine("Ingrese la cantidad de productos a llevar");
            Console.WriteLine("(Precio por unidad: 27)");
            Console.Write("----------> ");
            CantidadProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su código de descuento");
            Console.WriteLine("-1 (Estudiante)");
            Console.WriteLine("-2 (Empleado)");
            Console.WriteLine("-3 (Cliente Frecuente)");
            Console.Write("----> ");

            CodigoCliente = Convert.ToInt32(Console.ReadLine());

            switch (CodigoCliente)
            {
                case 1:
                    TipoCliente = "Estudiante";
                    break;
                case 2:
                    TipoCliente = "Empleado";
                    break;
                case 3:
                    TipoCliente = "ClienteFrecuente";
                    break;
                default:
                    TipoCliente = "Sindescuento";
                    break;
            }

            PrecioSinDescuento = CantidadProducto * Producto;

            if (PrecioSinDescuento >= 500)
            {
                Descuento1 = PrecioSinDescuento * 0.05;
            }
            else {
                Descuento1 = 0;
            }

            Descuento2 = PrecioSinDescuento;

            switch (CodigoCliente)
            {
                case 1: 
                    Descuento2 = Descuento1 + (PrecioSinDescuento * 0.10);
                    break;
                case 2: 
                    Descuento2 = Descuento1 + (PrecioSinDescuento * 0.15);
                    break;
                case 3: 
                    Descuento2 = Descuento1 + (PrecioSinDescuento * 0.20);
                    break;
                default:
                    break;
            }
            double PrecioFinal = Math.Round(PrecioSinDescuento - Descuento2, 2);

            Console.WriteLine("El total a pagar es: " + PrecioFinal);

            Console.ReadKey();

        }
        static void ejer2()
        {
            Console.Write("Ingrese una nota (0-20): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 20");
            }
            else
            {
                string clasificacion = "";

                if (nota >= 0 && nota <= 10)
                {
                    clasificacion = "Desaprobado";
                }
                else if (nota >= 11 && nota <= 13)
                {
                    clasificacion = "Regular";
                }
                else if (nota >= 14 && nota <= 17)
                {
                    clasificacion = "Bueno";
                }
                else if (nota >= 18 && nota <= 20)
                {
                    clasificacion = "Excelente";
                }

                Console.WriteLine($"Clasificación: {clasificacion}");

                if (nota >= 14 && nota % 2 == 0)
                {
                    Console.WriteLine("Buen desempeño con nota par");
                }

                if (nota % 2 != 0 || nota < 11)
                {
                    Console.WriteLine("Necesita reforzar");
                }

                double raiz = Math.Round(Math.Sqrt(nota), 1);
                double cubo = Math.Pow(nota, 3);

                Console.WriteLine($"Raíz cuadrada de la nota: {raiz}");
                Console.WriteLine($"Potencia al cubo de la nota: {cubo}");
            }

            Console.ReadKey();

        }

    }
}
