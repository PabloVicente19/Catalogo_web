using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRegistrarUsuario.Enabled = false;
            
        }
        /*
        - si los campos estan vacios no se puede agregar.
        - si algun campo esta incompleto no se puede agregar
        - si algun campo no cumple con los criteros cambiar la ui para que lo modifique
        - emplear regex para el email
        - el nombre no puede contener números 
        - apellido no puede contener números
        */
        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
        }

        private string ValidarCampo(TextBox campo)
        {
            
            string valor = string.Empty;
            if (campo.Text.Length > 2)
            {
                valor = campo.Text;
            }
            return valor;
        }
        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validacion(txtNombre);
        }
    }
}