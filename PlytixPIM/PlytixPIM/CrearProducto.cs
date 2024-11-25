using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlytixPIM
{
    public partial class CrearProducto : Form
    {
        private Consulta consulta;

        public CrearProducto()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {

        }



        private void bSubmit_Click(object sender, EventArgs e)
        {
            string label = labelBox.Text;
            string sku = skuBox.Text;
            string gtin = gtinBox.Text;
            // falta meter el thumbnail tambien

            if (string.IsNullOrEmpty(label) || string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(gtin))
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
            else
            {
                consulta.Insert("INSERT INTO Producto (label, sku, gtin) VALUES ('" + label  + "', '" + sku + "', '" + gtin + "')");
            }
            

            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void bBack_Click_1(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.Show();

            this.Hide();
        }
    }
}
