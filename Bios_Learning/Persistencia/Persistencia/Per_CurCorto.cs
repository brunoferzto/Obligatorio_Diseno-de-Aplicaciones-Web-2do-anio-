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
    internal class Per_CurCorto:Inter_CurCorto
    {
            private static Per_CurCorto _instancia = null;

            private Per_CurCorto()
            { }


            public static Per_CurCorto GetInstancia()
            {
                if (_instancia == null)
                    _instancia = new Per_CurCorto();

                return _instancia;
            }

        public void Agregar (Cortos Un_Curso)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("NuevoCursoCorto", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _Cod = new SqlParameter("@Cod", Un_Curso.Codigo);
            SqlParameter _Nom = new SqlParameter("@Nom", Un_Curso.Nombre);
            SqlParameter _Cupos = new SqlParameter("@Cupos", Un_Curso.Cupos);
            SqlParameter _Costo = new SqlParameter("@Costo", Un_Curso.Costo);
            SqlParameter _FechaI = new SqlParameter("@Fecha", Un_Curso.Fecha_Inicio);
            SqlParameter _Local = new SqlParameter("@Local", Un_Curso.Local.Nombre);
            SqlParameter _Emple = new SqlParameter("@Emple", Un_Curso.Empleados.Usuario);
            SqlParameter _Area = new SqlParameter("@Area", Un_Curso.Area);

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;


            int oAfectados = 0;

            oComando.Parameters.Add(_Cod);
            oComando.Parameters.Add(_Nom);
            oComando.Parameters.Add(_Cupos);
            oComando.Parameters.Add(_Costo);
            oComando.Parameters.Add(_FechaI);
            oComando.Parameters.Add(_Local);
            oComando.Parameters.Add(_Emple);
            oComando.Parameters.Add(_Area);
            oComando.Parameters.Add(_Retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("Ya existe un Curso con el Código asignado");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");
                if (oAfectados == -3)
                    throw new Exception("No existe Sucursal ");
                if (oAfectados == -4)
                    throw new Exception("No existe Empleado ");
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
        public void Eliminar  (Cortos Un_Curso)
        {

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("EliminarCursoCorto ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter Cod = new SqlParameter("@Cod", Un_Curso.Codigo);
            SqlParameter pRET = new SqlParameter("@Retorno", SqlDbType.Int);
            pRET.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(pRET);
            oComando.Parameters.Add(Cod);
            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                int afectados = (int)oComando.Parameters["@Retorno"].Value;
                if (afectados == -1)
                    throw new Exception("El Curso tiene Inscripciones y no puede eliminarse");
                if (afectados == -2)
                    throw new Exception("Error en Base de Datos");
                if (afectados == -3)
                    throw new Exception("El código no corresponde a un curso");
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
        public void Modificar (Cortos Un_Curso)
        {

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ModificarCursoCorto ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@Cod", Un_Curso.Codigo);
            oComando.Parameters.AddWithValue("@Nom", Un_Curso.Nombre);
            oComando.Parameters.AddWithValue("@Cupos", Un_Curso.Cupos);
            oComando.Parameters.AddWithValue("@Costo", Un_Curso.Costo);
            oComando.Parameters.AddWithValue("@Fecha", Un_Curso.Fecha_Inicio);
            oComando.Parameters.AddWithValue("@Local", Un_Curso.Local.Nombre);
            oComando.Parameters.AddWithValue("@Emple", Un_Curso.Empleados.Usuario);
            oComando.Parameters.AddWithValue("@Area", Un_Curso.Area);

            SqlParameter retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(retorno);
            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

             int  oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El código no corresponde a un curso");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");
                if (oAfectados == -3)
                    throw new Exception("No existe Sucursal");
                if (oAfectados == -4)
                    throw new Exception("No existe Empleado");
                if (oAfectados == -5)
                    throw new Exception("No se puede Ingesar menos 'Cupos' que los ya inscriptos");
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
        public List<Cortos> Listar () 
        {
            string nombre, codigo, area, usuBuscar, sucursalbuscar;
            int costo, cupos;
            DateTime fechainicio;

     
            Cortos CursoCorto = null;
            List<Cortos> list_Corto = new List<Cortos>() ;

            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);

            SqlCommand oComando = new SqlCommand("ListadoCortos ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                while (oReader.Read())
                {
                    costo = (int)oReader["Costo"];
                    cupos = (int)oReader["Cupos"];
                    nombre = (string)oReader["Nombre"];
                    codigo = (string)oReader["Codigo"];
                    area = (string)oReader["Area"];
                    usuBuscar = (string)oReader["Empleado"];
                    sucursalbuscar = (string)oReader["Sucursal"];

                    fechainicio = (DateTime)oReader["FechaInicio"];

                    Per_Sucursual oSuc = Per_Sucursual.GetInstancia();
                    Per_Empleado oEmp = Per_Empleado.GetInstancia();

                    CursoCorto = new Cortos(area, nombre, codigo, costo, cupos, fechainicio,
                                            oSuc.BuscarTodas(sucursalbuscar), oEmp.BuscarTodos(usuBuscar));
                    list_Corto.Add(CursoCorto);

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
            return list_Corto;


        }
        public Cortos Buscar (string cod)
        {
            string nombre, codigo, area, usuBuscar, sucursalbuscar;
            int  cupos, costo; 
            DateTime fechainicio;

            Cortos CursoCorto = null;

            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarcCorto ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@cod", cod);
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    costo = (int)oReader["Costo"];
                    cupos = (int)oReader["Cupos"];
                    nombre = (string)oReader["Nombre"];
                    codigo = (string)oReader["Codigo"];
                    area = (string)oReader["Area"];
                    usuBuscar = (string)oReader["Empleado"];
                    sucursalbuscar = (string)oReader["Sucursal"];

                    fechainicio = (DateTime)oReader["FechaInicio"];

                    Per_Sucursual oSuc = Per_Sucursual.GetInstancia();
                    Per_Empleado oEmp = Per_Empleado.GetInstancia();


                    CursoCorto = new Cortos(area, nombre, codigo, costo, cupos, fechainicio, oSuc.BuscarTodas(sucursalbuscar) , oEmp.BuscarTodos(usuBuscar));

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
            return CursoCorto;
        }


    }
}
