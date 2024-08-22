using System;


namespace Salario
{
    class Salarios
    {
        static void Main(string[] args)
        {
            string nombre, cargo;
            double salario, nuevoSalario;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine() ??"";
            Console.Write("Ingrese su cargo: ");
            cargo = Console.ReadLine() ?? "";
            Console.Write("Ingrese su salario: ");
            salario = Convert.ToDouble(Console.ReadLine() ??"");


            nuevoSalario = salario + (0.10 * salario);

            Console.WriteLine($"El salario de {nombre}, con el cargo de {cargo}, es: {nuevoSalario}");




        }
    }
}