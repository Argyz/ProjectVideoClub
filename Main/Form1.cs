﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Main.FormSecondary;
using Main.Login;

namespace Main
{
    public partial class Form1 : Form
    {
        
        private Form activeForm=null;
        private FormLogin frmLogin;

        public Form1()
        {
            InitializeComponent();
            frmLogin = new FormLogin();
            frmLogin.ShowDialog();
        }


        private void controlsForms(Form childForm) {

            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            activeForm.TopLevel = false;
            pnlContainer.Controls.Add(activeForm);
            pnlContainer.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNav.Visible = false;
            pnlNavMovie.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Visible=true;
            pnlNavMovie.Visible = false;
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;

            controlsForms(new FormHome());
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNavMovie.Visible = false;
            pnlNav.Height = btnAdd.Height;
            pnlNav.Top = btnAdd.Top;

            controlsForms(new FormAdd());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNavMovie.Visible = false;
            pnlNav.Height = btnRemove.Height;
            pnlNav.Top = btnRemove.Top;

            controlsForms(new FormRemove());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNavMovie.Visible = false;
            pnlNav.Height = btnModify.Height;
            pnlNav.Top = btnModify.Top;

            controlsForms(new FormModify());
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            pnlNavMovie.Visible=true;
            pnlNav.Visible = false;
            pnlNavMovie.Top = btnAddMovie.Top;
            pnlNavMovie.Height = btnAddMovie.Height;

            controlsForms(new FormAddMovie());
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            pnlNavMovie.Visible = true;
            pnlNav.Visible = false;
            pnlNavMovie.Top=btnRemoveMovie.Top;
            pnlNavMovie.Height= btnRemoveMovie.Height;
            
            controlsForms(new FormRemoveMovie());
        }

        private void btnModifyMovie_Click(object sender, EventArgs e)
        {
            pnlNavMovie.Visible = true;
            pnlNav.Visible = false;
            pnlNavMovie.Top = btnModifyMovie.Top;
            pnlNavMovie.Height = btnModifyMovie.Height;

            controlsForms(new FormModifyMovie());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"X:\Documentos\Martin\VisualStudio\source\repos\Lab2Again\VideoClubX\ProjectVideoClub\Main\Resource\index.html";
            proceso.Start();
        }
    }
}
