using System;
namespace EjerciciosObjects7
{
    public class Contacto
    {
        private string nombre;
        private int telefono;
        private string fechaNac;

        public Contacto(string nombre, int telefono, string fechaNac)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
        }

        public Contacto(string nombre, string fechaNac)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }

        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            fechaNac = DateTime.Today.ToString();
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetTel(int telefono)
        {
            this.telefono = telefono;
        }

        public int GetTel()
        {
            return telefono;
        }

        public void SetFecha(string fechaNac)
        {
            this.fechaNac = fechaNac;
        }

        public string GetFecha()
        {
            return fechaNac;
        }

        public void MostrarDatos()
        {
            Fecha f = new Fecha(fechaNac);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Fecha de nacimiento: " + fechaNac);
            Console.WriteLine("Edad: " + f.GetEdad());
        }

    }
}
