using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disenio_de_clases_de_repaso
{
    class Rectangulo
    {
        private int largo;
        private int ancho;

        public Rectangulo()
        {

        }
        public Rectangulo(int largo, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        ////Métodos selectores (get) y modificadores (set)
        //public String GetSelectores()
        //{
        //    return;
        //}
        //public void SetModificadores(String nombre)
        //{
        //    this.nombre = nombre;
        //}
        //Un método llamado area que devuelve el área del rectángulo
        public int Area()
        {
            return largo * ancho;
        }
        //Un método llamado diagonal que devuelve el valor de la diagonal ( con decimales)
        public double Diagonal()
        {
            return Math.Pow(largo,2)+Math.Pow(ancho,2);
        }

    }
}
