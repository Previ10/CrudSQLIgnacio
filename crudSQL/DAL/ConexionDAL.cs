using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace crudSQL.DAL
{
    internal class ConexionDAL
    {
        private String CadenaConexion = "Data Source=LAPTOP-HU76VL42; Initial Catalog=dbSistema; Integrated Security=True";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion() { 
            
            this.Conexion =new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        
        
        }
        public bool EjecutarComandoSinRetornoDatos(string strComando)
        {
            using (SqlConnection conexion = EstablecerConexion())
            {
                try
                {
                    SqlCommand Comando = new SqlCommand();
                    Comando.CommandText = strComando;
                    Comando.Connection = conexion;
                    conexion.Open();
                    Comando.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        //sobrecarga: utilizamos el mismo metodo , pasandole otros argumentos.
        //a tener en cuenta.
        public bool EjecutarComandoSinRetornoDatos(SqlCommand SqlComando)
        {
            using (SqlConnection conexion = EstablecerConexion())
            {
                try
                {
                    SqlCommand Comando = SqlComando;
                    Comando.Connection = conexion; 
                    conexion.Open();
                    Comando.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public DataSet EjecutarSentecia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter sqlAdaptador = new SqlDataAdapter();
            try
            {
                sqlComando.Connection = EstablecerConexion();
                sqlAdaptador.SelectCommand = sqlComando;
                Conexion.Open();
                sqlAdaptador.Fill(DS);
                Conexion.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
        }
        public DataSet EjecutarSentencia(SqlCommand sqlCommand)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            try
            {
                sqlCommand.Connection = EstablecerConexion();
                sqlAdapter.SelectCommand = sqlCommand;
                sqlCommand.Connection.Open();
                sqlAdapter.Fill(DS);
                sqlCommand.Connection.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
        }



    }
}
