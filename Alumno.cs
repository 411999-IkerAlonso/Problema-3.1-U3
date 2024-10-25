using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._1
{
    public class Alumno : Persona
    {
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Legajo {  get; set; }

        public Alumno(int dni, string nombre, int telefono,int nota1, int nota2, int nota3, int legajo) : base(dni, nombre, telefono)
        {
            
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Legajo = legajo;
        }

        public double CalcularPromedio()
        {
            double promedio = (Nota1 + Nota2 + Nota3) /3;
            return promedio;
        }
        public override string ToString()
        {
           return base.ToString() + $"|Promedio: {CalcularPromedio()} |Legajo: {Legajo}";
        }
    }
}
