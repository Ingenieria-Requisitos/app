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
    public partial class Categorias : Form
    {

        private Consulta consulta;
        
        public Categorias()
        {
            InitializeComponent();
            consulta = new Consulta();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            Categoria.nombre AS 'Category',
            COUNT(Producto.sku) AS 'Number of products'
        FROM 
            Categoria
        LEFT JOIN 
            Producto 
        ON 
            Categoria.nombre = Producto.categoria_nombre
        GROUP BY 
            Categoria.nombre
        ORDER BY 
            Categoria.nombre;";

            DataTable res = consulta.Select(query);

            tablaCategorias.DataSource = res;

            tablaCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void Categorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Inicio incio = new Inicio();

            incio.Show();

            this.Hide();
        }

        private void bAddCategory_Click(object sender, EventArgs e)
        {
            CrearCategoria crearCategoria = new CrearCategoria();

            crearCategoria.Show();
            this.Hide();
        }

        private void bDeleteCategory_Click(object sender, EventArgs e)
        {
            if (tablaCategorias.SelectedRows.Count > 0)
            {
                string nombre = tablaCategorias.SelectedRows[0].Cells[0].Value.ToString();

                consulta.Delete("DELETE FROM Categoria WHERE nombre='" + nombre + "'");



            
            }



        }

        private void bReadCategory_Click(object sender, EventArgs e)
        {

            if (tablaCategorias.SelectedRows.Count == 1)
            {
                string nombre = tablaCategorias.SelectedRows[0].Cells[0].Value.ToString();


                string num = tablaCategorias.SelectedRows[0].Cells[1].Value.ToString();

                EditarCategoria editarCategoria = new EditarCategoria(nombre, num);

                editarCategoria.Show();

                this.Hide();

            }
            else
            {

            }  
        }
    }
}
