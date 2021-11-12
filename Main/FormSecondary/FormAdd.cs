using System;
using System.Drawing;
using System.Windows.Forms;
using Service.Client;
using Service.Client.DTOs;

namespace Main.FormSecondary
{
    public partial class FormAdd : Form
    {
        private ClientService clientService;
        public FormAdd()
        {
            clientService = new ClientService();
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
           btnAceptar.BackColor = Color.FromArgb(0, 204, 153);
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.White;
        }

        private void btnLimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackColor = Color.FromArgb(255, 80, 80);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.White; 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="" || txtUser.Text=="" || txtLastName.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                var dto = new ClientDto() { Name=txtName.Text, LastName=txtLastName.Text, User=txtUser.Text, Removed=false};
                clientService.Agregar(dto);
            }
        }
    }
}
