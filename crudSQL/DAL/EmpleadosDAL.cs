using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using crudSQL.BLL;
using System.IO;
using System.Drawing;


namespace crudSQL.DAL
{
    internal class EmpleadosDAL
    {
        ConexionDAL conexion;

        public EmpleadosDAL()
        {
            conexion = new ConexionDAL();
       
        }

        public bool AgregarEmpleado(EmpleadosBLL empleado)
        {

            try
            {
                if (empleado != null)
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Empleados (nombre, primerapellido, segundoapellido, avatar, correo) " +
                                                          "VALUES (@NombreEmpleado, @PrimerApellido, @SegundoApellido, @Avatar, @Correo)");

                    sqlCommand.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar).Value = empleado.NombreEmpleado;
                    sqlCommand.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = empleado.PrimerApellido;
                    sqlCommand.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = empleado.SegundoApellido;
                    sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = empleado.FotoEmpleado;
                    sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = empleado.Correo;

                    return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
                }
                else
                {
                    Console.WriteLine("El objeto empleado es nulo.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el empleado: " + ex.Message);
                return false;
            }
        }

        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool EliminarEmpleado(EmpleadosBLL empleado)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Empleados WHERE ID = @ID");
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = empleado.ID;

                return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo eliminar el empleado: " + ex.Message);
                return false;
            }
        }
        public bool ActualizarEmpleado(EmpleadosBLL empleado)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Empleados " +
                    "SET nombre = @NombreEmpleado, primerapellido = @PrimerApellido, segundoapellido = @SegundoApellido, correo = @Correo, avatar = @Avatar " +
                    "WHERE ID = @ID");
                sqlCommand.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar).Value = empleado.NombreEmpleado;
                sqlCommand.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = empleado.PrimerApellido;
                sqlCommand.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = empleado.SegundoApellido;
                sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = empleado.Correo;
                sqlCommand.Parameters.Add("@Avatar", SqlDbType.Image).Value = empleado.FotoEmpleado;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = empleado.ID;

                return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                return false;
            }
        }
        //public bool ActualizarProducto(ProductosBLL producto)
        //{
        //    try
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("UPDATE Productos " +
        //                                              "SET nombre = @NombreProducto, descripcion = @DescripcionProducto, Precio = @Precio " +
        //                                              "WHERE ID = @ID");
        //        sqlCommand.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = producto.NombreProducto;
        //        sqlCommand.Parameters.Add("@DescripcionProducto", SqlDbType.VarChar).Value = producto.DescripcionProducto;
        //        sqlCommand.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
        //        sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = producto.ID;

        //        return conexion.EjecutarComandoSinRetornoDatos(sqlCommand);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error al actualizar el producto: " + ex.Message);
        //        throw;
        //    }
        //}
        public DataSet BuscarEmpleadosPorNombre(string nombreEmpleado)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Empleados WHERE nombre LIKE @NombreEmpleado");
            sqlCommand.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar).Value = "%" + nombreEmpleado + "%";

            return conexion.EjecutarSentencia(sqlCommand);
        }
    }
}
