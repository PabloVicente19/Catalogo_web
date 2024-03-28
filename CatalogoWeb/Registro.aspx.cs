using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
            if (IsPostBack)
                txtNombre_error.InnerHtml = "";
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
            if (IsPostBack)
            {
                string nombre = ValidarCampo(txtNombre, "Nombre", txtNombre_error);
                string apellido = ValidarCampo(txtApellido, "apellido", txtApellido_error);
                string email = ValidarCampo(txtEmail, "email", txtEmail_error);
                string contraseña = ValidarCampo(txtContraseña, "Contraseña", txtContraseña_error);
            }
        }
        private string ValidarCampo(TextBox campo, string nombreDelCampo, HtmlGenericControl idSmall)
        {
            string valor = null;

            if (campo.Text.Trim().Length > 2)
                valor = campo.Text;
            else
                MostrarError(nombreDelCampo, idSmall);
            return valor;
        }
        private void MostrarError(string message, HtmlGenericControl tag)
        {
            tag.InnerHtml = $"¡{message} incorrecto!";
        }
    }
}