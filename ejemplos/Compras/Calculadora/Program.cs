using Calculadora.clases;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear el primer objeto



            

            //hacer las variables de entrada 


        }

        public void menu()
        {

            
            double numero2 = -1;
            double area = -1;
            double radio = -1;
            int option;
            do
            {
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1. Calcular el cubo de un numero");
                Console.WriteLine("2. Calcular la riz cuadrada de un numero");
                Console.WriteLine("3. Calcular el area de un circulo");
                option = int.Parse(Console.ReadLine() ?? "");

                switch(option)
                {
                    case 1:
                        Console.WriteLine
                }
            }
        }


        public void raiz()
        {
            Calcular calculadora = new Calcular();
            double numero1 = -1;
            Console.WriteLine("Ingrese el numero: ");
            numero1 = double.Parse(Console.ReadLine() ?? "");
            
            calculadora.Numero1 = numero1;


        }

    }
}
 