using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disenio_de_clases_de_repaso
{
    class Alarma
    {
        private double temperatura;
        private bool timbre;

        //Un constructor que recibe como argumento la temperatura y pone el timbre en posición apagado.
        public Alarma(double temperatura, bool timbre)
        {
            this.temperatura = temperatura;
            this.timbre = false;
        }

        //Un constructor que no tiene argumentos y que pide la temperatura por teclado y
        //también pone el timbre a la posición de apagado.
        public Alarma()
        {
            Console.WriteLine("Dame la temperatura");
            temperatura = Convert.ToInt32(Console.ReadLine());
            timbre = false;
        }

        //Un método llamado comprueba que pone el timbre a la posición encendido si la 
        //temperatura pasa de 35 grados o baja de 10 grados.





    }
}
