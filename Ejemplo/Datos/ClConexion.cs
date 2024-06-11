using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Datos
{
    public class ClConexion
    {
        private SqlConnection oConexion = null;
        public ClConexion()
        {
            oConexion = new SqlConnection("Data Source=.;Initial Catalog=dbProyecto;Integrated Security=True");
        }

        public SqlConnection MtdAbrirConexion()
        {
            oConexion.Open();
            return oConexion;

        }
        public void MtdCerrarConexion()
        {
            oConexion.Close();
            oConexion.Dispose();
        }
    }
}
