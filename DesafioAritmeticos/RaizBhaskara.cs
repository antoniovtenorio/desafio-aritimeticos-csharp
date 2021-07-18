using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAritmeticos
{
    class RaizBhaskara
    {
        public static void calcularRaiz()
        {
            double a =0, b=0, c=0, delta=0, r1=0, r2=0;
            
            string[] valor = Console.ReadLine().Split(' ');

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            //declare as demais variaveis

            delta = Math.Pow(b, 2) - (4 * a * c);
            r1 = ((-b + Math.Sqrt(delta)) / (2 * a));
            r2 = ((-b - Math.Sqrt(delta)) / (2 * a));

            if ( (delta >=0) && (a != 0) && (b != 0) && (c != 0))
            {
                Console.WriteLine($"R1 = " + r1.ToString("0.00000"));
                Console.WriteLine($"R2 = " + r2.ToString("0.00000"));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }
    }
}
