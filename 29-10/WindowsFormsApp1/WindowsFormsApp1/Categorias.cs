using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            CategoriaSoft fm2 = new CategoriaSoft();
            fm2.Show();

            Hide();
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            CategoriaHard fm2 = new CategoriaHard();
            fm2.Show();

            Hide();
        }

        private void btnCiber_Click(object sender, EventArgs e)
        {
            CategoriaCiber fm2 = new CategoriaCiber();
            fm2.Show();

            Hide();
        }

        private void btnJuegos_Click(object sender, EventArgs e)
        {
            CategoriaJuegos fm2 = new CategoriaJuegos();
            fm2.Show();

            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
