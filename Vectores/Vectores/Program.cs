using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        class Vectores
        {
            static void Main(string[] args)
            {

                int[] vector = { 2, 3, 6, 7, 10, 13, 26 };
                MultiplosTres(vector);
            }

            static void SumarVectorPar(int[] vector)
            {
                int suma = 0;
                foreach (int elemento in vector)
                {
                    if ((elemento % 2) == 0)
                    {
                        suma = suma + elemento;
                    }
                }
                Console.WriteLine(suma);
            }

            static void SumaVectorImpar(int[] vector)
            {
                int suma = 0;
                foreach (int elemento in vector)
                {
                    if (elemento % 2 != 0)
                    {
                        suma += elemento;
                    }
                }
                Console.WriteLine(suma);
            }

            static void SumaVector(int[] vector)
            {
                int par = 0;
                int impar = 0;
                foreach (int elemento in vector)
                {
                    if ((elemento % 2) == 0)
                    par = par + elemento;
                    if(elemento % 2 != 0)
                    impar = impar + elemento;
                }
                Console.WriteLine(par + impar);
            }

            static void MultiplosTres(int[] vector)
            {
                int contador = 0;
                foreach (int elemento in vector)
                {
                    if ((elemento % 3) == 0)
                    {
                        //contador = contador + 1;
                        contador++;
                    }
                }
                Console.WriteLine(contador);
            }

            static int[] recorrerNumero(int[] vector, int nuevoNumero, int posicion)
            {
                return;
            }
        }
    }
}
