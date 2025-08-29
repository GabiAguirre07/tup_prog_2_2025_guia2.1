using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1.Models
{
    internal class RegistroVehiculo
    {
        public int ContadorPropietario = 0;
        public string Patente { get; }
        public string Serie { get; }
        public Persona Propietario { get; }
        public RegistroVehiculo(string patente, Persona propietario, string serie)
        {
            Patente = patente;
            Propietario = propietario;
            Serie = serie;
            ContadorPropietario++;
        }
        
    }
}