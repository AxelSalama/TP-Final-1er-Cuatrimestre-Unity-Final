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
    public partial class CategoriaCiber : Form
    {
        public CategoriaCiber()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormCategorias fm2 = new FormCategorias();
            fm2.Show();

            Hide();
        }
    }
}
