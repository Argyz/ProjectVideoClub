using System;
using System.Drawing;
using System.Windows.Forms;
using Service.ServiceMovie;

namespace Main.FormSecondary
{
    public partial class FormRemoveMovie : Form
    {
        private int id;
        private MovieService movieService;
        private bool result;

        public FormRemoveMovie()
        {
            InitializeComponent();
            movieService = new MovieService();
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
            
            if (txtIdMovie.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id = int.Parse(txtIdMovie.Text);
                result = movieService.FindMovie(id);
                if (!result)
                {
                    MessageBox.Show("La pelicula no existe", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    movieService.Eliminar(id);
                    MessageBox.Show("Se ELIMINO de manera de correcta");
                }
            }
        }
    }
}
