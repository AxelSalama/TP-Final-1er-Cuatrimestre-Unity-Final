namespace WindowsFormsApp1
{
    partial class CategoriaSoft
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaSoft));
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnHomeSoft = new System.Windows.Forms.Button();
            this.btnResp1 = new System.Windows.Forms.Button();
            this.btnResp3 = new System.Windows.Forms.Button();
            this.btnResp4 = new System.Windows.Forms.Button();
            this.btnResp2 = new System.Windows.Forms.Button();
            this.btnSaltear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblNumeroSoft = new System.Windows.Forms.Label();
            this.TimerSoft = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.Red;
            this.lblMinutos.Location = new System.Drawing.Point(1098, 168);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(49, 33);
            this.lblMinutos.TabIndex = 0;
            this.lblMinutos.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1153, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Red;
            this.lblSegundos.Location = new System.Drawing.Point(1183, 168);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(49, 33);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "00";
            // 
            // btnHomeSoft
            // 
            this.btnHomeSoft.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeSoft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeSoft.BackgroundImage")));
            this.btnHomeSoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeSoft.ForeColor = System.Drawing.Color.Black;
            this.btnHomeSoft.Location = new System.Drawing.Point(22, 12);
            this.btnHomeSoft.Name = "btnHomeSoft";
            this.btnHomeSoft.Size = new System.Drawing.Size(97, 97);
            this.btnHomeSoft.TabIndex = 3;
            this.btnHomeSoft.UseVisualStyleBackColor = false;
            this.btnHomeSoft.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnResp1
            // 
            this.btnResp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResp1.BackColor = System.Drawing.Color.Transparent;
            this.btnResp1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResp1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResp1.Location = new System.Drawing.Point(277, 307);
            this.btnResp1.Name = "btnResp1";
            this.btnResp1.Size = new System.Drawing.Size(699, 72);
            this.btnResp1.TabIndex = 4;
            this.btnResp1.UseVisualStyleBackColor = false;
            this.btnResp1.Click += new System.EventHandler(this.btnResp1_Click);
            // 
            // btnResp3
            // 
            this.btnResp3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResp3.BackColor = System.Drawing.Color.Transparent;
            this.btnResp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResp3.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnResp3.Location = new System.Drawing.Point(277, 518);
            this.btnResp3.Name = "btnResp3";
            this.btnResp3.Size = new System.Drawing.Size(699, 72);
            this.btnResp3.TabIndex = 5;
            this.btnResp3.UseVisualStyleBackColor = false;
            this.btnResp3.Click += new System.EventHandler(this.btnResp3_Click);
            // 
            // btnResp4
            // 
            this.btnResp4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResp4.BackColor = System.Drawing.Color.Transparent;
            this.btnResp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResp4.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnResp4.Location = new System.Drawing.Point(278, 627);
            this.btnResp4.Name = "btnResp4";
            this.btnResp4.Size = new System.Drawing.Size(699, 72);
            this.btnResp4.TabIndex = 6;
            this.btnResp4.UseVisualStyleBackColor = false;
            this.btnResp4.Click += new System.EventHandler(this.btnResp4_Click);
            // 
            // btnResp2
            // 
            this.btnResp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResp2.BackColor = System.Drawing.Color.Transparent;
            this.btnResp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResp2.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnResp2.Location = new System.Drawing.Point(278, 415);
            this.btnResp2.Name = "btnResp2";
            this.btnResp2.Size = new System.Drawing.Size(699, 72);
            this.btnResp2.TabIndex = 7;
            this.btnResp2.UseVisualStyleBackColor = false;
            this.btnResp2.Click += new System.EventHandler(this.btnResp2_Click);
            // 
            // btnSaltear
            // 
            this.btnSaltear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaltear.BackColor = System.Drawing.Color.Transparent;
            this.btnSaltear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaltear.Location = new System.Drawing.Point(1071, 654);
            this.btnSaltear.Name = "btnSaltear";
            this.btnSaltear.Size = new System.Drawing.Size(181, 94);
            this.btnSaltear.TabIndex = 8;
            this.btnSaltear.UseVisualStyleBackColor = false;
            this.btnSaltear.Click += new System.EventHandler(this.btnSaltear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(10, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 58);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(510, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(210, 33);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "PREGUNTA #";
            // 
            // lblPregunta
            // 
            this.lblPregunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.Black;
            this.lblPregunta.Location = new System.Drawing.Point(331, 137);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(138, 32);
            this.lblPregunta.TabIndex = 11;
            this.lblPregunta.Text = "pregunta";
            // 
            // lblNumeroSoft
            // 
            this.lblNumeroSoft.AutoSize = true;
            this.lblNumeroSoft.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSoft.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroSoft.Location = new System.Drawing.Point(726, 71);
            this.lblNumeroSoft.Name = "lblNumeroSoft";
            this.lblNumeroSoft.Size = new System.Drawing.Size(32, 33);
            this.lblNumeroSoft.TabIndex = 12;
            this.lblNumeroSoft.Text = "1";
            // 
            // TimerSoft
            // 
            this.TimerSoft.Enabled = true;
            this.TimerSoft.Interval = 1000;
            this.TimerSoft.Tick += new System.EventHandler(this.CategoriaSoft_Load);
            // 
            // CategoriaSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.lblNumeroSoft);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSaltear);
            this.Controls.Add(this.btnResp2);
            this.Controls.Add(this.btnResp4);
            this.Controls.Add(this.btnResp3);
            this.Controls.Add(this.btnResp1);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnHomeSoft);
            this.DoubleBuffered = true;
            this.Name = "CategoriaSoft";
            this.Text = "CategoriaSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoriaSoft_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnHomeSoft;
        private System.Windows.Forms.Button btnResp1;
        private System.Windows.Forms.Button btnResp3;
        private System.Windows.Forms.Button btnResp4;
        private System.Windows.Forms.Button btnResp2;
        private System.Windows.Forms.Button btnSaltear;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblNumeroSoft;
        private System.Windows.Forms.Timer TimerSoft;
    }
}
