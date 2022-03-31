namespace ADondeVamos
{
    partial class VentanaFiesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFiesta));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEntradaBebida = new System.Windows.Forms.ComboBox();
            this.vestimentatxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTipoFiesta = new System.Windows.Forms.ComboBox();
            this.BandasSiNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkOul BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIESTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vestimenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Entrada con bebida";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(220, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(34, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEntradaBebida
            // 
            this.comboBoxEntradaBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntradaBebida.FormattingEnabled = true;
            this.comboBoxEntradaBebida.Items.AddRange(new object[] {
            "Bebida en mano",
            "Conservadora",
            "Sin bebida"});
            this.comboBoxEntradaBebida.Location = new System.Drawing.Point(209, 252);
            this.comboBoxEntradaBebida.Name = "comboBoxEntradaBebida";
            this.comboBoxEntradaBebida.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEntradaBebida.TabIndex = 18;
            // 
            // vestimentatxt
            // 
            this.vestimentatxt.Location = new System.Drawing.Point(209, 279);
            this.vestimentatxt.Name = "vestimentatxt";
            this.vestimentatxt.Size = new System.Drawing.Size(166, 22);
            this.vestimentatxt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de Fiesta";
            // 
            // comboBoxTipoFiesta
            // 
            this.comboBoxTipoFiesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiesta.FormattingEnabled = true;
            this.comboBoxTipoFiesta.Items.AddRange(new object[] {
            "Previa",
            "Boliche",
            "Cumpleaños",
            "Tematica",
            "Fiesta de Colegios"});
            this.comboBoxTipoFiesta.Location = new System.Drawing.Point(209, 225);
            this.comboBoxTipoFiesta.Name = "comboBoxTipoFiesta";
            this.comboBoxTipoFiesta.Size = new System.Drawing.Size(166, 21);
            this.comboBoxTipoFiesta.TabIndex = 12;
            // 
            // BandasSiNo
            // 
            this.BandasSiNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BandasSiNo.FormattingEnabled = true;
            this.BandasSiNo.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.BandasSiNo.Location = new System.Drawing.Point(209, 307);
            this.BandasSiNo.Name = "BandasSiNo";
            this.BandasSiNo.Size = new System.Drawing.Size(165, 21);
            this.BandasSiNo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "¿Hay Bandas/Solistas/DJs?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepPink;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 64);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // VentanaFiesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BandasSiNo);
            this.Controls.Add(this.vestimentatxt);
            this.Controls.Add(this.comboBoxEntradaBebida);
            this.Controls.Add(this.comboBoxTipoFiesta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaFiesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana Fiesta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxEntradaBebida;
        private System.Windows.Forms.TextBox vestimentatxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipoFiesta;
        private System.Windows.Forms.ComboBox BandasSiNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}