using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_1.Cruz_Vera_Elden_Humberto
{
    public class Burbuja
    {
        int temp = 0; // Inicializa una variable temporal
        int Cantidad; // Variable para la cantidad de elementos a ordenar

        int[] Numeros; // Creacion del arreglo que va a contener los elementos a ordenar
        private void Captura() // Metodo para capturar los elementos del arreglo
        {
            Console.Write("Capture la cantidad de números deseados: ");
            Cantidad = Int16.Parse(Console.ReadLine()); // captura la cantidad de elementos del arreglo
            Console.WriteLine();
            Numeros = new int[Cantidad]; // Se inicializa el variablo en el valor de Cantidad
            for (int Contador = 0; Contador < Cantidad; Contador++) // ciclo for para capturar los elementos del arreglo
            {
                Console.Write("Capture el numero {0}: ", Contador+1);
                Numeros[Contador] = Int16.Parse(Console.ReadLine());
            }

        }

        private void Comparacion() // Metodo que compara todos los elemetnos del arreglo 
        {
            Captura(); // Manda a llamar el metodo captura 
            for (int Contador = 0; Contador < Numeros.Length; Contador++) // Cuando se acabe el otro ciclo esta va a hacer
                // los recorridos necesarios hasta que todos los elementos se hayan comparadp
            {
                for (int Contador2 = 0; Contador2 < Numeros.Length - 1; Contador2++) // Ciclo que compara los elementos
                    // del arreglo, por cada recorrido compara el elemento actual con el siguiente
                {
                    if (Numeros[Contador2] > Numeros[Contador2 + 1]) // si el indice actual es mayor al indice siguiente
                    {
                        temp = Numeros[Contador2 + 1]; // se le asigna el valor de Contador2+1 a la variable temporal
                        Numeros[Contador2 + 1] = Numeros[Contador2]; // Numeros[Contador2 +1] ahora tendra el valor 
                        //de Numeros[Contador2]
                        Numeros[Contador2] = temp; // Ahora el elemento actual tendra un valor menor que el del elemento
                        // siguiente
                    }
                }

            }
        }

        public void Imprimir() // Metodo para imprimir el arreglo ordenado
        {
            Comparacion(); // Manda a llamar el metodo Comparacion
            Console.WriteLine();
            foreach (var item in Numeros) // Ciclo foreach para desplegar los elementos del arreglo ordenado
            {
                Console.WriteLine(item); // imprime el elemento actual del arreglo
            }

            Console.Write("\nPresione una tecla para salir: ");// Mensaje de salida
            Console.ReadKey();
        }
    }
}
