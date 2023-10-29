using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using crudSQL.BLL;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudSQL.DAL
{
    internal class DepartamentosDAL
    {
        //EN ESTA CAPA VAN TODOS LOS COMANDOS SQL DEL FORMULARIO DEPARTAMENTOS
        ConexionDAL conexion;
        public DepartamentosDAL()
        {
            conexion = new ConexionDAL();
        }
        public bool Agregar(DepartamentoBLL oDepartamentoBLL)
        {
            //return conexion.EjecutarComandoSinRetornoDatos("INSERT INTO departamentos (departamento) VALUES ('" + oDepartamentoBLL.Departamento+"')");
            SqlCommand SQLComando = new SqlCommand("INSERT INTO departamentos VALUES (@departamente)");
            SQLComando.Parameters.Add("@departamente", SqlDbType.VarChar).Value = oDepartamentoBLL.Departamento;
            return conexion.EjecutarComandoSinRetornoDatos(SQLComando);

        }
        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM departamentos");
            return conexion.EjecutarSentecia(sentencia);
        }
        public bool Eliminar(DepartamentoBLL oDepartamentoBLL)
        {
            try { 
                    SqlCommand SQLComando = new SqlCommand("DELETE FROM departamentos WHERE ID=@ID");
                    SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentoBLL.ID;
                    return conexion.EjecutarComandoSinRetornoDatos(SQLComando);
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message);
                return false;
            }

            // conexion.EjecutarComandoSinRetornoDatos("DELETE FROM departamentos WHERE ID =" + oDepartamentoBLL.ID );
            //return 1;

        }

        public bool Modificar(DepartamentoBLL oDepartamentoBLL)
        {
            try
            {

                SqlCommand SQLComando = new SqlCommand("UPDATE departamentos SET departamento =@departamente WHERE ID=@ID");
                SQLComando.Parameters.Add("@departamente", SqlDbType.VarChar).Value = oDepartamentoBLL.Departamento;
                SQLComando.Parameters.Add("@ID", SqlDbType.VarChar).Value = oDepartamentoBLL.ID;
                return conexion.EjecutarComandoSinRetornoDatos(SQLComando);
                //conexion.EjecutarComandoSinRetornoDatos("UPDATE departamentos " +
                //    "SET departamento='" + oDepartamentoBLL.Departamento + "'" +
                //    " WHERE ID =" + oDepartamentoBLL.ID);
                //return 1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message);
                return false;
            }
        }
    }
}
