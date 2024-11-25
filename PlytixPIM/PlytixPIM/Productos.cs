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
    public partial class Productos : Form
    {

        
        
        public Productos()
        {
            InitializeComponent();
            
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            inicio.Show();

            this.Hide();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            
            Consulta consulta = new Consulta();
            var productos = consulta.Select("SELECT thumbnail AS 'Thumbnail'," +
                "sku AS 'SKU'," +
                "label AS 'Label' " +
                "FROM Producto");
            tablaProductos.DataSource = productos;
            tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Consulta consulta1 = new Consulta();

            DataTable res = consulta1.Select("SELECT Nombre FROM Atributo");
            int numeroAtributos = 0;
            foreach (DataRow fila in res.Rows)
            {
                numeroAtributos = int.Parse(fila["NumeroAtributos"].ToString());
                tablaProductos.Columns.Add(fila["Nombre"].ToString());
            }

            for (int i = 3; i < numeroAtributos+3; i++)
            {
                tablaProductos.Columns.Add()
            
            
            }
            





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            CrearProducto crearProducto = new CrearProducto();

            crearProducto.Show();
            this.Hide();
        }

        private void bDeleteProducts_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0) { 
                
                Consulta consulta1 = new Consulta();
                int skuBorrar = int.Parse(tablaProductos.SelectedRows[0].Cells["SKU"].Value.ToString());


                if (tablaProductos.SelectedRows[0].Cells["Category"].Value.ToString() != null)
                {
                    Consulta consulta2 = new Consulta();

                    consulta2.Delete("DELETE FROM ValorAtributo WHERE producto_sku ='" + skuBorrar + "'");
                }


                consulta1.Delete("DELETE FROM Producto WHERE sku=" + skuBorrar);
               

                this.Productos_Load(sender, e);
            }


            

        }
    }
}
