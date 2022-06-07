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
    public partial class CategoriaHard : Form
    {
        private int segundos = 20;
        public CategoriaHard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormCategorias fm2 = new FormCategorias();
            fm2.Show();

            Hide();
        }

        private void CategoriaHard_Load(object sender, EventArgs e)
        {
            TimerHard.Enabled = true;
            TimerHard.Start();

            lblSegundos.Text = Convert.ToString(segundos);
            segundos--;
            if (segundos == -1)
            { 
                TimerHard.Stop();
                MessageBox.Show("Se acabó tu tiempo");
                btnResp1.Enabled = false;
                BtnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
    }
}
}

