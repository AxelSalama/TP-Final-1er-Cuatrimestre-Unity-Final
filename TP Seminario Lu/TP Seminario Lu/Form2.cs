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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TP Seminario Lu.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string register = "INSERT INTO Usuario ([Nombre y Apellido], Mail, Contraseña) VALUES ('" + txtNombreReg.Text + "','" + txtMailReg.Text + "','" + txtContraReg.Text + "')";
            OleDbCommand cmd = new OleDbCommand(register, conexion);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Hola " + txtNombreReg.Text + ", Su perfil se ha registrado correctamente!");

            txtNombreReg.Text = "";
            txtMailReg.Text = "";
            txtContraReg.Text = "";

            new QueQuieroComer().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraReg.PasswordChar = '\0';
            }
            else
            {
                txtContraReg.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}
