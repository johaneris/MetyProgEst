using System;

namespace Mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine() ??"");
            Console.Write("Ingrese el primer numero: ");
            num2 = Convert.ToInt32(Console.ReadLine() ??"");
            Console.Write("Ingrese el primer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine() ??"");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} es mayor");

            } else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} es mayor");
            }
            else
            {
                Console.WriteLine($"{num3} es mayor");

            }


        }

    }
}