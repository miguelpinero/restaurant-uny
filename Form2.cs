using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas;

namespace restaurant_uny
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CargarVentasEnGrid();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarVentasEnGrid()
        {
            var ventas = VentaRepository.ObtenerVentas();
            dataGridVentas.Rows.Clear();

            foreach (var venta in ventas)
            {
                dataGridVentas.Rows.Add(
                    venta.NombreCliente,
                    venta.Telefono,
                    venta.Direccion,
                    venta.CantidadArticulos,
                    venta.MontoTotal.ToString("F2") + " USD",
                    venta.MontoTotalBs.ToString("F2") + " Bs"
                );
            }
        }
    }
}
