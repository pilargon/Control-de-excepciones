using System;
namespace EjerciciosObjects7
{
    public class Fecha
    {
        private string fechaNac;

        public Fecha(string fechaNac)
        {
            this.fechaNac = fechaNac;
        }

        public int GetDia()
        {
            DateTime dt = Convert.ToDateTime(fechaNac);
            int dia = dt.Day;
            return dia;
        }

        public int GetMes()
        {
            DateTime dt = Convert.ToDateTime(fechaNac);
            int mes = dt.Month;
            return mes;
        }

        public int GetYear()
        {
            DateTime dt = Convert.ToDateTime(fechaNac);
            int year = dt.Year;
            return year;
        }

        public int GetEdad()
        {
            DateTime oldDate = new DateTime(GetYear(), GetMes(), GetDia());
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;

            // Difference in days.
            int differenceInDays = ts.Days, edad = (differenceInDays / 365);

            return edad;

            //DateTime dt = Convert.ToDateTime(DateTime.Today.ToString());
            //int year = dt.Year;
            //return (year - GetYear());
        }

        public void GetFelicidad()
        {
            Console.WriteLine("Felicidades por tus " + GetEdad() + " años");
        }


    }
}
