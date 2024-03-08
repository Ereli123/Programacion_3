using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            /*
            int var1 = Mayor(2, 6,8);

            Console.WriteLine(var1);
            */

            Rotardosnumeroalprincipio();

            Console.ReadLine();

        }

        /*
        static int Mayor(int num1, int num2, int num3) 
        {
            if (num1 > num2)
            {
                return num1;
            } else
            {
                if (num2 > num3)
                {
                    return num2;
                } else { return num3;}   
            }
        }
        */

        /*
        static void Main()
        {
            Console.WriteLine("Por favor, ingrese la primera nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, ingrese la segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            int notafinal = ((nota1 + nota2) / 2);

            EvaluarNota(notafinal);
        }

        static void EvaluarNota(int nota)
        {
            if (nota > 50)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
        */

        static void Rotardosnumeroalprincipio()
        {
            string numero = Console.ReadLine();
            char unoprimeros = numero[0];
            char dosprimeros = numero[1];
            string resto = numero.Substring(2, numero.Length -2);
            string resultado = resto + unoprimeros + dosprimeros;
            Console.WriteLine(resultado);
        }
    }
}
