namespace TP_Seminario_Lu
{
    partial class QueQuieroComer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueQuieroComer));
            this.btnBuscarPorComida = new System.Windows.Forms.Button();
            this.txtquecomida = new System.Windows.Forms.TextBox();
            this.lbRespuestaResaurante = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcalificacion = new System.Windows.Forms.Label();
            this.tacho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarPorComida
            // 
            this.btnBuscarPorComida.Location = new System.Drawing.Point(216, 93);
            this.btnBuscarPorComida.Name = "btnBuscarPorComida";
            this.btnBuscarPorComida.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorComida.TabIndex = 0;
            this.btnBuscarPorComida.Text = "Buscar!";
            this.btnBuscarPorComida.UseVisualStyleBackColor = true;
            this.btnBuscarPorComida.Click += new System.EventHandler(this.btnBuscarPorComida_Click);
            // 
            // txtquecomida
            // 
            this.txtquecomida.Location = new System.Drawing.Point(95, 93);
            this.txtquecomida.Name = "txtquecomida";
            this.txtquecomida.Size = new System.Drawing.Size(100, 20);
            this.txtquecomida.TabIndex = 1;
            // 
            // lbRespuestaResaurante
            // 
            this.lbRespuestaResaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRespuestaResaurante.FormattingEnabled = true;
            this.lbRespuestaResaurante.ItemHeight = 24;
            this.lbRespuestaResaurante.Location = new System.Drawing.Point(73, 135);
            this.lbRespuestaResaurante.Name = "lbRespuestaResaurante";
            this.lbRespuestaResaurante.Size = new System.Drawing.Size(248, 28);
            this.lbRespuestaResaurante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Que comida quiero comer?";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(34, 209);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(89, 20);
            this.lbldireccion.TabIndex = 4;
            this.lbldireccion.Text = "Dirección:";
            // 
            // lblcalificacion
            // 
            this.lblcalificacion.AutoSize = true;
            this.lblcalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificacion.Location = new System.Drawing.Point(33, 263);
            this.lblcalificacion.Name = "lblcalificacion";
            this.lblcalificacion.Size = new System.Drawing.Size(106, 20);
            this.lblcalificacion.TabIndex = 5;
            this.lblcalificacion.Text = "Calificacion:";
            // 
            // tacho
            // 
            this.tacho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tacho.BackgroundImage")));
            this.tacho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tacho.FlatAppearance.BorderSize = 0;
            this.tacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tacho.Location = new System.Drawing.Point(326, 323);
            this.tacho.Name = "tacho";
            this.tacho.Size = new System.Drawing.Size(65, 45);
            this.tacho.TabIndex = 6;
            this.tacho.UseVisualStyleBackColor = true;
            this.tacho.Click += new System.EventHandler(this.tacho_Click);
            // 
            // QueQuieroComer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(416, 380);
            this.Controls.Add(this.tacho);
            this.Controls.Add(this.lblcalificacion);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRespuestaResaurante);
            this.Controls.Add(this.txtquecomida);
            this.Controls.Add(this.btnBuscarPorComida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueQuieroComer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonShadow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPorComida;
        private System.Windows.Forms.TextBox txtquecomida;
        private System.Windows.Forms.ListBox lbRespuestaResaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcalificacion;
        private System.Windows.Forms.Button tacho;
    }
}

