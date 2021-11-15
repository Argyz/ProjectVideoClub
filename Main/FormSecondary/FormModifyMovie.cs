using Service.ServiceMovie;
using System;
using System.Drawing;
using System.Windows.Forms;
using Service.ServiceMovie.DTOs;
namespace Main.FormSecondary
{
    public partial class FormModifyMovie : Form
    {
        private MovieDto dto;
        private MovieService service;
        private string gender;
        private string nombre;
        private string fecha;
        private int id;
        private bool result;
        private int cantidad;
        public FormModifyMovie()
        {
            InitializeComponent();
            service = new MovieService();
            dto = new MovieDto();
        }

        private void btnBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuscar.BackColor = Color.FromArgb(52, 128, 235);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.White;
        }


        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(0, 204, 153);
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.White;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtIdMovie.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id = int.Parse(txtIdMovie.Text);
                result = service.FindMovie(id);

                if (!result)
                {
                    MessageBox.Show("La pelicula no existe", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var returndto = service.getPelicula(id);

                    txtName.Enabled = true;
                    txtName.Text = returndto.Name;
                    cboGender.Enabled = true;
                    cboGender.SelectedItem = returndto.Gender;  
                    dtpDate.Enabled = true;
                    dtpDate.Value = DateTime.Parse(returndto.Date);
                    nudAmount.Enabled = true;
                    nudAmount.Value = returndto.Amount;
                    btnModificar.Enabled = true;
                    
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "" || cboGender.SelectedItem == null)
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre = txtName.Text;
                gender = cboGender.SelectedItem.ToString();
                fecha = dtpDate.Value.ToString("dd/MM/yyyy");
                cantidad = (int)nudAmount.Value; 

                dto.Id = id;
                dto.Name = nombre;
                dto.Gender = gender;
                dto.Date = fecha;
                dto.Amount = cantidad;

                service.Modificar(dto);

                MessageBox.Show("Su modificacion fue exitosa");
            }
        }

        
    }
}
