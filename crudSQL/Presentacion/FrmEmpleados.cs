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

namespace crudSQL.Presentacion
{
    public partial class FrmEmpleados : Form
    {
        byte[] imageByte;
        public FrmEmpleados()
        {
            InitializeComponent();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

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
        }
        private void RecolectarDatos()
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
            objEmpleados.FotoEmpleado= imageByte;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
