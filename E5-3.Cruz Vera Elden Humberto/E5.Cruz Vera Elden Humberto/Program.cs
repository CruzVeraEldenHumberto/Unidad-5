using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
            int[] arr2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] arr3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] arr4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] arr5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };
            Console.WriteLine("Arreglo original : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Sort(arr);
            Console.WriteLine("\nArreglo ordenado : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");


            Console.WriteLine("\nArreglo original : ");
            foreach (var item in arr2)
            {
                Console.Write(" " + item);
            }

            Sort(arr2);
            Console.WriteLine("\nArreglo ordenado : ");
            foreach (var item in arr2)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");


            Console.WriteLine("\nArreglo original : ");
            foreach (var item in arr3)
            {
                Console.Write(" " + item);
            }

            Sort(arr3);
            Console.WriteLine("\nArreglo ordenado : ");
            foreach (var item in arr3)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");


            Console.WriteLine("\nArreglo original : ");
            foreach (var item in arr4)
            {
                Console.Write(" " + item);
            }

            Sort(arr4);
            Console.WriteLine("\nArreglo ordenado : ");
            foreach (var item in arr4)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nArreglo original : ");
            foreach (var item in arr5)
            {
                Console.Write(" " + item);
            }

            Sort(arr5);
            Console.WriteLine("\nArreglo ordenado : ");
            foreach (var item in arr5)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Presione una tecla para salir: ");
            Console.ReadKey();
        }
    }
}
