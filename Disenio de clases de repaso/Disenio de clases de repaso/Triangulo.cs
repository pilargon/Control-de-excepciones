using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disenio_de_clases_de_repaso
{
    class Triangulo
    {
        private int lado1;
        private int lado2;
        private int lado3;

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public void EsIsosceles()
        {
            if ((lado1 == lado2 && lado2 != lado3) || (lado1 == lado3 && lado3 != lado2) || (lado2 == lado3 && lado3 != lado1))
            {
                Console.WriteLine("El triangulo es isosceles");
            }
            else
            {
                Console.WriteLine("El triangulo no es isosceles");
            }
        }

        public void EsEquilatero()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else
            {
                Console.WriteLine("El triangulo no es equilatero");
            }
        }
        public bool EsRectangulo()
        {
            bool rectangulo = false;
            int max;
            double maximo;
            max = Math.Max(lado1, lado2);
            maximo = Math.Max(max, lado3);

            if (maximo == lado1)
            {
                if(maximo == Math.Sqrt(Math.Pow(lado2, 2) + Math.Pow(lado3, 2)))
                {
                    rectangulo = true;
                    Console.WriteLine("El triangulo es rectangulo");
                }
                else
                {
                    rectangulo = false;
                    Console.WriteLine("El triangulo no es rectangulo");
                }
            }
            if (maximo == lado2)
            {
                if(maximo == Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado3, 2)))
                {
                    rectangulo = true;
                    Console.WriteLine("El triangulo es rectangulo");
                }
                else
                {
                    rectangulo = false;
                    Console.WriteLine("El triangulo no es rectangulo");
                }
            }
            if (maximo == lado3)
            {
                if(maximo == Math.Sqrt(Math.Pow(lado2, 2) + Math.Pow(lado1, 2)))
                {
                    rectangulo = true;
                    Console.WriteLine("El triangulo es rectangulo");
                }
                else
                {
                    rectangulo = false;
                    Console.WriteLine("El triangulo no es rectangulo");
                }

            }     
            return rectangulo;

        }


    }
}
