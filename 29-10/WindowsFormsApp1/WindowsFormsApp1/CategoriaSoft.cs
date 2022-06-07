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

namespace WindowsFormsApp1
{

    public partial class CategoriaSoft : Form
    {
        OleDbConnection conexion = new OleDbConnection();
        DataSet ds = new DataSet();

        public int correctas = 0;
        public int incorrectas = 0;

        private int Segundos = 10;
        int num = 0;

        int numpregunta = 2;
       


        public CategoriaSoft()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormCategorias fm2 = new FormCategorias();
            fm2.Show();

            Hide();
        }


        private void CategoriaSoft_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\47168608\Downloads\27-10\db\Proyecto database.accdb;";
            conexion.Open();
            string sql = "Select * FROM Preguntas";

            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "Preguntas");

            conexion.Close();

            lblPregunta.Text = ds.Tables["Preguntas"].Rows[0]["Preguntas"].ToString();
            
            btnResp1.Text = ds.Tables["Preguntas"].Rows[0]["Respuesta1"].ToString();

            btnResp2.Text = ds.Tables["Preguntas"].Rows[0]["Respuesta2"].ToString();

            btnResp3.Text = ds.Tables["Preguntas"].Rows[0]["Respuesta3"].ToString();

            btnResp4.Text = ds.Tables["Preguntas"].Rows[0]["Respuesta4"].ToString();

            TimerSoft.Enabled = true;
            TimerSoft.Start();

            lblSegundos.Text = Convert.ToString(Segundos);
            Segundos--;
            if (Segundos == -1)
            {
                TimerSoft.Stop();
                MessageBox.Show("Se acabó tu tiempo");
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;

                if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta1")
                {
                    btnResp1.BackColor = Color.Green;
                    btnResp2.BackColor = Color.Red;
                    btnResp3.BackColor = Color.Red;
                    btnResp4.BackColor = Color.Red;
                }
                else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta2")
                {
                    btnResp1.BackColor = Color.Red;
                    btnResp2.BackColor = Color.Green;
                    btnResp3.BackColor = Color.Red;
                    btnResp4.BackColor = Color.Red;
                }
                else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta3")
                {
                    btnResp1.BackColor = Color.Red;
                    btnResp2.BackColor = Color.Red;
                    btnResp3.BackColor = Color.Green;
                    btnResp4.BackColor = Color.Red;
                }
                else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta4")
                {
                    btnResp1.BackColor = Color.Red;
                    btnResp2.BackColor = Color.Red;
                    btnResp3.BackColor = Color.Red;
                    btnResp4.BackColor = Color.Green;


                }
            }
            
            }

        private void btnResp1_Click(object sender, EventArgs e)
        {
          
            if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta1")
            {
                btnResp1.BackColor = Color.Green;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                correctas = correctas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta2" )
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Green;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta3")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Green;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta4")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Green;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }

            if (num == 9)
            {
                MessageBox.Show("Respondiste todas las preguntas, si quieres continuar vuelve al menu y selecciona otra categoría");
            }
        }

        private void btnSaltear_Click(object sender, EventArgs e)
        {
            num = num + 1;

            lblPregunta.Text = ds.Tables["Preguntas"].Rows[num]["Preguntas"].ToString();

            btnResp1.Text = ds.Tables["Preguntas"].Rows[num]["Respuesta1"].ToString();

            btnResp2.Text = ds.Tables["Preguntas"].Rows[num]["Respuesta2"].ToString();

            btnResp3.Text = ds.Tables["Preguntas"].Rows[num]["Respuesta3"].ToString();

            btnResp4.Text = ds.Tables["Preguntas"].Rows[num]["Respuesta4"].ToString();

            if (numpregunta >= 10)
            {
                btnSaltear.Enabled = false;
            }
           
            lblNumeroSoft.Text = Convert.ToString(numpregunta);
            numpregunta = 1 + numpregunta;

            btnResp1.Enabled = true;
            btnResp2.Enabled = true;
            btnResp3.Enabled = true;
            btnResp4.Enabled = true;

            btnResp1.BackColor = Color.Transparent;
            btnResp2.BackColor = Color.Transparent; 
            btnResp3.BackColor = Color.Transparent;
            btnResp4.BackColor = Color.Transparent;
        }

        private void btnResp2_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta2")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Green;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                correctas = correctas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta1")
            {
                btnResp1.BackColor = Color.Green;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta3")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Green;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta4")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Green;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            if (num == 9)
            {
                MessageBox.Show("Respondiste todas las preguntas, si quieres continuar vuelve al menu y selecciona otra categoría");
            }
        }

        private void btnResp3_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta3")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Green;
                btnResp4.BackColor = Color.Red;

                correctas = correctas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta1")
            {
                btnResp1.BackColor = Color.Green;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta2")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Green;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta4")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Green;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            if (num == 9)
            {
                MessageBox.Show("Respondiste todas las preguntas, si quieres continuar vuelve al menu y selecciona otra categoría");
            }
        }

        private void btnResp4_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta4")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Green;

                correctas = correctas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta1")
            {
                btnResp1.BackColor = Color.Green;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta2")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Green;
                btnResp3.BackColor = Color.Red;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            else if (ds.Tables["Preguntas"].Rows[num]["Correcta"].ToString() == "respuesta3")
            {
                btnResp1.BackColor = Color.Red;
                btnResp2.BackColor = Color.Red;
                btnResp3.BackColor = Color.Green;
                btnResp4.BackColor = Color.Red;

                incorrectas = incorrectas + 1;
                btnResp1.Enabled = false;
                btnResp2.Enabled = false;
                btnResp3.Enabled = false;
                btnResp4.Enabled = false;
            }
            if (num == 9)
            {
                MessageBox.Show("Respondiste todas las preguntas, si quieres continuar vuelve al menu y selecciona otra categoría");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
    
}

