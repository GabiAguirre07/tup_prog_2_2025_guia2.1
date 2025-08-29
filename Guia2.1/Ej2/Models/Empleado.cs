using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    internal class Empleado
    {
        public int DNI { get; }
        public string Apellido { get; }
        public string Nombre { get; }
        public int AñoContratado { get; }
        public string ApellidoNombre
        {
            get
            {
                return $"{Apellido}, {Nombre}";
            }
        }
        public double MontoBase { get; set; }
           
        public int HorasExtras50 {  get; set; }
        public int HorasExtras100 { get; set; }
        public Empleado (int dni,string apellido,string nombre,int añoContratado,int HorasExtras50,int HorasExtras100,double MontoBase)
        { 
            DNI = dni;
            Apellido = apellido;
            Nombre = nombre;
            AñoContratado = añoContratado;
            this.HorasExtras100 = HorasExtras100;
            this.HorasExtras50 = HorasExtras50;
            this.MontoBase = MontoBase;
        }
        
        }
    }

