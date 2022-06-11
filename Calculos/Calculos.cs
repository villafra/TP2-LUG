using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public static class Calculos
    {

        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            string s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.KeyChar = char.Parse(s);
            }
            else
            {
                e.Handled = false;
            }

        }
        public static void ValidarEnteros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        public static void ValidarLetras(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        public static bool ValidarLargoString(Control control, int largo)
        {
            if (control.Text.Length > largo)
            {
                return false;
            }
            else { return true; }
        }

        public static void BorrarCampos(Control grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    text.Text = null;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = c as NumericUpDown;
                    num.Value = 0;
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    combo.Text = null;
                }
                else if (c is CheckBox)
                {
                    CheckBox check = c as CheckBox;
                    check.Checked = false;
                }
            }
        }
        public static bool Camposvacios(Control grp)
        {
            int sino = 0;
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    if (text.Text == "")
                    {
                        sino = 1;
                    }
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = c as NumericUpDown;
                    if (num.Value == 0)
                    {
                        sino = 1;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.Text == "")
                    {
                        sino = 1;
                    }
                }
            }
            return sino == 0;
        }
        public static void RefreshGrilla(DataGridView dgv, object refObject)
        {
            dgv.DataSource = null;
            dgv.DataSource = refObject;
        }
        public static void GrillaEnBlanco(DataGridView dgv)
        {
            dgv.DataSource = null;
        }
 
        public static void DataSourceCombo(ComboBox combo, object refObject, string DisplayMember)
        {
            combo.DataSource = null;
            combo.DataSource = refObject;
            combo.ValueMember = "Codigo";
            combo.DisplayMember = DisplayMember;
            combo.Refresh();

        }

        public static void MsgBox(string mensaje)
        {
            MessageBox.Show(mensaje, "Restó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Salir()
        {
            System.Windows.Forms.Application.Exit();
        }

        public static bool EstaSeguro(string objeto, int codigo, string nombre)
        {
            DialogResult resultado;
            resultado = MessageBox.Show(@"Esta seguro que desea " + objeto + ": " + nombre + "\n Numero: " + codigo.ToString() + "?", objeto, MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
