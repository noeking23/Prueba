using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números a comparar:");
            int n = int.Parse(Console.ReadLine());

            int mayor = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un número:");
                int num = int.Parse(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }
            }

            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }
}
