using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
        const double pi = 3.14;
        double area, radio;

        Console.Write("Ingrese el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());


        area = pi * (radio * radio);


        Console.WriteLine($"EL radio delcirculo es: {area}");


        

        }
    }
}
