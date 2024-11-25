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
    public partial class EditarAtributo : Form
    {

        private Consulta consulta;

        private int id;
        private string nameOld;
        private string typeOld;
        
        
        public EditarAtributo(int id,string nameOld,string typeOld)
        {
            InitializeComponent();
            consulta = new Consulta();

            this.id = id;
            this.nameOld = nameOld;
            this.typeOld = typeOld;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Atributos atributos = new Atributos();

            atributos.Show();

            this.Hide();
        }

        private void EditarAtributo_Load(object sender, EventArgs e)
        {
            textName.Text = nameOld;
            desplegableTipo.Text = typeOld;
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (!nameOld.Equals(textName.Text))
            {
                consulta.Update("UPDATE Atributo SET nombre='" + textName.Text + "' WHERE id=" + id);
            }

            if (!typeOld.Equals(desplegableTipo.SelectedItem.ToString())){
                consulta.Update("UPDATE Atributo SET tipo='" + desplegableTipo.SelectedItem.ToString() + "' WHERE id=" + id);
            }

            Atributos atributos = new Atributos();
            atributos.Show();
            this.Hide();
        
        }
    }
}
