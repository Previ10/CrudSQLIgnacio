using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crudSQL.BLL;
using crudSQL.DAL;
using System.Windows.Forms;

namespace crudSQL.Presentacion
{
    public partial class FrmDepartamentos : Form
    {

       DepartamentosDAL oDepartamentosDal = new DepartamentosDAL();
        public FrmDepartamentos()
        {
            InitializeComponent();
            //ACTUALIZAR LA TABLA:
            LLenarGrid();
            LimpiarEntradas();
            //dgvDepartamentos.DataSource = oDepartamentosDal.MostrarDepartamentos().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            RecuperarInformacion();
            MessageBox.Show("Conectado... ");
            oDepartamentosDal.Agregar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }
       
        private DepartamentoBLL RecuperarInformacion()
        {
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL();
            int ID = 0; int.TryParse(txIDdepartamento.Text, out ID);
            oDepartamentoBLL.ID = ID;
            oDepartamentoBLL.Departamento = txtNombreDepartamento.Text;

            

            return oDepartamentoBLL;

        }
         private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

         }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void txIDdepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }
        //metodo para seleccionar informacion a traves del datagrid
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            
            //dgvDepartamentos.ClearSelection();

            if (indice >= 0 && indice < dgvDepartamentos.Rows.Count)
            {
                txIDdepartamento.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
                txtNombreDepartamento.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();

                btnAgregarDepartamento.Enabled = false;
                btnBorrarDepartamento.Enabled = true;
                btnModificarDepartamento.Enabled = true;
                btnCancelarDepartamento.Enabled = true;


            }
            else
            {
                
            }
        }

        private void btnBorrarDepartamento_Click(object sender, EventArgs e)
        {
            oDepartamentosDal.Eliminar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }

        private void btnModificarDepartamento_Click(object sender, EventArgs e)
        {
            oDepartamentosDal.Modificar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }
        public void LLenarGrid()
        {
            dgvDepartamentos.DataSource = oDepartamentosDal.MostrarDepartamentos().Tables[0];
            dgvDepartamentos.Columns[0].HeaderText = "ID";
            dgvDepartamentos.Columns[1].HeaderText = "Nombre Departamento";


        }
        public void LimpiarEntradas()
        {
            txIDdepartamento.Text = "";
            txtNombreDepartamento.Text = "";

            btnAgregarDepartamento.Enabled = true;
            btnBorrarDepartamento.Enabled = false;
            btnModificarDepartamento.Enabled = false;
            btnCancelarDepartamento.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }   
}
