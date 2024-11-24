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
    public partial class Atributos : Form
    {


        private Consulta consulta;
        public Atributos()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void Atributos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            inicio.Show();

            this.Hide();
        }

        private void Atributos_Load(object sender, EventArgs e)
        {
            var atributos = consulta.Select("SELECT *  FROM Atributo");
            tablaAtributos.DataSource = atributos;
            tablaAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
