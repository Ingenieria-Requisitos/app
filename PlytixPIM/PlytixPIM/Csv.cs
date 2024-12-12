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
    public partial class Csv : Form
    {
        public Csv()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();

            this.Hide();
        }

        private void Csv_Load(object sender, EventArgs e)
        {
            listCategorias.ClearSelected();
            tablaProductos.ClearSelection();

            Consulta consulta = new Consulta();
            List <Object[]> lista = consulta.SelectEscalar("SELECT nombre FROM Categoria");
            foreach (Object[] obj in lista)
            {
                listCategorias.Items.Add(obj[0].ToString());
            }


            Consulta consulta1 = new Consulta();
            var productos = consulta1.Select("SELECT thumbnail AS 'Thumbnail'," +
                "sku AS 'SKU'," +
                "label AS 'Label'," +
                "categoria_nombre AS 'Category' " +
                "FROM Producto");
            tablaProductos.DataSource = productos;
            tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)tablaProductos.Columns[0];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void Csv_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            listCategorias.ClearSelected();
            
        }
    }
}
