using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial_y_Ferreteria_Sumar.Clases
{
    public class Validaciones : Funciones
    {
        public void sololetras(TextBox t, KeyPressEventArgs ex)
        {

            if (Char.IsLetter(ex.KeyChar))
            {
                ex.Handled = false;
            }
            else if (Char.IsControl(ex.KeyChar))
            {
                ex.Handled = false;
            }
            else if (Char.IsSeparator(ex.KeyChar))
            {
                ex.Handled = false;
            }
            else
            {
                ex.Handled = true;
            }
        }

        public void solonumeros(TextBox t, KeyPressEventArgs ex)
        {
            if (Char.IsDigit(ex.KeyChar))
            {
                ex.Handled = false;
            }
            else if (Char.IsControl(ex.KeyChar))
            {
                ex.Handled = false;
            }
            else
            {
                ex.Handled = true;
            }

        }

        public void validarvacios(TextBox texto, ErrorProvider error)
        {
            if (texto.Text == "")
            {
                error.SetError(texto, "El campo no puede estar vacio");
            }
            else
            {
                error.SetError(texto, "");
            }
        }

    }
}
