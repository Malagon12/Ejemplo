using Ejemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Datos
{
    public class ClConsultasD
    {
        public int MtdRegistrar(ClPersonaE persona)
        {
            ClAdminSQL clAdminSQL = new ClAdminSQL();
            string consulta = $"insert into usuario (rol, documento, nombre, apellido, direccion, numeroContacto, correoPersonal, edad, genero, clave) " +
                $"values('Cliente','{persona.documento}','{persona.nombres}','{persona.apellidos}','{persona.direccion}','{persona.telefono}','{persona.correo}','{persona.edad}','{persona.genero}','{persona.clave}')";
            int filasAfectadas = clAdminSQL.MtdInsertDeleteUpdate(consulta);
            return filasAfectadas;
        }
    }
}
