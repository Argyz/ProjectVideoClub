using System;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnAdd.Height;
            pnlNav.Top = btnAdd.Top;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnRemove.Height;
            pnlNav.Top = btnRemove.Top;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlNav.Height = btnModify.Height;
            pnlNav.Top = btnModify.Top;
        }
    }
}
