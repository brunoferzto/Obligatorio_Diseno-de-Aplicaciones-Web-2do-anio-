using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class Conexion
    {
        private static string _cnn = @"Data Source = DESKTOP-9RS7HI4\SQLEXPRESS; Initial Catalog = BiosLearningDB; Integrated Security = true";

        public static string Cnn
        {
            get { return _cnn; }
        }

    }
}
