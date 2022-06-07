namespace WindowsFormsApp1
{
    partial class FormCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnCiber = new System.Windows.Forms.Button();
            this.btnHardware = new System.Windows.Forms.Button();
            this.btnJuegos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoftware
            // 
            this.btnSoftware.BackColor = System.Drawing.Color.Black;
            this.btnSoftware.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoftware.BackgroundImage")));
            this.btnSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Location = new System.Drawing.Point(393, 162);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(604, 100);
            this.btnSoftware.TabIndex = 6;
            this.btnSoftware.UseVisualStyleBackColor = false;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // btnCiber
            // 
            this.btnCiber.BackColor = System.Drawing.Color.Black;
            this.btnCiber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCiber.BackgroundImage")));
            this.btnCiber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCiber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiber.Location = new System.Drawing.Point(393, 399);
            this.btnCiber.Name = "btnCiber";
            this.btnCiber.Size = new System.Drawing.Size(604, 100);
            this.btnCiber.TabIndex = 7;
            this.btnCiber.UseVisualStyleBackColor = false;
            this.btnCiber.Click += new System.EventHandler(this.btnCiber_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.BackColor = System.Drawing.Color.Black;
            this.btnHardware.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHardware.BackgroundImage")));
            this.btnHardware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardware.Location = new System.Drawing.Point(393, 284);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(604, 100);
            this.btnHardware.TabIndex = 8;
            this.btnHardware.UseVisualStyleBackColor = false;
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            // 
            // btnJuegos
            // 
            this.btnJuegos.BackColor = System.Drawing.Color.Black;
            this.btnJuegos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJuegos.BackgroundImage")));
            this.btnJuegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJuegos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuegos.Location = new System.Drawing.Point(393, 515);
            this.btnJuegos.Name = "btnJuegos";
            this.btnJuegos.Size = new System.Drawing.Size(604, 100);
            this.btnJuegos.TabIndex = 9;
            this.btnJuegos.UseVisualStyleBackColor = false;
            this.btnJuegos.Click += new System.EventHandler(this.btnJuegos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 68);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 637);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJuegos);
            this.Controls.Add(this.btnHardware);
            this.Controls.Add(this.btnCiber);
            this.Controls.Add(this.btnSoftware);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormCategorias";
            this.Text = "Form categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnCiber;
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.Button btnJuegos;
        private System.Windows.Forms.Button btnSalir;
    }
}
