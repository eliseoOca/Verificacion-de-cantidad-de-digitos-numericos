using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Verificacion_de_cantidad_de_digitos_numericos
{
    public partial class VerificarCantNum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            string input = txtNumero.Text.Trim();

            if (IsNumeric(input))
            {
                int cantidadDigitos = input.Length;
                lblResultado.Text = $"El numero ingresado es Valido y tiene {cantidadDigitos} digitos.";
            }
            else
            {
                lblResultado.Text = "El valor ingresado no es numero valido. ";
            }
        }
        private bool IsNumeric(string input)
        {
            double temp;
            return double.TryParse(input, out temp);
        }
    }
}