/*Realizar una aplicación que permita realizar la conversión de monedas DÓLAR y EURO a
PESO ARGENTINO. En primer lugar se debe solicitar el tipo de moneda origen (Dólar o Euro) y
la cantidad de la misma, luego se debe mostrar el monto correspondiente en Pesos Argentinos
y que se presione una tecla para permitir realizar una nueva conversión. Al momento de
seleccionar la moneda, también se debe brindar una opción para finalizar el programa.*/
using System;
using System.Threading;
namespace TP7_ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "",pesosArgString = ""; 
            float dolarHoy = 151.3f, euroHoy = 160.59f, pesosArgFloat=0;
            do
            {
                titular();
                Console.WriteLine("Digite la cantidad de Pesos Argentinos a convertir:");
                pesosArgString = Console.ReadLine();
                pesosArgFloat = Convert.ToSingle(pesosArgString);
                Console.WriteLine("A continuación pulse la tecla según la opción deseada:\n");
                Console.WriteLine("[D] para convertir de Peso Argentino a Dolar");
                Console.WriteLine("[E] para convertir de Peso Argentino a Euro");
                menu ();
                entrada = Console.ReadLine();
                switch (entrada)
                {
                    case "d" or "D":
                        titular();
                        Console.WriteLine("$"+pesosArgString+" son USD"+pesosArgFloat/dolarHoy+"\n");
                        menu ();
                        entrada = Console.ReadLine();
                    break;
                    case "e" or "E":
                        titular();
                        Console.WriteLine("$"+pesosArgString+" son EUR"+pesosArgFloat/euroHoy+"\n");
                        menu ();
                        entrada = Console.ReadLine();
                    break;
                }   
            }
            while (entrada == "N" || entrada== "n");
            salidaDelPrograma ();
        }
        static void titular()
        {
            string titulo = "[[[[[[[[[[[[[[[[[CONVERSIÓN DE DIVISAS]]]]]]]]]]]]]]]]]\n";
            Console.Clear();
            Console.WriteLine(titulo);
        }
        
        static void menu()
        {   
            Console.WriteLine("[N] para nueva conversión de divisas");
            Console.WriteLine("[Cualquier otra tecla para salir]");
        }
        static void salidaDelPrograma ()
        {
            for (int i = 5; i >= 0; i--)
            {
                titular();
                Console.WriteLine("Gracias por utilizar el servicio!");
                Console.WriteLine("saliendo -----> "+i);
                Thread.Sleep(400);
                Console.Clear();
            }
        }
    }
}