using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");

            //crear nuestro primer objeto

            Factura fact = new Factura();

            //crear variables de entra
            int? numero = null;
            string? producto = null; //todas las variables inician con un valor, asigna null para que este vacio
            double precio = 0, monto;
            int cantidad = 0;
            Console.Write("Producto: ");
            producto = Console.ReadLine();
            Console.Write("Precio: "); //para espacio basicamente
            precio = double.Parse(Console.ReadLine() ?? ""); // es lo mismo que el convert, metodo para convertir 
            Console.Write("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine() ?? "");

            fact.Producto = producto;
            fact.Precio = precio;
            fact.Cantidad = cantidad;


            monto = fact.calcularMonto();





            Console.WriteLine($"{producto}"); //intercola
            Console.WriteLine($"{precio}"); //intercola
            Console.WriteLine($"{cantidad}"); //intercola
            Console.WriteLine($"{monto}"); //intercola    
                                                          
        }                                                 
    }                                                     
}                                                         
