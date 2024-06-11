using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Datos
{
    public class ClAdminSQL
    {
        public DataTable MtdSelect(string consulta)
        {
            ClConexion objClconexion = new ClConexion();
            SqlConnection connection = objClconexion.MtdAbrirConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, connection);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objClconexion.MtdCerrarConexion();
            return tblDatos;
        }

        public int MtdInsertDeleteUpdate(String consulta)
        {
            ClConexion objClconexion = new ClConexion();
            SqlConnection connection = objClconexion.MtdAbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, connection);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }

    }
}
