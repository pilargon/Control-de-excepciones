﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disenio_de_clases_de_repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangulo r1 = new Rectangulo(5,6);
            //int area=r1.Area();
            //Console.WriteLine("El area del rectangulo es: " + area);

            //double diagonal = r1.Diagonal();
            //Console.WriteLine("La diagonal del rectangulo es: " + diagonal);
            //Console.ReadLine();

            Monedero m1 = new Monedero(0,0);
            m1.Ingreso(500);
            m1.Reintegro(50);
            Console.WriteLine("Tienes: "  +m1.GetSaldo());
            Console.ReadLine();
            



        }
    }
}
