using System;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double area = 0.0;

            Console.WriteLine("Entrada: ");
            double raio = double.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine("Saída: {0:f4}", area);
            Console.ReadKey();

            //Exemplo:
            //Entrada 2,00 
            //Saída 12,5664
        }
    }
}
