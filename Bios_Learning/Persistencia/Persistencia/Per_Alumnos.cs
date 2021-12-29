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
    internal class Per_Alumnos:Inter_Alumnos
    {
        private static Per_Alumnos _instancia = null;

        private Per_Alumnos()
        { }


        public static Per_Alumnos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Per_Alumnos();

            return _instancia;
        }

        public void Agregar(Alumnos alumno)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("AltaAlumno", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _nom = new SqlParameter("@nom", alumno.Nombre);
            SqlParameter _ced = new SqlParameter("@ced", alumno.Cedula);
            SqlParameter _tel = new SqlParameter("@tel", alumno.Telefono);
 

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;


            int oAfectados = 0; 

            oComando.Parameters.Add(_nom);
            oComando.Parameters.Add(_ced);
            oComando.Parameters.Add(_tel);
            oComando.Parameters.Add(_Retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("Ya existe un Alumno");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
        }

        public void Inscripcion (Inscripcion ins)
        {
         
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("NuevaInscripcion ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter _ced = new SqlParameter("@ced", ins.Alumno.Cedula);
            SqlParameter _cod = new SqlParameter("@cod", ins.Curso.Codigo);

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;


            int oAfectados = 0;

            oComando.Parameters.Add(_ced);
            oComando.Parameters.Add(_cod);
            oComando.Parameters.Add(_Retorno); 



            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("No existe Curso");
                if (oAfectados == -2)
                    throw new Exception("No existe Alumno");
                if (oAfectados == -3)
                    throw new Exception("El Alumno ya esta inscripto en este Curso");
                if (oAfectados == -4)
                    throw new Exception("Error en Base de Datos");
                if (oAfectados == -5)
                    throw new Exception("No se Inscribe el Alumno, se agotaron los cupos del Curso");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problemas con la base de datos:" + ex.Message);
            }
            finally
            {
                oConexion.Close();
            }


        }

        public Alumnos Buscar(int ced)
        {
            string nombre;
            int cedula, telefono;
            Alumnos alno = null;


            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarAlumno ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter alCed = new SqlParameter("@ced", ced);

            oComando.Parameters.Add(alCed);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    cedula = (int)oReader["Cedula"];
                    telefono = (int)oReader["Telefono"];
                    nombre = (string)oReader["Nombre"];

                    alno = new Alumnos(nombre, cedula, telefono);
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
            return alno;
        }

    }
}
