using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            //Vector de números
            int[] Numeros = new int[] { 1, 2, 3, 4, 5, };

            //Vector de letras
            char[] Letras = new char[] { 'a', 'b', 'c', 'd', 'e' };

            //Vectores de palabras
            string[] Palabras = new string[] { "Hola", "Mundo", "es", "genial" };

            //Generar un vector vacío
            int[] vacío = new int[10];
            Console.WriteLine("\nVector vacío:");
            */

            cambioDeDatos();



        }

        static void ImprimirVector(int[] vector)
        {
            string vectorString = "";
            foreach (int elemento in vector) {
            vectorString = vectorString + elemento + " ";
            }
            Console.WriteLine(vectorString);
        }

        static void cambioDeDatos()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, };
            ImprimirVector(numeros);

            numeros[2] = 100;
            ImprimirVector(numeros);
        }

        static void IntercambioDePosicion(int[] cambio)
        {
            int temp = cambio[3];
            cambio[3] = cambio[2];
            cambio[2] = temp;
            Console.WriteLine(temp);
            

        }
    }
}