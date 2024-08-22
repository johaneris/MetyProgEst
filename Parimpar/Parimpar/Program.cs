using System;

namespace parImpar
{
    class Program
    {

        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine() ??"");

            if(numero % 2 == 0)
            {
                Console.WriteLine("Es un numero Par :33");
            }
            else
            {
                Console.WriteLine("Es un numero impar :(");


            }
        }

    }
}
