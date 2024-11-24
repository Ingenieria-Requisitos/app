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
    public partial class Productos : Form
    {

        private Consulta consulta;
        
        public Productos()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            inicio.Show();

            this.Hide();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            var productos = consulta.Select("SELECT thumbnail,sku,label,categoria_nombre FROM Producto");
            tablaProductos.DataSource = productos;
            tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
