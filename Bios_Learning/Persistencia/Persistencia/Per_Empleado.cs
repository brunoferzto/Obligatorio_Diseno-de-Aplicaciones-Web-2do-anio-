using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class Per_Empleado : Inter_Empleado
    {
        private static Per_Empleado _instancia = null;

        private Per_Empleado()
        {  }

      
        public static Per_Empleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Per_Empleado();

            return _instancia;
        }

       //----------------------------------------------------------------------------------------------
        public Empleado BuscarActivo (string Usu)
        {
            string usuario, contraseña;
            Empleado emp = null;

            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarEmpleadoActivo ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@usu", Usu);
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    usuario = (string)oReader["Usuario"];
                    contraseña = (string)oReader["Contraseña"];

                    emp = new Empleado(usuario, contraseña); 


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return emp;

        }
       internal  Empleado BuscarTodos(string Usu)
        {
            string usuario, contraseña;
            Empleado emp = null;

            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarTodosEmpleados ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@usu", Usu);
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    usuario = (string)oReader["Usuario"];
                    contraseña = (string)oReader["Contraseña"];

                    emp = new Empleado(usuario, contraseña);


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return emp;

        }
        public void Registrar(Empleado e)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("RegistarEmpleado ", oConexion); //ortograf
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@usu", e.Usuario);
            oComando.Parameters.AddWithValue("@pas", e.Contraseña);
            SqlParameter pRET = new SqlParameter("@Retorno", SqlDbType.Int);
            pRET.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(pRET);
            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El nombre de usuario ya existe");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
        


    }

        public void Modificar (Empleado e)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ModificarEmpleado ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@usu", e.Usuario);
            oComando.Parameters.AddWithValue("@pas", e.Contraseña);
            SqlParameter pRET = new SqlParameter("@Retorno", SqlDbType.Int);
            pRET.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(pRET);
            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("No existe Empleado");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }

        }

        public Empleado Logueo (Empleado emp) 
        {
            string usuario, contraseña;
            Empleado empl = null;

            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Logueo ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@usu", emp.Usuario);
            oComando.Parameters.AddWithValue("@pas", emp.Contraseña);
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    usuario = (string)oReader["Usuario"];
                    contraseña = (string)oReader["Contraseña"];
                    empl = new Empleado(usuario, contraseña);


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return empl;

        }

        public List<Empleado> Listar()
        {
            string usuario, contraseña;
            Empleado emp = null;
            List<Empleado> listEmpl = null;

            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ListaEmpleados ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                while (oReader.Read())
                {
                    usuario = (string)oReader["Usuario"];
                    contraseña = (string)oReader["Contraseña"];

                    emp = new Empleado(usuario, contraseña);
                    listEmpl.Add(emp);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return listEmpl;
        }

        public void Eliminar(Empleado emp)
        {

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BajaEmpleado ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter usu = new SqlParameter("@usu", emp.Usuario);
            SqlParameter pRET = new SqlParameter("@Retorno", SqlDbType.Int);
            pRET.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(pRET);
            oComando.Parameters.Add(usu);
            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                int afectados = (int)oComando.Parameters["@Retorno"].Value;
                if (afectados == -1)
                    throw new Exception("No existe Empleado");
                if (afectados == -2)
                    throw new Exception("Error en Base de Datos");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }

        }

    }
}
