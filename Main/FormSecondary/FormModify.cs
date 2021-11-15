﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Service.ServiceClient;
using Service.ServiceClient.DTOs;

namespace Main.FormSecondary
{
    public partial class FormModify : Form
    {
        private ClientService clientService;
        private ClientDto dto;
        private int id;
        private bool result;
        private string nombre;
        private string apellido;
        private string pelicula;

        public FormModify()
        {
            InitializeComponent();
            clientService = new ClientService();
            dto = new ClientDto();
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
            if (txtIdClient.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id = int.Parse(txtIdClient.Text);
                result = clientService.findClient(id);

                if (!result)
                {
                    MessageBox.Show("La pelicula no existe", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var returndto = clientService.getClient(id);

                    txtName.Enabled = true;
                    txtName.Text = returndto.Name;
                    txtApellido.Enabled=true;
                    txtApellido.Text = returndto.LastName;
                    txtPelicula.Enabled=true;
                    txtPelicula.Text = returndto.Pelicula;

                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="" || txtApellido.Text=="" || txtPelicula.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre=txtName.Text;
                apellido=txtApellido.Text;
                pelicula=txtPelicula.Text;

                dto.Name = nombre;
                dto.LastName = apellido;
                dto.Pelicula = pelicula;

                clientService.Modificar(dto);
            }
        }
    }
}
