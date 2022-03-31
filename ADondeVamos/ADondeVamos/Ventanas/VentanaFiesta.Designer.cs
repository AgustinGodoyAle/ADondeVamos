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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIESTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vestimenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Entrada con bebida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEntradaBebida
            // 
            this.comboBoxEntradaBebida.FormattingEnabled = true;
            this.comboBoxEntradaBebida.Items.AddRange(new object[] {
            "Bebida en mano",
            "Conservadora",
            "Sin bebida"});
            this.comboBoxEntradaBebida.Location = new System.Drawing.Point(156, 98);
            this.comboBoxEntradaBebida.Name = "comboBoxEntradaBebida";
            this.comboBoxEntradaBebida.Size = new System.Drawing.Size(142, 21);
            this.comboBoxEntradaBebida.TabIndex = 18;
            // 
            // vestimentatxt
            // 
            this.vestimentatxt.Location = new System.Drawing.Point(156, 162);
            this.vestimentatxt.Name = "vestimentatxt";
            this.vestimentatxt.Size = new System.Drawing.Size(142, 20);
            this.vestimentatxt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo de Fiesta";
            // 
            // comboBoxTipoFiesta
            // 
            this.comboBoxTipoFiesta.FormattingEnabled = true;
            this.comboBoxTipoFiesta.Items.AddRange(new object[] {
            "Previa",
            "Boliche",
            "Cumpleaños",
            "Tematica",
            "Fiesta de Colegios"});
            this.comboBoxTipoFiesta.Location = new System.Drawing.Point(156, 41);
            this.comboBoxTipoFiesta.Name = "comboBoxTipoFiesta";
            this.comboBoxTipoFiesta.Size = new System.Drawing.Size(143, 21);
            this.comboBoxTipoFiesta.TabIndex = 12;
            // 
            // BandasSiNo
            // 
            this.BandasSiNo.FormattingEnabled = true;
            this.BandasSiNo.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.BandasSiNo.Location = new System.Drawing.Point(156, 212);
            this.BandasSiNo.Name = "BandasSiNo";
            this.BandasSiNo.Size = new System.Drawing.Size(142, 21);
            this.BandasSiNo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "¿Hay Bandas/Solistas/DJs?";
            // 
            // VentanaFiesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
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
            this.Name = "VentanaFiesta";
            this.Text = "Form4";
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
    }
}