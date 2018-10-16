using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disenio_de_clases_de_repaso
{
    class Monedero
    {
        private double dinero;
        private double saldo;

        //Constructor
        public Monedero(double dinero, double saldo)
        {
            this.dinero = dinero;
            this.saldo = saldo;
        }
        //Get Set
        public double GetDinero()
        {
            return dinero;
        }
        public void SetDinero(double dinero)
        {
            this.dinero = dinero;
        }
        //get set saldo
        public double GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        //Metodo para meter dinero en el monedero
        public void Ingreso(double dinero)
        {

            if (dinero < 0)
            {
                Console.WriteLine("Error: no se puede ingresar cantidades negativas");
                Console.ReadLine();
                return;
            }
            saldo = saldo + dinero;
        }
        //Metodo para sacar dinero del monedero
        public void Reintegro(double dinero)
        {

            if (saldo - dinero < 0)
            {
                Console.WriteLine("Error: no dispone de saldo ...");
                Console.ReadLine();
                return;
            }
            saldo = saldo - dinero;
        }


    }
}
