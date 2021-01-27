using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTree
{
    class Program
    {
        static List<int[]> tests = new List<int[]>() {
            new int[] { 3, 2, 1, 6, 0, 5 },
            new int[] { 7, 5, 13, 9, 1, 6, 4 }
            };


        static void Main(string[] args)
        {
            foreach (var array in tests)
            {
                Console.WriteLine(GenerateArrayTree(array));
            }
            Console.ReadKey();
        }


        private static string GenerateArrayTree(int[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int max = array.Max();
            stringBuilder.AppendLine($"Array de entrada: {String.Join(", ", array)}");
            stringBuilder.AppendLine($"Raiz: {max}");
            stringBuilder.AppendLine($"Galhos da esquerda: {String.Join(", ", array.Where(c => Array.IndexOf(array, c) < Array.IndexOf(array, max)).OrderByDescending(i => i))}");
            stringBuilder.AppendLine($"Galhos da direita: {String.Join(", ", array.Where(c => Array.IndexOf(array, c) > Array.IndexOf(array, max)).OrderByDescending(i => i))}");
            return stringBuilder.ToString();
        }
    }
}
