using System;
using System.Collections;
using System.Collections.Generic;

namespace _Marolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FIRST_5_ELEMENTS = 5;
            int LAST_5_ELEMENTS = 5;

            var enteros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var primeros = new List<int>();
            var ultimos = new List<int>();

            if (enteros.Count > FIRST_5_ELEMENTS)
            {
                primeros = enteros.GetRange(0, FIRST_5_ELEMENTS);
            }

            if (enteros.Count > LAST_5_ELEMENTS)
            {
                ultimos = enteros.GetRange(enteros.Count - LAST_5_ELEMENTS, LAST_5_ELEMENTS);

            }


            Console.WriteLine($"Primeros 5 elementos: {string.Join(",", primeros)}");
            Console.WriteLine($"Primeros 5 elementos: {string.Join(",", ultimos)}");
        }
    }
}
