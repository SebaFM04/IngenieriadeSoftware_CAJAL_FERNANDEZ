using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmProducto : Form
    {
        BE.PRODUCTO producto = new BE.PRODUCTO();
        PRODUCTO_BLL GestorProducto = new PRODUCTO_BLL();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Enlazar();
            CargarProductos();
        }
        private void Enlazar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Descripción", "Descripción");
            dataGridView1.Columns.Add("Código", "Código");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarProductos()
        {
            dataGridView1.Rows.Clear();

            try
            {
                var productos = GestorProducto.ListarProductos();

                foreach (var p in productos)
                {
                    dataGridView1.Rows.Add(
                        p.IdProducto,
                        p.NombreProducto,
                        p.PrecioProducto.ToString("0.00"),
                        p.TipoProducto,
                        p.Descripcion,
                        p.CodigoProducto,
                        p.Cantidad
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltafrmProducto_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CAMPOS
            // Recolectar y normalizar valores
            string nombre = textBox1.Text?.Trim();
            string precioText = textBox2.Text?.Trim();
            string tipo = textBox3.Text?.Trim();
            string descripcion = textBox4.Text?.Trim();
            string cantidadText = textBox5.Text?.Trim();
            string codigoText = textBox6.Text?.Trim();

            var errores = new List<string>();

            // Validaciones de campos obligatorios
            if (string.IsNullOrWhiteSpace(nombre)) errores.Add("El campo Nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(precioText)) errores.Add("El campo Precio es obligatorio.");
            if (string.IsNullOrWhiteSpace(tipo)) errores.Add("El campo Tipo es obligatorio.");
            if (string.IsNullOrWhiteSpace(descripcion)) errores.Add("El campo Descripción es obligatorio.");
            if (string.IsNullOrWhiteSpace(cantidadText)) errores.Add("El campo Cantidad es obligatorio.");
            if (string.IsNullOrWhiteSpace(codigoText)) errores.Add("El campo Código es obligatorio.");

            decimal precio = 0;
            int cantidad = 0;
            int codigo = 0;

            if (!string.IsNullOrWhiteSpace(precioText) && !decimal.TryParse(precioText, out precio))
            {
                errores.Add("Precio inválido. Use un número válido, por ejemplo 9.99.");
            }

            if (!string.IsNullOrWhiteSpace(cantidadText) && !int.TryParse(cantidadText, out cantidad))
            {
                errores.Add("Cantidad inválida. Use un número entero.");
            }

            if (!string.IsNullOrWhiteSpace(codigoText) && !int.TryParse(codigoText, out codigo))
            {
                errores.Add("Código inválido. Use un número entero.");
            }

            if (errores.Any())
            {
                MessageBox.Show(string.Join(Environment.NewLine, errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            producto.NombreProducto = nombre;
            producto.PrecioProducto = precio;
            producto.TipoProducto = tipo;
            producto.Descripcion = descripcion;
            producto.CodigoProducto = codigo;
            producto.Cantidad = cantidad;

            try
            {
                GestorProducto.InsertarProducto(producto);
                MessageBox.Show("Producto registrado exitosamente.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refrescar lista y limpiar campos
                CargarProductos();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
                textBox1.Focus();
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Aviso de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBajafrmProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnModificacionfrmProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
