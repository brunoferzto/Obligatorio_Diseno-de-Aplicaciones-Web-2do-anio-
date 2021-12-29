using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Empleado
    {
        string usuario, contraseña;

        public string Usuario
        {
            get { return usuario; }
            set {
                if (Convert.ToString(value).Length != 10)
                    throw new Exception("El nombre de Logueo debe de tener 10 caracteres");
                else
                    usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set {
                if (value.Length < 4 || value.Length > 20 )
                        throw new Exception("Error, la contraseña debe Contener 4-20 caracteres");
                    else
                        contraseña = value; }
        }

        public Empleado (string usu, string contra)
        {
            Usuario = usu;
            Contraseña = contra; 
        }

    }
}
