using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una palabra");
            string palabra = Console.ReadLine();
            llenarVectorPalabras(palabra);
        }

        static void LlenarVector(int cantidad)
        {
            int[] vector = new int[cantidad];
            int numero = 1;
            for (int i = 0; i < cantidad; i++)
            {
                while (!esPar(numero))
                {
                    numero++;
                }
                vector[i] = numero;
                numero++;
            }
            imprimirVectorGeneral(vector);
        }

        static void llenarVectorString(string palabra)
        {
            char[] letras = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
                letras[i] = palabra[i];
            }
            imprimirVectorGeneral(letras);
        }

        static bool esPar(int numero)
        {
            if ((numero % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void llenarVectorPalabras(string oracion)
        {
            string[] palabras = oracion.Split(' ');

            imprimirVectorGeneral(palabras);
        }











        static void imprimirVector(int[] vector)
        {
            string vectorString = "";
            foreach (int elemento in vector)
            {
                vectorString = vectorString + elemento + " ";
            }
            Console.WriteLine(vectorString);
        }

        static void imprimirVectorLetras(char[] vector)
        {
            foreach (char elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        /*
        static void imprimirVectorPalabras(string[] vector)
        {
            foreach (char elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
        */

        static void imprimirVectorGeneral<T>(T[] vector)
        {
            foreach (T elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        /*
        static bool esPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i * <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
        }
        */
    }
}
