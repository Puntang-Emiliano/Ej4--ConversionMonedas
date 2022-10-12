using System;

namespace Ej4_Conversion_De_Monedas
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            string opcion = "";


            while (opcion != "s" && opcion != "S")
            {

                System.Console.WriteLine("BIENBENIDO AL SISTEMA DE CONVERSIÓN DE MONEDAS");
                System.Console.WriteLine("A CONTINUACION INGRESE LA OPCION DE LA MONEDA QUE QUIERA CONVERTIR");
                System.Console.WriteLine("D ----- DOLARES A PESOS -----");
                System.Console.WriteLine("E ----- EUROS A PESOS -----");
                System.Console.WriteLine("S ----- PARA SALIR DEL PROGRAMA -----");

                opcion = Console.ReadLine();
                Console.Clear();



                switch (opcion)
                {
                    case "d" or "D":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("El monto ingresado en Dolares equivala a pesos:  {0}", cambioDolar());
                        Console.ReadKey();
                        break;


                    case "e" or "E":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("El monto ingresado en Euros equivala a pesos:  {0}", cambioEuro());
                        Console.ReadKey();
                        break;

                    case "S" or "s":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine("Eligio Salir ");
                        Console.ReadKey();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();

            }







        }


        static float cambioDolar()
        {
            float cambioDolar = 270, Peso;
            float dolar = 0.0f;
            Console.WriteLine("ingrese el monto a convertir");
            dolar = Convert.ToSingle(Console.ReadLine());
            return Peso = dolar * cambioDolar;
        }

        static float cambioEuro()
        {
            float cambioEuro = 260, Peso;
            float euro = 0.0f;
            Console.WriteLine("ingrese el monto a convertir");
            euro = Convert.ToSingle(Console.ReadLine());
            return Peso = euro * cambioEuro;
        }





    }
}

