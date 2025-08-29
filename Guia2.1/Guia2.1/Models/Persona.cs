using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1.Models
{
    internal class Persona
    {
        public int DNI { get; }
        public string Nombre { get; }
        public Persona (int DNI, string Nombre)
        {
            this.DNI = DNI;
            this.Nombre = Nombre;
        }
    }
}
