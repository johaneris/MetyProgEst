using Calcularnota.clases;

namespace Calcularnota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numero_input = int.Parse(input);

            Console.WriteLine(numero_input);

            //primer objeto

            Nota notita = new Nota();

            //variablees de entrada y las salidas

            //crear variables de entra
            double? nota1 = null ;
            double? nota2 = null; //todas las variables inician con un valor, asigna null para que este vacio
            double? nota3 = null;
            double? total = null;
            Console.Write("Ingrese su primera nota: ");
            nota1 = double.Parse(Console.ReadLine() ?? "");
            Console.Write("Ingrese su segunda nota: ");
            nota2 = double.Parse(Console.ReadLine() ?? ""); 
            Console.Write("Ingrese su tercer nota: ");
            nota3 = double.Parse(Console.ReadLine() ?? "");

            notita.Nota1 = nota1 ?? 0;
            notita.Nota2 = nota2 ?? 0;
            notita.Nota3 = nota3 ?? 0;

            total = notita.calcularNota();

            Console.WriteLine($"Su promedio es: {total} ");






        }
    }
}
