using System;
using System.Globalization;

namespace EjerciciosObjects7
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Contacto c1 = new Contacto("Miren", 944123456, "04/02/1990");
            Contacto c2 = new Contacto("Jon", 931212123);
            Contacto c3 = new Contacto("Ane", "05/05/1995");
            Contacto c4 = new Contacto("Julen", 944123321, "04/02/1992");
            Fecha f1 = new Fecha(c1.GetFecha());
            Fecha f2 = new Fecha(c2.GetFecha());
            Fecha f3 = new Fecha(c3.GetFecha());
            Fecha f4 = new Fecha(c4.GetFecha());
            //Console.WriteLine(f1.GetYear());
            //Console.WriteLine(f1.GetMes());
            //Console.WriteLine(f1.GetDia());
            //Console.WriteLine(f1.GetEdad());
            //f1.GetFelicidad();
            //c1.MostrarDatos();
            //f1.GetFelicidad();
            //Console.WriteLine();
            //c2.MostrarDatos();
            //f2.GetFelicidad();
            //Console.WriteLine();
            //c3.MostrarDatos();
            //f3.GetFelicidad();
            //Console.WriteLine();
            //c4.MostrarDatos();
            //f4.GetFelicidad();
            //Console.WriteLine();
            Contacto2 co21 = new Contacto2("Miren", 944123456, "06/03/1990", "Amigos");
            Contacto2 co22 = new Contacto2("Jon", 931212123, "Trabajo");
            Contacto2 co23 = new Contacto2("Ane", "05/05/1995", "Familia");
            Contacto2 co24 = new Contacto2("Julen", 944123321, "12/02/1992", "Estudios");
            Contacto2 co25 = new Contacto2("Jone", "06/06/1992");
            Contacto2 co26 = new Contacto2("Mikel", "07/07/1997", "Familia");
            co21.MostrarDatos();
            Console.WriteLine();
            co22.MostrarDatos();
            Console.WriteLine();
            co23.MostrarDatos();
            Console.WriteLine();
            co24.MostrarDatos();
            Console.WriteLine();
            co25.MostrarDatos();
            Console.WriteLine();
            co26.MostrarDatos();
            Console.WriteLine();
            Console.ReadLine();

        }

        static public string FechaCorrect(string fecha)
        {
            DateTime dt = Convert.ToDateTime(fecha);
            int year = dt.Year;
            if (year > 1907)
            {
                return dt.ToString();
            }
            else
            {
                return DateTime.Today.ToString();
            }
        }
    }
}
