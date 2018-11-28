using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_2.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Quicksort(double[] arr, int begin, int end) // Netodo para ordenar el arreglo
            // tiene como parametros un arreglo, y dos numeros que determinan los indices de inicio y fin del arreglo
        {
            double pivot = arr[(begin + (end - begin) / 2)]; // se determina el pivote, en este caso es la mitad de los
            // numeros ingresados
            int left = begin;
            int right = end;
            while (left <= right) // mientras que left sea menor a right (el indice del numero izquierdo mayor al indice del numero
                // de la derecha
            {
                while (arr[left] < pivot) // mientras que el numero sea menor que el pivote
                { // incrementa left + 1
                    left++;
                }
                while (arr[right] > pivot)  // mientras que el numero sea menor que el pivote
                { // disminuye right -1
                    right--;
                }
                if (left <= right) // si left es menor que right, se manda a llamar el metodo Swap, que tiene como paremetros
                    // el arreglo, y dos numeros que sirven como valores del indice del arreglo
                {
                    Swap(arr, left, right); // despues de llamar al metodo se incrementa en uno el valor de left
                    // y el de right disminuye en 1
                    left++;
                    right--;
                }
            }

            // aqui se usan metodos recursivos si el numero begin es menor que right o si end es menor que left
            // esto se debe a que cuando estas condiciones se cumplen los numeros todavia no se terminan de ordernar
            if (begin < right) 
            {
                Quicksort(arr, begin, left - 1);
            }
            if (end > left)
            {
                Quicksort(arr, right + 1, end);
            }
        }
        static void Swap(double[] items, int x, int y) // metodo para hacer el cambio de valores en el arreglo
        {
            double temp = items[x]; // se le asigna a una variable temporal el valor del arreglo en el indice x, este vendria
            // siendo la variable left
            items[x] = items[y]; // ahora el arreglo con indice left tendra el valor del arreglo con indice right
            items[y] = temp; //el arreglo con indice right ahora tendra el valor de la variable temporal
        }

        static void Main(string[] args)
        {   
            Console.WriteLine("Lista 1:");
            Console.WriteLine("Desordenada:");
            double[] arr = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; // arreglo de tipo double

            foreach (var item in arr) // imprime arreglo desordenado
            {
                Console.Write("{0} | ", item);
            }
            Console.WriteLine("\nOrdenada:");

            Quicksort(arr, 0, arr.Length - 1); // Manda a llamar a Quicksort y un parametro es la cantidad de numeros del arreglo
                                               // para que el arreglo no compare un numero que no existe
            foreach (var item in arr) // Imprime arreglo ordenado
            {
                Console.Write("{0} | ", item);
            }
  
            Console.WriteLine("\n\nLista 2:");
            Console.WriteLine("Desordenada:");
            double[] arr2 = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };

            foreach (var item in arr2)
            {
                Console.Write("{0} | ", item);
            }

            Quicksort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("\nOrdenada:");
            foreach (var item in arr2)
            {
                Console.Write("{0} | ", item);
            }
            
            Console.WriteLine("\n\nLista 3:");
            Console.WriteLine("Desordenada:");
            double[] arr3 = { 3, 7, 15, (4 / 3), 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };
            foreach (var item in arr3)
            {
                Console.Write("{0} | ", item);
            }

            Quicksort(arr3, 0, arr3.Length - 1);
            Console.WriteLine("\nOrdenada:");
            foreach (var item in arr3)
            {
                Console.Write("{0} | ", item);
            }
            
            Console.WriteLine("\n\nLista 4:");
            Console.WriteLine("Desordenada:");
            double[] arr4 = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            
            foreach (var item in arr4)
            {
                Console.Write("{0} | ", item);
            }

            Quicksort(arr4, 0, arr4.Length - 1);
            Console.WriteLine("\nOrdenada:");
            foreach (var item in arr4)
            {
                Console.Write("{0} | ", item);
            }

            Console.Write("\n\nPresione una tecla para salir: ");
            Console.ReadKey();
        }
    }
}
