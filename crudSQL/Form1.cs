using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crudSQL.Presentacion;
using System.Windows.Forms;

namespace crudSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDepartamentos formulariodeptos = new FrmDepartamentos();
            formulariodeptos.Show();
        }

        private void btnTabEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleados FrmEmpleados = new FrmEmpleados();
            FrmEmpleados.Show();
        }

        private void btnTabProductos_Click(object sender, EventArgs e)
        {
            FrmProductos FrmProductos = new FrmProductos();
            FrmProductos.Show();
        }
    }
}
