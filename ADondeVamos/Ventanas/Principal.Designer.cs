namespace ADondeVamos.Ventanas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.registrar = new System.Windows.Forms.Button();
            this.cargardatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciarsesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.Black;
            this.registrar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.ForeColor = System.Drawing.Color.DeepPink;
            this.registrar.Location = new System.Drawing.Point(142, 486);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(126, 28);
            this.registrar.TabIndex = 2;
            this.registrar.Text = "Registrarse";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // cargardatos
            // 
            this.cargardatos.BackColor = System.Drawing.Color.Black;
            this.cargardatos.Font = new System.Drawing.Font("Nirmala UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargardatos.ForeColor = System.Drawing.Color.DeepPink;
            this.cargardatos.Location = new System.Drawing.Point(320, 523);
            this.cargardatos.Name = "cargardatos";
            this.cargardatos.Size = new System.Drawing.Size(67, 24);
            this.cargardatos.TabIndex = 3;
            this.cargardatos.Text = "Cargar Datos";
            this.cargardatos.UseVisualStyleBackColor = false;
            this.cargardatos.Click += new System.EventHandler(this.Cargardatos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.BackColor = System.Drawing.Color.Black;
            this.iniciarsesion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarsesion.ForeColor = System.Drawing.Color.DeepPink;
            this.iniciarsesion.Location = new System.Drawing.Point(142, 452);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(126, 28);
            this.iniciarsesion.TabIndex = 1;
            this.iniciarsesion.Text = "Iniciar sesión";
            this.iniciarsesion.UseVisualStyleBackColor = false;
            this.iniciarsesion.Click += new System.EventHandler(this.Iniciarsesion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 559);
            this.Controls.Add(this.cargardatos);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.iniciarsesion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button cargardatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iniciarsesion;
    }
}