using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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

        

        private void listCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCategorias.SelectedItem != null)
            {
                Consulta consulta1 = new Consulta();

                var productos = consulta1.Select("SELECT thumbnail AS 'Thumbnail'," +
                    "sku AS 'SKU'," +
                    "label AS 'Label'," +
                    "categoria_nombre AS 'Category' " +
                    "FROM Producto WHERE categoria_nombre='" + listCategorias.SelectedItem.ToString() + "'");
                tablaProductos.DataSource = productos;
                tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)tablaProductos.Columns[0];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            else
            {
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
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
        /*    try
            {
                // Ruta donde se generará el archivo CSV
                string filePath = "productos.csv";
                using (StreamWriter writer = new StreamWriter(filePath))
                {



                    // Escribir cabecera
                    writer.WriteLine("Amazon -> Atributos en la app");

                    List<Object[]> productos = new List<Object[]>();
                    if (listCategorias.SelectedItem != null)
                    {
                        Consulta consulta1 = new Consulta();

                        productos = consulta1.SelectEscalar("SELECT gtin AS 'GTIN'," +
                             "sku AS 'SKU'," +
                             "label AS 'Label' " +
                             "FROM Producto WHERE categoria_nombre='" + listCategorias.SelectedItem.ToString() + "'");
                    }
                    else
                    {
                        Consulta consulta1 = new Consulta();
                        productos = consulta1.SelectEscalar("SELECT gtin AS 'GTIN'," +
                            "sku AS 'SKU'," +
                            "label AS 'Label' " +
                            "FROM Producto");

                    }


                    Consulta c1 = new Consulta();
                    string cuenta = c1.SelectEscalar("SELECT nombre FROM Cuenta")[0][0].ToString();


                    foreach (Object[] producto in productos)
                    {
                        string gtin = producto[0].ToString();
                        string sku = producto[1].ToString();
                        string label = producto[2].ToString();
                        // Buscar el primer atributo de tipo float o int
                        var atributoNumerico = producto.Atributos
                            .FirstOrDefault(attr => attr.Value is float || attr.Value is int);



                        // Si no hay atributo numérico, mostrar mensaje de error y salir
                        if (atributoNumerico.Value == null)
                        {
                            MessageBox.Show($"El producto con SKU '{sku}' no tiene atributos numéricos. No se puede generar el CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Preparar fila
                        string fila = $"{sku}," +
                                      $"{label}," +
                                      $"{cuenta}," +
                                      $"{gtin}," +
                                      $"{atributoNumerico.Value}," +
                                      $"False";

                        writer.WriteLine(fila);
                    }
                }

                MessageBox.Show("Archivo CSV generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
