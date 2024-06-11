using Ejemplo.Datos;
using Ejemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Logica
{
    public class ClRegistrarL
    {
        public int MtdRegistrarL(ClPersonaE Persona)
        {
            ClConsultasD objConsulta = new ClConsultasD();
            int filas = objConsulta.MtdRegistrar(Persona);
            return filas;
        }
    }
}
