using Service.ServiceLogin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Login
{
    public partial class FormLogin : Form
    {
        private LoginService loginService;
        public FormLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text=="USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text=="")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var resp=loginService.Acceder(txtUser.Text,txtPass.Text);
            
            if (resp != true)
            {
                MessageBox.Show("El usuario o contraseña es incorrecto");
            }
            else
            {
                this.Close();
            }
        }
    }
}
