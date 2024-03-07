using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = Mayor(2, 6,8);

            Console.WriteLine(var1);
        }

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
    }
}
