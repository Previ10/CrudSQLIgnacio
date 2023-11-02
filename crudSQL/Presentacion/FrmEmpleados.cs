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
using crudSQL.DAL;
using crudSQL.BLL;
using System.Drawing.Imaging;

namespace crudSQL.Presentacion
{

    public partial class FrmEmpleados : Form
    {
        private EmpleadosBLL objEmpleados;
        
        EmpleadosDAL empleadosDal = new EmpleadosDAL();
        
        byte[] imageByte;
        public FrmEmpleados()
        {
            InitializeComponent();
            LLenarGrid();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private EmpleadosBLL RecuperarInformacionEmpleados()
        {
            int id = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string primerApellido = txtPrimerApellido.Text;
            string segundoApellido = txtSegundoApellido.Text;
            int departamento = string.IsNullOrEmpty(cbxDepartamento.SelectedValue.ToString()) ? 0 : int.Parse(cbxDepartamento.SelectedValue.ToString());

            byte[] fotoEmpleado = imageByte;  

            return new EmpleadosBLL
            {
                ID = id,
                NombreEmpleado = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Departamento = departamento,
                Correo = txtCorreo.Text,  
                FotoEmpleado = fotoEmpleado
            };
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            empleadosDal.ActualizarEmpleado(RecolectarDatos());
            LLenarGrid();
            LimpiarEntradas();
        }
        

        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentosDAL objDeptodal = new DepartamentosDAL();

            cbxDepartamento.DataSource = objDeptodal.MostrarDepartamentos().Tables[0];

            cbxDepartamento.DisplayMember = "departamento";
            cbxDepartamento.ValueMember = "ID";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {

            OpenFileDialog selectorImg = new OpenFileDialog();
            selectorImg.Title = "Seleccionar Imagen";
            if (selectorImg.ShowDialog() == DialogResult.OK)
            {
                Avatar.Image = Image.FromStream(selectorImg.OpenFile());
                MemoryStream memoria = new MemoryStream();

                Avatar.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                imageByte = memoria.ToArray();
            }
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RecolectarDatos();
            MessageBox.Show("Conectado... ");
            empleadosDal.AgregarEmpleado(RecolectarDatos());
            LLenarGrid();
            LimpiarEntradas();


        }


        private EmpleadosBLL RecolectarDatos()
        {
            EmpleadosBLL objEmpleados = new EmpleadosBLL();
            int codigoEmpleado = 1;
            int.TryParse(txtID.Text, out codigoEmpleado);
            objEmpleados.ID = codigoEmpleado;
            objEmpleados.NombreEmpleado = txtNombre.Text;
            objEmpleados.PrimerApellido = txtPrimerApellido.Text;
            objEmpleados.SegundoApellido = txtSegundoApellido.Text;
            objEmpleados.Correo = txtCorreo.Text;

            int IDdepartamento = 0;
            int.TryParse(cbxDepartamento.SelectedValue.ToString(), out IDdepartamento);
            objEmpleados.Departamento = IDdepartamento;
            objEmpleados.FotoEmpleado = imageByte;


            return objEmpleados;
        }

        private void LimpiarEntradas()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";


            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnExaminar.Enabled = true;
        }


        private void LLenarGrid()
        {
            dgvEmpleados.DataSource = empleadosDal.MostrarEmpleados().Tables[0];

            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                row.Cells["avatar"].ReadOnly = true;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int avatarColumnIndex = dgvEmpleados.Columns["avatar"].Index;

            if (e.ColumnIndex == avatarColumnIndex)
            {
                e.ThrowException = false;
                e.Cancel = true;

                MessageBox.Show("Error al cargar la imagen.");
            }
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            empleadosDal.EliminarEmpleado(RecolectarDatos());
            LLenarGrid();
            LimpiarEntradas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

                txtID.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
                txtPrimerApellido.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
                txtSegundoApellido.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
                 txtCorreo.Text = dgvEmpleados.Rows[indice].Cells[5].Value.ToString();


            btnAgregar.Enabled = false;
            btnBorrar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnExaminar.Enabled = true;
        }
    }
}
