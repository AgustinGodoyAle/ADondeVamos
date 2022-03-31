namespace ADondeVamos.Ventanas
{
    partial class VentanaAmigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAmigos));
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.VerCodigo = new System.Windows.Forms.Button();
            this.Generar = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Anadir = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkOul BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "LISTA DE AMIGOS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DeepPink;
            this.richTextBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(25, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(319, 403);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // VerCodigo
            // 
            this.VerCodigo.BackColor = System.Drawing.Color.Black;
            this.VerCodigo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerCodigo.ForeColor = System.Drawing.Color.DeepPink;
            this.VerCodigo.Location = new System.Drawing.Point(364, 24);
            this.VerCodigo.Name = "VerCodigo";
            this.VerCodigo.Size = new System.Drawing.Size(291, 42);
            this.VerCodigo.TabIndex = 9;
            this.VerCodigo.Text = "Ver Tu Código Amigo Actual";
            this.VerCodigo.UseVisualStyleBackColor = false;
            this.VerCodigo.Click += new System.EventHandler(this.VerCodigo_Click);
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.Black;
            this.Generar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar.ForeColor = System.Drawing.Color.DeepPink;
            this.Generar.Location = new System.Drawing.Point(364, 72);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(291, 42);
            this.Generar.TabIndex = 10;
            this.Generar.Text = "Generar Nuevo Código Amigo";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(498, 197);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(157, 20);
            this.nametxt.TabIndex = 13;
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(498, 223);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(157, 20);
            this.codetxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(361, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre de tu Amigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(361, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Su Código Amigo:";
            // 
            // Anadir
            // 
            this.Anadir.BackColor = System.Drawing.Color.Black;
            this.Anadir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anadir.ForeColor = System.Drawing.Color.DeepPink;
            this.Anadir.Location = new System.Drawing.Point(364, 249);
            this.Anadir.Name = "Anadir";
            this.Anadir.Size = new System.Drawing.Size(291, 42);
            this.Anadir.TabIndex = 17;
            this.Anadir.Text = "Añadir Amigo";
            this.Anadir.UseVisualStyleBackColor = false;
            this.Anadir.Click += new System.EventHandler(this.Anadir_Click);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.Black;
            this.Volver.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ForeColor = System.Drawing.Color.DeepPink;
            this.Volver.Location = new System.Drawing.Point(353, 437);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(143, 34);
            this.Volver.TabIndex = 18;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(350, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre de quién desees eliminar de la lista:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(353, 400);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(302, 20);
            this.nombre.TabIndex = 20;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Black;
            this.Eliminar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.DeepPink;
            this.Eliminar.Location = new System.Drawing.Point(512, 437);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(143, 34);
            this.Eliminar.TabIndex = 21;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // VentanaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 497);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Anadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.VerCodigo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaAmigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana Amigos";
            this.Load += new System.EventHandler(this.VentanaAmigos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button VerCodigo;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Anadir;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Eliminar;
    }
}