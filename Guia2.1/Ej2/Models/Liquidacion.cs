using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    internal class Liquidacion
    {
        public int HorasExtras50 { get; set; }
        public int HorasExtras100 { get; set; }
        public Empleado empleado { get; }

        public int Año { get; }
        public int Mes { get; }
        public double MontoBasico { get; }
        public double PorcAntiguedad
        {
            get
            {
                int añosdeTrabajo = Año - empleado.AñoContratado;
                int añosMTrabajoTope = 30;
                // No se paga mas del 100%
                double porcantiguedad = ((double)añosdeTrabajo / añosMTrabajoTope) * 100;
                if (porcantiguedad > 100)
                {
                    return 100;
                }
                return porcantiguedad;
            }
        }
        public double MontoAntiguedad { get { return MontoBasico * (PorcAntiguedad / 100); } }
        public double MontoExtras50
        {
            get
            {
                double ValorHora = MontoBasico / 40;
                return ValorHora * HorasExtras50 * 1.5;

            }
        }
        public double MontoExtras100
        {
            get
            {
                double ValorHora = MontoBasico / 40;
                return ValorHora * HorasExtras100 * 2;
            }
        }
        public double Nominal { get { return MontoBasico + MontoExtras100 + MontoExtras50 + MontoAntiguedad; } }

        public double DescObraSocial { get { return Nominal * 0.03; } }
        public double DescJubilacion { get { return Nominal * 0.18; } }
        public double DescGremial { get { return Nominal * 0.015; } }
        public double TotalDescuentos { get { return DescGremial + DescObraSocial + DescJubilacion; } }
        public double Neto { get { return Nominal - TotalDescuentos; } }
        public double Productividad { get { return Neto * 0.30; } }
        public double ACobrar { get { return Neto + Productividad; } }
        public Liquidacion(Empleado empleado, int año, int mes)
        {
            this.empleado = empleado;
            Año = año;
            Mes = mes;
            MontoBasico = empleado.MontoBase;
            HorasExtras100 = empleado.HorasExtras100;
            HorasExtras50 = empleado.HorasExtras50;
        }
    }
}
        