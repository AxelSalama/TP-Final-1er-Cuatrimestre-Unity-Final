using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TP_Seminario_Lu
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TP Seminario Lu.accdb;");
         OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string login = "SELECT * FROM Usuario WHERE Mail = '" + txtMailIniciar.Text + "' AND Contraseña = '" + txtContraIniciar.Text + "'";
            OleDbCommand cmd = new OleDbCommand(login, conexion);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                MessageBox.Show("Bienvenid@ de nuevo!");

                new QueQuieroComer().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email/Contraseña incorrecta, porfavor vuelva a intentarlo...");
                txtContraIniciar.Text = "";
                txtMailIniciar.Text = "";
                txtMailIniciar.Focus();
            }
            conexion.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraIniciar.PasswordChar = '\0';
            }
            else
            {
                txtContraIniciar.PasswordChar = '*';
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registrarse().Show();
            this.Hide();
        }
    }
}
