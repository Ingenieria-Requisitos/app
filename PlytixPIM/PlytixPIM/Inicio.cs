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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void bSeeProducts_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.Show();

            this.Hide();
        }

        private void bSeeCategories_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();

            categorias.Show();

            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bSeeAtributes_Click(object sender, EventArgs e)
        {
            Atributos atributos = new Atributos();

            atributos.Show();

            this.Hide();
        }
    }
}
