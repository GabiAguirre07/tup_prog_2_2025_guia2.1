using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1.Models
{
    internal class DepartamentoVehicular
    {
       private List<RegistroVehiculo> registros = new List<RegistroVehiculo>();
        private int ultimoNumeroSecuencialPatente;
        private int ultimoNumeroSecuencialSerie;
        private  Random rnd = new Random();
        public int CantidadRegistros => registros.Count;
        public RegistroVehiculo RegistrarVehiculo(Persona propietario)
        {
            var nuevoRegistro = new RegistroVehiculo(GenerarPatente(), propietario,GenerarNúmeroSerie());
            registros.Add(nuevoRegistro);
            return nuevoRegistro;
        }
        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < registros.Count)
            {
                return registros[idx];
            }
            return null;
        }
        public string GenerarPatente()
        {
            
            Random rnd = new Random();
            string letras = "";
            for (int i = 0; i < 2; i++)
            {
                letras += (char)rnd.Next('A', 'Z' + 1);
            }
            string numerosSecuenciales;
           
            numerosSecuenciales = GenerarNumeroSecuencialPatente().ToString("D3");
            
            return $"{letras}{numerosSecuenciales}";
        }
        public string GenerarNúmeroSerie()
        {
            string numerosSecuenciales = "";
            numerosSecuenciales += GenerarNumeroSecuencialSerie().ToString("D4");
            return $"{numerosSecuenciales}";
        }
        private int GenerarNumeroSecuencialPatente()
        {
            if (ultimoNumeroSecuencialPatente > 1000)
            {
                ultimoNumeroSecuencialPatente = 0;
            }
            return ultimoNumeroSecuencialPatente++;
        }
        private int GenerarNumeroSecuencialSerie()
        {
            if (ultimoNumeroSecuencialSerie >= 1000)
            {
                ultimoNumeroSecuencialSerie = 0;
            }
            return ultimoNumeroSecuencialSerie++;
        }

    }
}

    