using System;

namespace suma
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1, num2, total;
            Console.Write("Ingrese el primer numero: ");
            //pq cuando el usuario ingresa un string 
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2;

            //Console.WriteLine("La suma es: " + total);
            Console.WriteLine("La suma entre {0} y {1} es {2}", num1, num2, total);
        }

    }
}