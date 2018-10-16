using System; namespace EjerciciosObjects7 {     public class Contacto2     {         private string nombre;         private int telefono;         private string fechaNac;         private int numCont;         private string tipoCont;         private int numFam;         private int numAmi;         private int numComTra;         private int numComEst;          public Contacto2(string nombre, int telefono,
                         string fechaNac, int numCont,
                         string tipoCont, int numFam,                          int numAmi, int numComTra,
                         int numComEst)         {             this.nombre = nombre;             this.telefono = telefono;             this.fechaNac = fechaNac;             this.numCont = numCont;             this.tipoCont = tipoCont;             this.numFam = numFam;             this.numAmi = numAmi;             this.numComTra = numComTra;             this.numComEst = numComEst;         } 

        public Contacto2(string nombre, int telefono, string fechaNac, string tipoCont)         {             this.nombre = nombre;             this.telefono = telefono;             this.fechaNac = fechaNac;             this.tipoCont = tipoCont;         }

        public Contacto2(string nombre, int telefono, string tipoCont)         {             this.nombre = nombre;             this.telefono = telefono;             fechaNac = DateTime.Today.ToString();             this.tipoCont = tipoCont;         }

        public Contacto2(string nombre, string fechaNac, string tipoCont)         {             this.nombre = nombre;             this.fechaNac = fechaNac;             this.tipoCont = tipoCont;         }          public Contacto2(string nombre, string fechaNac)         {             this.nombre = nombre;             this.fechaNac = fechaNac;             tipoCont = "Amigos";         }

        //public Contacto2(string nombre, string fechaNac)
        //{
        //    this.nombre = nombre;
        //    this.fechaNac = fechaNac;
        //}

        //public Contacto2(string nombre, int telefono)
        //{
        //    this.nombre = nombre;
        //    this.telefono = telefono;
        //    fechaNac = DateTime.Today.ToString();
        //}

        public void SetNombre(string nombre)         {             this.nombre = nombre;         }          public string GetNombre()         {             return nombre;         }          public void SetTel(int telefono)         {             this.telefono = telefono;         }          public int GetTel()         {             return telefono;         }          public void SetFecha(string fechaNac)         {             this.fechaNac = fechaNac;         }          public string GetFecha()         {             return fechaNac;         }          public void SetTipo(string tipoCont)         {             this.tipoCont = tipoCont;         }          public string GetTipo()         {             return tipoCont;         }          public int GetNumCont()         {             return numCont;         }          public int GetNumFam()         {             return numFam;         }          public int GetNumAmi()         {             return numAmi;         }          public int GetNumTra()         {             return numComTra;         }          public int GetNumEst()         {             return numComEst;         }          public void MostrarDatos()         {             Fecha f = new Fecha(fechaNac);             Console.WriteLine("Nombre: " + nombre);             Console.WriteLine("Teléfono: " + telefono);             Console.WriteLine("Fecha de nacimiento: " + fechaNac);             Console.WriteLine("Edad: " + f.GetEdad());             Console.WriteLine("Tipo de contacto: " + tipoCont);          }      } }  