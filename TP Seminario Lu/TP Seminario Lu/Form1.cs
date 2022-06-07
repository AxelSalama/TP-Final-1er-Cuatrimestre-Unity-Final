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
    public partial class QueQuieroComer : Form
    {
        public QueQuieroComer()
        {
            InitializeComponent();
        }
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\TP Seminario Lu.accdb;";
            conexion.Open();
        }

        private void textbox1_TextChanged (object sender, EventArgs e)
        {

        }
        string quecomida = "";
        private void btnBuscarPorComida_Click(object sender, EventArgs e)
        {
            quecomida = txtquecomida.Text;
            string sql = "SELECT Restaurante.Nombre FROM Restaurante WHERE Restaurante.NombreComidas = '" + quecomida + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "restaurante");

            lbRespuestaResaurante.DataSource = ds.Tables["restaurante"];
            lbRespuestaResaurante.ValueMember = "Nombre";

            string sqldireccion = "SELECT Restaurante.Direccion FROM Restaurante WHERE Restaurante.NombreComidas = '" + quecomida + "'";
            OleDbCommand cmd2 = new OleDbCommand(sqldireccion, conexion);
            OleDbDataReader m = cmd2.ExecuteReader();

            if (m.Read())
            {
                lbldireccion.Text += " " + m.GetString(0);
            }

            string sqlcalificacion = "SELECT Restaurante.Calificación FROM Restaurante WHERE Restaurante.NombreComidas = '" + quecomida + "'";
            OleDbCommand cmd3 = new OleDbCommand(sqlcalificacion, conexion);
            OleDbDataReader n = cmd3.ExecuteReader();

            if (n.Read())
            {
                lblcalificacion.Text += " " + n.GetInt32(0) + "/10";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registrarse().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void tacho_Click(object sender, EventArgs e)
        {
            lblcalificacion.Text = "Calificación:";
            lbldireccion.Text = "Dirección:";
            quecomida= "";
            txtquecomida.Focus();
        }
    }
}
