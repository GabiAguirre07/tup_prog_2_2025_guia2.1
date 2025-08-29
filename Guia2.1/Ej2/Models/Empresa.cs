using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    internal class Empresa
    {
        private List<Liquidacion> liquidaciones = new List<Liquidacion>();
        private List<Empleado> empleados = new List<Empleado>();
        public int AñoActual { get; set; }
        public Empleado VerEmpleadoPorDNI(int DNI)
        {
            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleados[i].DNI == DNI)
                {
                    return empleados[i];
                }
            }
            return null;
        }
        public Empleado RegistrarEmpleado(int dni, string apellido, string nombre, int añoContratado, int HorasExtras50, int HorasExtras100,double MontoBase)
        {
            var empleado = new Empleado(dni, apellido, nombre, añoContratado, HorasExtras50, HorasExtras100,MontoBase);
            empleados.Add(empleado);
            return empleado;
        }
        public void GenerarLiquidaciones(int mes, int año)
        {
            for (int i = 0; i < empleados.Count; i++)
            {
                var liquidaciones = new Liquidacion(empleados[i], año, mes);
                this.liquidaciones.Add(liquidaciones);
            }
        }
        public ArrayList ListarLiquidaciones(int año, int mes)
        {
            ArrayList lista = new ArrayList();
            for (int idx = 0; idx < liquidaciones.Count; idx++)
            {
                if (liquidaciones[idx].Año == año && liquidaciones[idx].Mes == mes)
                {
                    lista.Add(liquidaciones[idx]);
                }
            }
            return lista;
        }
        public double VerMontoLiquidacionTotal(int año, int mes)
        {
            double total = 0;
            var liquidaciones = ListarLiquidaciones(año, mes);
            if (liquidaciones != null)
            {
                for (int idx = 0; idx < liquidaciones.Count; idx++)
                {
                    var liq = liquidaciones[idx] as Liquidacion;
                    total += liq.ACobrar;
                }
                return total;
            }
            else { return 0; }
        }
        public void MostrarLiquidaciones(int año, int mes)
        {
            var lista = ListarLiquidaciones(año, mes);
            foreach (Liquidacion liq in lista)
            {
               
            }

        }
       

        }
    }

