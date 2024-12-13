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
            tablaProductos.ClearSelection();
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
            listCategorias.ClearSelected();
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            if (tablaProductos.Rows.Count == 0)
            {
                MessageBox.Show($"No hay ningun producto en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Ruta donde se generará el archivo CSV
                string filePath = "temp.csv";
                using (StreamWriter writer = new StreamWriter(filePath))
                {



                    // Escribir cabecera
                    writer.WriteLine("Amazon -> Atributos en la app\n");

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


                    Consulta c2 = new Consulta();
                    DataTable resp = c2.Select("SELECT nombre FROM Atributo WHERE Tipo IN ('Real', 'Entero') ORDER BY fecha_creacion;");

                    if (resp.Rows.Count < 1)
                    {
                        MessageBox.Show($"No tiene ningun atributo de tipo entero o real. No se puede generar el CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        File.Delete(filePath);
                        return;
                    }
                    string atributo = resp.Rows[0]["nombre"].ToString();


                    // Buscar el primer atributo de tipo float o int
                    foreach (Object[] producto in productos)
                    {
                        string gtin = producto[0].ToString();
                        string sku = producto[1].ToString();
                        string label = producto[2].ToString();

                        Consulta c4 = new Consulta();
                        var atributoNum = c4.Select("SELECT valor FROM ValorAtributo WHERE producto_sku = " + sku + " AND atributo_nombre = '" + atributo + "' AND valor <> ''");
                        if (atributoNum.Rows.Count == 0)
                        {
                            MessageBox.Show($"El producto \"" + label + "\" no tiene valor definido para el atributo \"" + atributo + "\". " +
                                "No se puede generar el CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            writer.Close();
                            File.Delete(filePath);
                            return;
                        }

                        string precio = atributoNum.Rows[0]["valor"].ToString();

                        // Preparar fila
                        string fila = $"SKU -> {sku}\n" +
                                      $"Title -> {label}\n" +
                                      $"Fulfilled By -> {cuenta}\n" +
                                      $"Amazon_SKU -> {gtin}\n" +
                                      $"Price -> {precio}\n" +
                                      $"Offer Primer -> False\n";

                        writer.WriteLine(fila);
                    }
                    writer.Close();
                }

                string finalPath = "productos.csv";
                string contenido = File.ReadAllText(filePath);
                File.WriteAllText(finalPath, contenido);
                File.Delete(filePath);

                MessageBox.Show("Archivo CSV generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
