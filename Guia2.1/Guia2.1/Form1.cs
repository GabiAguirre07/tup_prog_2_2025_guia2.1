using Guia2._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private DepartamentoVehicular registrar = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosPropietario datosP = new DatosPropietario();
            if (datosP.ShowDialog() == DialogResult.OK)
            {
                int DNI = Convert.ToInt32(datosP.tbDNI.Text);
                string Nombre = datosP.tbNombre.Text;
                Persona propietario = new Persona(DNI, Nombre);
                var nuevovehiculo = registrar.RegistrarVehiculo(propietario);
                tbRegistrar.Clear();
                if (nuevovehiculo != null)
                {
                    tbRegistrar.Text = $"Vehículo registrado correctamente\r\nPropietario:{propietario.Nombre}({propietario.DNI}), Patente:{nuevovehiculo.Patente}, Serie:{nuevovehiculo.Serie}";
                }
                datosP.tbDNI.Clear();
                datosP.tbNombre.Clear();
            }


        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            tbListarRegistros.Clear();
            if(registrar.CantidadRegistros == 0)
    {
                tbListarRegistros.Text = "No hay registros cargados.";
                return;
            }
            for (int i = 0; i < registrar.CantidadRegistros; i++)
            {
                var registro = registrar.VerRegistro(i);
                tbListarRegistros.AppendText(
                    $"Propietario:{registro.Propietario.Nombre}({registro.Propietario.DNI})," +
                    $"Patente: {registro.Patente}, Serie: {registro.Serie}{Environment.NewLine}"
                    );
            }
        }
    }
}
