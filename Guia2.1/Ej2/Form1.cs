using Ej2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa empresa = new Empresa();

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarHorasExtra cambiarHorasExtra = new CambiarHorasExtra();
            cambiarHorasExtra.tbDNI.Clear();
            cambiarHorasExtra.tbH100.Clear();
            cambiarHorasExtra.tbH50.Clear();
            if (cambiarHorasExtra.ShowDialog() == DialogResult.OK)
            {
                //Cambio de Horas Extras de un Empleado Específico
                int DNI = Convert.ToInt32(cambiarHorasExtra.tbDNI.Text);
                int Hextra50 = Convert.ToInt32(cambiarHorasExtra.tbH50.Text);
                int Hextra100 = Convert.ToInt32(cambiarHorasExtra.tbH100.Text);
                var empleado = empresa.VerEmpleadoPorDNI(DNI);
                if (empleado != null)
                {
                    empleado.HorasExtras50 = Hextra50;
                    empleado.HorasExtras100 = Hextra100;
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado registrar = new RegistrarEmpleado();
            if (registrar.ShowDialog() == DialogResult.OK)
            {
                int DNI = Convert.ToInt32(registrar.tbDNI.Text);
                string Nombre = registrar.tbNombre.Text;
                string Apellido = registrar.tbApellido.Text;
                int AñoContratado = Convert.ToInt32(registrar.tbAñoContratado.Text);
                int HorasExtras50 = Convert.ToInt32(registrar.tbH50.Text);
                int HorasExtras100 = Convert.ToInt32(registrar.tbH100.Text);
                double MontoBase = Convert.ToDouble(registrar.tbMontoBase.Text);
                empresa.RegistrarEmpleado(DNI, Apellido, Nombre, AñoContratado, HorasExtras50, HorasExtras100,MontoBase);
                registrar.tbApellido.Clear();
                registrar.tbNombre.Clear();
                registrar.tbAñoContratado.Clear();
                registrar.tbDNI.Clear();
                registrar.tbH100.Clear();
                registrar.tbH50.Clear();
                registrar.tbMontoBase.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerarLiquidaciones generar = new GenerarLiquidaciones();
            generar.ShowDialog();
            int AÑO = Convert.ToInt32(generar.tbAño.Text);
            int MES = Convert.ToInt32(generar.tbMes.Text);
            empresa.GenerarLiquidaciones(MES, AÑO);
            generar.tbAño.Clear();
            generar.tbMes.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Año = Convert.ToInt32(tbAño.Text);
            int Mes = Convert.ToInt32(tbMes.Text);
            var lista = empresa.ListarLiquidaciones(Año, Mes);
            if (lista != null)
            {
                ListarLiquidaciones listar = new ListarLiquidaciones();
                listar.listBox1.Items.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    var liq = lista[i] as Liquidacion;
                    listar.listBox1.Items.Add($"Empleado: {liq.empleado.ApellidoNombre}");
                    listar.listBox1.Items.Add($"Básico: ${liq.MontoBasico:f2}");
                    listar.listBox1.Items.Add($"Antiguedad: ${liq.MontoAntiguedad:f2}");
                    listar.listBox1.Items.Add($"Extras al 50%: ${liq.MontoExtras50:F2}");
                    listar.listBox1.Items.Add($"Extras al 100%: ${liq.MontoExtras100:F2}");
                    listar.listBox1.Items.Add($"Obra Social: ${liq.DescObraSocial:F2}");
                    listar.listBox1.Items.Add($"Jubilación: ${liq.DescJubilacion:F2}");
                    listar.listBox1.Items.Add($"Aportes Gremiales: ${liq.DescGremial:F2}");
                    listar.listBox1.Items.Add($"Productividad: ${liq.Productividad:F2}");
                    listar.listBox1.Items.Add($"A Cobrar: ${liq.ACobrar:F2}");
                    listar.listBox1.Items.Add("------------------------------------------");
                    
                }
                listar.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListarLiquidaciones listar = new ListarLiquidaciones();
            listar.listBox1.Items.Clear();
            int Año = Convert.ToInt32(tbAño.Text);
            int Mes = Convert.ToInt32(tbMes.Text);
            double total = empresa.VerMontoLiquidacionTotal(Año,Mes);
            if (total != 0)
            {
                listar.listBox1.Items.Add($"Total de liquidaciones: ${total:F2}");
            }
            listar.ShowDialog();
        }
    }
}