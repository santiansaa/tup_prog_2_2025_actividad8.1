

using System;

namespace Ejercicio1.Models
{
    public class Cuenta:IComparable
    {
        public string Nombre { get; set; }  
        public int Dni {  get; set; }
        public double Importe { get; set; } 

        public Cuenta(string nombre, int dni, double importe)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Importe = importe;
        }
        public override string ToString()
        {
            return $"Nombre {Nombre} - Dni{Dni}- " +
                $"importe {Importe}";
        }

   
        public int CompareTo(object obj)
        {
            Cuenta c = obj as Cuenta;
            if (c != null)
            {
                return this.Dni.CompareTo(c.Dni);
            }
            return -1;

        }
    }
}
