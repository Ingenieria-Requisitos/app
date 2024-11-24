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
    public partial class LeerCategoria : Form
    {
        public LeerCategoria(string nombre,string num)
        {
            InitializeComponent();
            textCategoria.Text = nombre;
            textNum.Text = num;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();

            categorias.Show();

            this.Hide();
        }

        private void LeerCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
