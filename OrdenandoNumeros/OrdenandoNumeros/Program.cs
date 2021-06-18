using System;

namespace OrdenandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int numero;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Informe o {i}º número");
                numero = int.Parse(Console.ReadLine());
                array[i] = numero;
            }

            Console.WriteLine("Array ordenado");

            Array.Sort(array);

            foreach (int value in array) Console.WriteLine("[" + value + "]");

            Console.ReadLine();

        }
    }
}
