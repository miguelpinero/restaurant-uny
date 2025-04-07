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
    public partial class Form1 : Form
    {
        Venta ventaActual;

        public Form1()
        {
            InitializeComponent();
            resetForm();
            textBox6.Text = "70.15";
        }

        private void resetForm()
        {
            this.ventaActual = new Venta();

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string error;

            if (!Validador.ValidarNombre(textBox1.Text, out error)) {
                MessageBox.Show(error);
            } else if (!Validador.ValidarNumeroContacto(textBox2.Text, out error)) {
                MessageBox.Show(error);
            } else if (!Validador.ValidarDireccion(textBox3.Text, out error)) {
                MessageBox.Show(error);
            } else if (ventaActual.CantidadArticulos == 0) {
                MessageBox.Show("Debe agregar al menos un articulo para finalizar esta venta");
            } else {
                ventaActual.Direccion = textBox3.Text;
                ventaActual.NombreCliente = textBox1.Text;
                ventaActual.Telefono = textBox2.Text;

                VentaRepository.AgregarVenta(ventaActual);
                MessageBox.Show("Venta efectuada satisfatoriamente");
                resetForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            agregarProducto("Smash burger", 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarProducto("Smash burger doble", 6.5m);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Hamburguesa Americana ", 7m);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Pepito mixto", 12m);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Pepito gratinado", 13m);
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Nuggets con papas", 5);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Milanesa napolitana", 10);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Barquilla", 1);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Refresco de litro", 2);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            agregarProducto("Servicio delivery", 2);
        }

        private void agregarProducto(string nombre, decimal precio) {
            ventaActual.AgregarProducto(nombre, precio, precio * Decimal.Parse(textBox6.Text), 1);
            updateTotales();
        }

        private void updateTotales()
        {
            decimal tasaDelDia = Decimal.Parse(textBox6.Text);

            textBox5.Text = ventaActual.CantidadArticulos.ToString();
            textBox4.Text = ventaActual.MontoTotal.ToString();
            textBox7.Text = (ventaActual.MontoTotal * tasaDelDia).ToString("F2");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
