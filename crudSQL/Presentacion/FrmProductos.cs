using crudSQL.BLL;
using crudSQL.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudSQL.Presentacion
{
    public partial class FrmProductos : Form
    {
        ProductosDAL productosDAL = new ProductosDAL();
        public FrmProductos()
        {
            InitializeComponent();
            LLenarGrid();
            LimpiarEntradas();
            dgvProductos.CellClick += Seleccionar;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            dgvProductos.DataSource = productosDAL.BuscarProductosPorNombre(nombreProducto).Tables[0];
            LimpiarEntradas();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
                BtnAgregar.Enabled = true;
                RecuperarInformacion();
                MessageBox.Show("Producto agregado correctamente.");
                productosDAL.AgregarProducto(RecuperarInformacion());
                LLenarGrid();
                LimpiarEntradas();
            
            
               
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ProductosBLL producto = RecuperarInformacion();
            bool resultado = productosDAL.ActualizarProducto(producto);

            if (resultado)
            {
                MessageBox.Show("Producto modificado correctamente.");
                LLenarGrid();
                LimpiarEntradas();
            }
            else
            {
                MessageBox.Show("Error al modificar el producto.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            ProductosBLL producto = new ProductosBLL { ID = id };
            bool resultado = productosDAL.EliminarProducto(producto);

            if (resultado)
            {
                MessageBox.Show("Producto eliminado correctamente.");
                LLenarGrid();
                LimpiarEntradas();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LLenarGrid()
        {
            dgvProductos.DataSource = productosDAL.MostrarProductos().Tables[0];
        }
        private void LimpiarEntradas()
        {
            txtID.Text = "";
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";

            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = false;
        }
        private ProductosBLL RecuperarInformacion()
        {
            int id = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text);
            string nombre = txtProducto.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = string.IsNullOrEmpty(txtPrecio.Text) ? 0 : decimal.Parse(txtPrecio.Text);

            return new ProductosBLL
            {
                ID = id,
                NombreProducto = nombre,
                DescripcionProducto = descripcion,
                Precio = precio
            };
            
        
        }
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;

            if (indice >= 0 && indice < dgvProductos.Rows.Count)
            {
                txtID.Text = dgvProductos.Rows[indice].Cells[0].Value.ToString();
                txtProducto.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
                txtPrecio.Text = dgvProductos.Rows[indice].Cells[3].Value.ToString();

                BtnAgregar.Enabled = false;
                BtnModificar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnCancelar.Enabled = true;


            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
