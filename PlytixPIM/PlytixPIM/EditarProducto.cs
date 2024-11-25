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
    public partial class EditarProducto : Form
    {


        private int sku;
        public EditarProducto(int sku)
        {
            InitializeComponent();
            this.sku = sku;
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bUploadImage_Click(object sender, EventArgs e)
        {

        }

        private void imagenBox_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.Show();

            this.Hide();
        }

        private void labelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gtinBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string label = labelBox.Text;
            int skuNuevo = int.Parse(skuBox.Text);
            string gtin = gtinBox.Text;
            string categoria = listaCategorias.SelectedItem.ToString();
            Consulta consulta3 = new Consulta();

            consulta3.Update("UPDATE Producto SET label='" + label + "',sku=" + skuNuevo + ",gtin=" + gtin + ",categoria_nombre='" + categoria + "' WHERE sku=" + this.sku);


            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void skuBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            //Cargar categorias en lista
            Consulta consulta2 = new Consulta();

            DataTable res = consulta2.Select("SELECT nombre FROM Categoria");

            List<String> list = new List<String>();

            foreach (DataRow fila in res.Rows)
            {
                list.Add(fila["nombre"].ToString());
            }

            foreach (string cat in list)
            {
                listaCategorias.Items.Add(cat);
            }

            Consulta consulta3 = new Consulta();

            DataTable res2 = consulta3.Select("SELECT gtin,label,categoria_nombre FROM Producto WHERE sku=" + this.sku);

            string categoria = "";

            foreach(DataRow fila in res2.Rows)
            {
                labelBox.Text = fila["label"].ToString();
                gtinBox.Text = fila["gtin"].ToString();
                skuBox.Text = sku.ToString();
                categoria = fila["categoria_nombre"].ToString();
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                listaCategorias.SelectedItem = categoria;
            }


        }

        private void EditarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
