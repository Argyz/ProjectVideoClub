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
    public partial class FormRemove : Form
    {
        private int id;
        public FormRemove()
        {
            InitializeComponent();
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

        }
    }
}
