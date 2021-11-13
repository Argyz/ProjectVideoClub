using Service.ServiceClient;
using Service.ServiceClient.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Main.FormSecondary
{
    public partial class FormAdd : Form
    {
        private ClientService clientService;
        private string nombre;
        private string apellido;
        private string pelicula;
        public FormAdd()
        {
            InitializeComponent();
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
            if (txtName.Text == "" || txtPelicula.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre = txtName.Text;
                apellido = txtLastName.Text;
                pelicula = txtPelicula.Text;
                var dto = new ClientDto() { Name = nombre, LastName = apellido, Pelicula = pelicula };
                clientService.Agregar(dto);
                MessageBox.Show("El cliente se cargo exitosamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtPelicula.Text = ""; 
        }
    }
}
