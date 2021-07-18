using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAritmeticos
{
    class TiposDeTriangulo
    {
        
        public static void FormarTriangulo()
        {
            double c=0;
            double a=0;
            double b=0;
            string[] s = Console.ReadLine().Split(' ');

            IEnumerable<string> query = s.OrderByDescending(q => q).ToList();
            
            int cont = 1;
            foreach (string str in query) {
                if(cont == 1)
                {
                    a = double.Parse(str);
                    
                }
                else if(cont == 2)
                {
                    b = double.Parse(str);
                }
                //Console.WriteLine(str);
                else if(cont == 3)
                {
                    c = double.Parse(str);
                }

                cont++;
            }

            // continue a solucao
            if (a >= (b + c))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if ((a*a) == ((b*b) + (c*c)))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if ((a*a) > ((b * b) + (c * c)))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if ((a*a) < ((b * b) + (c * c)))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && b == c && a != c) || (a == c && c == b && a != b))
                Console.WriteLine("TRIANGULO ISOSCELES");
                

            Console.ReadLine();
        }
    }
}

