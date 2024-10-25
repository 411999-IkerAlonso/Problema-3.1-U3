using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._1
{
    public class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public Persona(int dni, string nombre, int telefono) 
        { 
            this.Dni = dni;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        public override string ToString()
        {
            return $"|Dni: {Dni} |Nombre: {Nombre} |Telefono: {Telefono}";
        }
    }
}
