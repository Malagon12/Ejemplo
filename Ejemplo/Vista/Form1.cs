using Ejemplo.Entidades;
using Ejemplo.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            ClRegistrarL clRegistrarL = new ClRegistrarL();
            ClPersonaE clPersonaE = new ClPersonaE();
            clPersonaE.documento = TxtDocumento.Text;
            clPersonaE.nombres = TxtNombres.Text;
            clPersonaE.apellidos = TxtApellidos.Text;
            clPersonaE.direccion = TxtDireccion.Text;
            clPersonaE.telefono = TxtTelefono.Text;
            clPersonaE.correo = TxtMail.Text;
            clPersonaE.edad = TxtEdad.Text;
            clPersonaE.genero = TxtGenero.Text;
            clPersonaE.clave = TxtClave.Text;
            int filasAfectadas = clRegistrarL.MtdRegistrarL(clPersonaE);
            if (filasAfectadas >= 1)
            {
                MessageBox.Show("Usuario Registrado");
            }
            else if (filasAfectadas == -1)
            {
                MessageBox.Show("Usuario con documento " + TxtDocumento.Text + " ya registrado");
            }
            else
            {
                MessageBox.Show("Algo salió mal");
            }
        }
    }
}
