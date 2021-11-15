using System;
using System.Drawing;
using System.Windows.Forms;
using Service.ServiceClient;

namespace Main.FormSecondary
{
    public partial class FormRemove : Form
    {
        private int id;
        private ClientService clientService;
        private bool result;

        public FormRemove()
        {
            InitializeComponent();
            clientService = new ClientService();   
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(255, 80, 80);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.White;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id=int.Parse(txtIdCliente.Text);
                result = clientService.findClient(id);
                if (!result)
                {
                    MessageBox.Show("La pelicula no existe", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clientService.Eliminar(id);
                    MessageBox.Show("Se ELIMINO de manera de correcta");
                }
            }
            
            
        }
    }
}
