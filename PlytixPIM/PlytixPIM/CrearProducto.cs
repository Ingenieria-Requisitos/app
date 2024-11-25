using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Consulta consulta2 = new Consulta();

            DataTable res = consulta2.Select("SELECT nombre FROM Categoria");

            List<String> list = new List<String>();

            foreach (DataRow fila in res.Rows)
            {
                list.Add(fila["nombre"].ToString());
            }
            
            foreach(string cat in list)
            {
                listaCategorias.Items.Add(cat);
            }
        
        
        }


        private byte[] GetImageBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagenBox.Image.Save(ms, imagenBox.Image.RawFormat);
                return ms.ToArray();
            }
        }




        private void bSubmit_Click(object sender, EventArgs e)
        {
            
            string label = labelBox.Text;
            string sku = skuBox.Text;
            string gtin = gtinBox.Text;
            string categoria = listaCategorias.SelectedItem.ToString();

            //byte[] img = GetImageBytes();

            // falta meter el thumbnail tambien

            if (string.IsNullOrEmpty(label) || string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(gtin))
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                
                consulta.Insert("INSERT INTO Producto (label, sku, gtin,categoria_nombre) VALUES ('" + label + "', '" + sku + "', '" + gtin + "','" + categoria + "')");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.JPEG)|*.jpg;*.png;*.jpeg";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                imagenBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void CrearProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}