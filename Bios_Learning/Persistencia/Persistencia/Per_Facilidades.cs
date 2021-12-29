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
    internal class Per_Facilidades
    {
        internal static void RegistroFacilidad(string sucu, string fac, SqlTransaction trans)
        {
            SqlCommand _command = new SqlCommand("FacilidadesAlta", trans.Connection);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@fac", fac);
            _command.Parameters.AddWithValue("@sucu", sucu);
            SqlParameter _parRetor = new SqlParameter("@Retorno", SqlDbType.Int);
            _parRetor.Direction = ParameterDirection.ReturnValue;
            _command.Parameters.Add(_parRetor);
            try
            {
                _command.Transaction = trans;
                _command.ExecuteNonQuery();
                int retorno = Convert.ToInt32(_parRetor.Value);

                if (retorno == -1)
                    throw new Exception("Ya se inscribió esta Facilidad");
                if (retorno == -2)
                    throw new Exception("No existe Sucursal");
                if (retorno == -3)
                    throw new Exception("Error en Base de Datos");
                if (retorno == -4)
                    throw new Exception("Error, la Sucursal existe pero no está activa");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal static void EliminarFacilidades(Sucursales sucu, SqlTransaction trans)
        {
            SqlCommand _comando = new SqlCommand("ElimiXsucursal", trans.Connection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sucu", sucu.Nombre);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);


            try
            {

                _comando.Transaction = trans;
                _comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal static List<string> BuscarFacilidad (string sucu)
        {
            List<string> lista = new List<string>();
            string nombre; 

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarFacilidades ", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@sucu", sucu);
            try
            {
                oConexion.Open();
                SqlDataReader _lector = oComando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        nombre = (string)_lector["Facilidad"];
                        lista.Add(nombre);
                    }
                }

                _lector.Close();
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
