using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.FormSecondary
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
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
    }
}
