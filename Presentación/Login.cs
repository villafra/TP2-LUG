using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estética;
using Calculo;
using BE;
using BLL;

namespace Presentación
{
    public partial class frmLogin : Form
    {
        BLL_Login oBLL_Login;
        BE_Login oBE_Login;
        public frmLogin()
        {
            InitializeComponent();
            oBLL_Login = new BLL_Login();
            oBE_Login = new BE_Login();
            Aspecto.FormatearLogin(this, grpLogin, this.Width, this.Height);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            oBE_Login = oBLL_Login.Login(txtUsuario.Text);
            if (oBE_Login != null)
            {
                if (oBLL_Login.CheckPass(oBE_Login, txtPass.Text))
                {
                    if (oBLL_Login.Intentos(oBE_Login))
                    {
                        oBLL_Login.EscribirXML(oBE_Login);
                        frmMenu frm = new frmMenu();
                        frm.Show();
                        Calculos.BorrarCampos(grpLogin);
                        this.Hide();
                    }
                    else
                    {
                        Calculos.MsgBox("El usuario está bloqueado. Comuniquese con el Administrador");
                    }

                }
                else
                {
                    Calculos.MsgBox("La contraseña es incorrecta");
                }
               
            }
            else
            {
                Calculos.MsgBox("El usuario es inexistente");
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Calculos.Salir();
        }
        private void btnExit_Click1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            oBE_Login = oBLL_Login.Login(txtUsuario.Text);
            if (oBE_Login != null)
            {
                if (oBLL_Login.CheckPass(oBE_Login, txtPass.Text))
                {
                    if (oBLL_Login.Intentos(oBE_Login))
                    {
                        CambioPass frm = new CambioPass();
                        frm.Usuario(txtUsuario.Text);
                        frm.Show();
                    }
                    else
                    {
                        Calculos.MsgBox("El usuario está bloqueado. Comuniquese con el Administrador");
                    }

                }
                else
                {
                    Calculos.MsgBox("La contraseña es incorrecta");
                }

            }
            else
            {
                Calculos.MsgBox("El usuario es inexistente");
            }

            
        }

    }
}
