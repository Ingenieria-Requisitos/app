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


        
        public Atributos()
        {
            InitializeComponent();
            
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
            Consulta consulta = new Consulta(); 
            
            var atributos = consulta.Select("SELECT *  FROM Atributo");
            tablaAtributos.DataSource = atributos;
            tablaAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bAddAttribute_Click(object sender, EventArgs e)
        {
            CrearAtributo crearAtributo = new CrearAtributo();

            crearAtributo.Show();

            this.Hide();
        }

        private void bDeleteAttribute_Click(object sender, EventArgs e)
        {
            if(tablaAtributos.SelectedRows.Count > 0)
            {
                Consulta consulta = new Consulta();
                
                string name = (tablaAtributos.SelectedRows[0].Cells["nombre"].Value.ToString());

                consulta.Delete("DELETE FROM Atributo WHERE nombre='" + name + "'");

                this.Atributos_Load(sender, e);
            }
        }

        private void bEditAttribute_Click(object sender, EventArgs e)
        {
            if (tablaAtributos.SelectedRows.Count > 0)
            {
                
                string name = tablaAtributos.SelectedRows[0].Cells["nombre"].Value.ToString();
                string type = tablaAtributos.SelectedRows[0].Cells["tipo"].Value.ToString();


                EditarAtributo editarAtributo = new EditarAtributo(name,type);

                editarAtributo.Show();

                this.Hide();
            }
        }
    }
}
