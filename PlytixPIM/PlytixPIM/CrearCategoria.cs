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


    


    public partial class CrearCategoria : Form
    {


        private Consulta consulta;
        public CrearCategoria()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {

        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string nombreCategoria = textCatName.Text;
            consulta.Insert("INSERT INTO Categoria VALUES ('" + nombreCategoria + "')");

            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();



        }

        private void CrearCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
