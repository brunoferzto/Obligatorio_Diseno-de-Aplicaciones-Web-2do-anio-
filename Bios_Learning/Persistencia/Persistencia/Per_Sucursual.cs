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
    internal class Per_Sucursual:Inter_Sucursal
    {
    
        private static Per_Sucursual _instancia = null;

        private Per_Sucursual()
        { }


        public static Per_Sucursual GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Per_Sucursual();

            return _instancia;
        }

        // ------------------------------------------------------------------------------------------
        public void Agregar(Sucursales S)
        {

            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _commando = new SqlCommand("RegistroSucursal ", _cnn);
            _commando.CommandType = CommandType.StoredProcedure;
            _commando.Parameters.AddWithValue("@nom", S.Nombre);
            _commando.Parameters.AddWithValue("@dire", S.Direccion);


            SqlParameter _ParamRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParamRetorno.Direction = ParameterDirection.ReturnValue;
            _commando.Parameters.Add(_ParamRetorno);

            SqlTransaction _miTransacion = null;
            try
            {
                _cnn.Open();
                _miTransacion = _cnn.BeginTransaction();
                _commando.Transaction = _miTransacion;
                _commando.ExecuteNonQuery();

                int ret = Convert.ToInt32(_ParamRetorno.Value);
                if (ret == -1)
                    throw new Exception("Ya hay una Sucursal con el nombre ingresado");
                else if (ret == -2)
                    throw new Exception("Error en Base de Datos ");

                foreach (string facin in S.Facilidad)
                {

                    Per_Facilidades.RegistroFacilidad(S.Nombre, facin, _miTransacion);
                }


                _miTransacion.Commit();
            }
            catch (Exception ex)
            {
                _miTransacion.Rollback();
                throw ex;
            }

            finally
            {
                _cnn.Close();
            }

        }
        public void Eliminar(Sucursales s)
        {

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("EliminarSucursal ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter Cod = new SqlParameter("@nom", s.Nombre);
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
                    throw new Exception("No existe sucursal con el nombre especificado");
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
        public void Modificar (Sucursales s)
        {
             
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ModificarSucursal ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            SqlParameter _Dir = new SqlParameter("@dire", s.Direccion);
            SqlParameter _Nom = new SqlParameter("@nom", s.Nombre);

            SqlParameter retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(retorno);
            oComando.Parameters.Add(_Dir);
            oComando.Parameters.Add(_Nom);

            SqlTransaction _miTransacion = null;
            try
            {
                oConexion.Open();
                _miTransacion = oConexion.BeginTransaction(); 
                oComando.Transaction = _miTransacion; 
                oComando.ExecuteNonQuery();

                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("No existe Sucursal");
                if (oAfectados == -2)
                    throw new Exception("Error en Base de Datos");
                else
                {
                    Per_Facilidades.EliminarFacilidades(s, _miTransacion); 

                    foreach (string facilidad in s.Facilidad)
                    {
                        Per_Facilidades.RegistroFacilidad(s.Nombre, facilidad, _miTransacion);

                    }
                }
                _miTransacion.Commit();

            }
            catch (Exception ex)
            {
                _miTransacion.Rollback();
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
        }
         internal Sucursales BuscarTodas (string sucu)
        {

            string nombre ,direccion;
            Sucursales sucual = null; 

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarTodasSucursales ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@sucu", sucu);
            try
            {
                oConexion.Open();
                SqlDataReader oReader = oComando.ExecuteReader();

                if (oReader.HasRows)
                {
                    oReader.Read(); 
                    nombre = (string)oReader["Nombre"];
                    direccion = (string)oReader["Direccion"];
                    sucual = new Sucursales (nombre, direccion, Per_Facilidades.BuscarFacilidad(nombre));             
                  

                }
                oReader.Close(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return sucual;

        
    }
        public Sucursales BuscarActivas (string sucu)
        {

            string nombre, direccion;
            Sucursales sucual = null;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarSucursalActiva ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@sucu", sucu);
            try
            {
                oConexion.Open();
                SqlDataReader oReader = oComando.ExecuteReader();

                while (oReader.Read())
                {
                    nombre = (string)oReader["Nombre"];
                    direccion = (string)oReader["Direccion"];
                    sucual = new Sucursales(nombre, direccion, Per_Facilidades.BuscarFacilidad(nombre));
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return sucual;


        }
        public List<Sucursales>Listar()
        {
            string nombre, direccion;
            Sucursales sucual = null;

            List<Sucursales> lista = new List<Sucursales>(); 

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ListarSucursal ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            try
            {
                oConexion.Open();
                SqlDataReader oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        nombre = (string)oReader["Nombre"];
                        direccion = (string)oReader["Direccion"];
                        sucual = new Sucursales(nombre, direccion, Per_Facilidades.BuscarFacilidad(nombre));
                      
                        lista.Add(sucual);
                    }
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                oConexion.Close();
            }
            return lista;


        }
    }
}
