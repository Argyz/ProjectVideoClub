using System;
using System.Windows.Forms;
using Main.FormSecondary;

namespace Main
{
    public partial class Form1 : Form
    {
        
        private Form activeForm=null;
        public Form1()
        {
            InitializeComponent();
            
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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Visible=true;
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;

            controlsForms(new FormHome());
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnAdd.Height;
            pnlNav.Top = btnAdd.Top;

            controlsForms(new FormAdd());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnRemove.Height;
            pnlNav.Top = btnRemove.Top;

            controlsForms(new FormRemove());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnModify.Height;
            pnlNav.Top = btnModify.Top;

            controlsForms(new FormModify());
        }
    }
}
