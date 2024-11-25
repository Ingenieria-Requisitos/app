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
    public partial class CrearAtributo : Form
    {

        Consulta consulta;

        public CrearAtributo()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Atributos atributos = new Atributos();

            atributos.Show();

            this.Hide();
        }

        private void CrearAtributo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string nombre = textName.Text;

            string tipo = desplegableTipo.SelectedItem.ToString();

            consulta.Insert("INSERT INTO Atributo (nombre,tipo) VALUES ('" + nombre + "','" + tipo + "')");

            Atributos atributos = new Atributos();

            atributos.Show();

            this.Hide();
        }
    }
}
