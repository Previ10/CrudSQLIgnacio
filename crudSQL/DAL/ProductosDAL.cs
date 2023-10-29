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
    internal class ProductosDAL
    {
        ConexionDAL conexion;

        public ProductosDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool AgregarProducto(ProductosBLL producto)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Productos (nombre, descripcion, Precio) " +
                                                  "VALUES (@NombreProducto, @DescripcionProducto, @Precio)");
            sqlCommand.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = producto.NombreProducto;
            sqlCommand.Parameters.Add("@DescripcionProducto", SqlDbType.VarChar).Value = producto.DescripcionProducto;
            sqlCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;

            return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public DataSet MostrarProductos()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Productos");
            return conexion.EjecutarSentencia(sqlCommand);
        }

        public bool EliminarProducto(ProductosBLL producto)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Productos WHERE ID = @ID");
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = producto.ID;

                return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("No se pudo eliminar el producto: " + ex.Message);
                return false; 
            }
        }

        public bool ActualizarProducto(ProductosBLL producto)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Productos " +
                                                      "SET nombre = @NombreProducto, descripcion = @DescripcionProducto, Precio = @Precio " +
                                                      "WHERE ID = @ID");
                sqlCommand.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = producto.NombreProducto;
                sqlCommand.Parameters.Add("@DescripcionProducto", SqlDbType.VarChar).Value = producto.DescripcionProducto;
                sqlCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = producto.ID;

                return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el producto: " + ex.Message);
                throw;
            }
        }
        public DataSet BuscarProductosPorNombre(string nombreProducto)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Productos WHERE nombre LIKE @NombreProducto");
            sqlCommand.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = "%" + nombreProducto + "%";

            return conexion.EjecutarSentencia(sqlCommand);
        }

    }
}