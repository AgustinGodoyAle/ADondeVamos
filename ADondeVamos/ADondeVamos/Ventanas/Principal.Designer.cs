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
            this.label1 = new System.Windows.Forms.Label();
            this.iniciarsesion = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.cargardatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGO EN PROCESO - PATENTE PENDIENTE";
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.Location = new System.Drawing.Point(351, 431);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(145, 38);
            this.iniciarsesion.TabIndex = 1;
            this.iniciarsesion.Text = "Iniciar sesión";
            this.iniciarsesion.UseVisualStyleBackColor = true;
            this.iniciarsesion.Click += new System.EventHandler(this.iniciarsesion_Click);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(28, 431);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(133, 35);
            this.registrar.TabIndex = 2;
            this.registrar.Text = "Registrarse";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // cargardatos
            // 
            this.cargardatos.Location = new System.Drawing.Point(213, 434);
            this.cargardatos.Name = "cargardatos";
            this.cargardatos.Size = new System.Drawing.Size(97, 35);
            this.cargardatos.TabIndex = 3;
            this.cargardatos.Text = "Cargar Datos";
            this.cargardatos.UseVisualStyleBackColor = true;
            this.cargardatos.Click += new System.EventHandler(this.cargardatos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 493);
            this.Controls.Add(this.cargardatos);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.iniciarsesion);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciarsesion;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button cargardatos;
    }
}