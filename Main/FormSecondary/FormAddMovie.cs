using Service.ServiceMovie;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.FormSecondary
{
    public partial class FormAddMovie : Form
    {
        private MovieService service;
        private string genero;
        private string nombre;
        private string fecha;
        public FormAddMovie()
        {
            InitializeComponent();
            service = new MovieService();
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
            if (txtNombre.Text=="" || cboGender.SelectedItem==null)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre = txtNombre.Text;
                genero = cboGender.SelectedItem.ToString();
                fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
                
                
            }
        }
    }
}
