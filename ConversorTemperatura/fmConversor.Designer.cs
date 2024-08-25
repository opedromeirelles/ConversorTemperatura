namespace ConversorTemperatura
{
    partial class fmConversor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTemp = new System.Windows.Forms.TextBox();
            this.cbTemperatura = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorConv2 = new System.Windows.Forms.TextBox();
            this.txtValorConv1 = new System.Windows.Forms.TextBox();
            this.lblValorConv1 = new System.Windows.Forms.Label();
            this.lblValorConv2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(163, 332);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(163, 122);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite um valor e selecione ama escala.";
            // 
            // txtValorTemp
            // 
            this.txtValorTemp.Location = new System.Drawing.Point(12, 74);
            this.txtValorTemp.Name = "txtValorTemp";
            this.txtValorTemp.Size = new System.Drawing.Size(150, 23);
            this.txtValorTemp.TabIndex = 1;
            // 
            // cbTemperatura
            // 
            this.cbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemperatura.FormattingEnabled = true;
            this.cbTemperatura.Items.AddRange(new object[] {
            "CELSIUS",
            "FAHRENHEIT",
            "KELVIN"});
            this.cbTemperatura.Location = new System.Drawing.Point(254, 72);
            this.cbTemperatura.Name = "cbTemperatura";
            this.cbTemperatura.Size = new System.Drawing.Size(153, 26);
            this.cbTemperatura.TabIndex = 2;
            this.cbTemperatura.SelectedIndexChanged += new System.EventHandler(this.cbTemperatura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor em:";
            // 
            // txtValorConv2
            // 
            this.txtValorConv2.Enabled = false;
            this.txtValorConv2.Location = new System.Drawing.Point(242, 69);
            this.txtValorConv2.Name = "txtValorConv2";
            this.txtValorConv2.ReadOnly = true;
            this.txtValorConv2.Size = new System.Drawing.Size(121, 23);
            this.txtValorConv2.TabIndex = 6;
            // 
            // txtValorConv1
            // 
            this.txtValorConv1.Enabled = false;
            this.txtValorConv1.Location = new System.Drawing.Point(29, 69);
            this.txtValorConv1.Name = "txtValorConv1";
            this.txtValorConv1.ReadOnly = true;
            this.txtValorConv1.Size = new System.Drawing.Size(121, 23);
            this.txtValorConv1.TabIndex = 6;
            // 
            // lblValorConv1
            // 
            this.lblValorConv1.AutoSize = true;
            this.lblValorConv1.Enabled = false;
            this.lblValorConv1.Location = new System.Drawing.Point(29, 32);
            this.lblValorConv1.Name = "lblValorConv1";
            this.lblValorConv1.Size = new System.Drawing.Size(0, 18);
            this.lblValorConv1.TabIndex = 7;
            // 
            // lblValorConv2
            // 
            this.lblValorConv2.AutoSize = true;
            this.lblValorConv2.Enabled = false;
            this.lblValorConv2.Location = new System.Drawing.Point(242, 32);
            this.lblValorConv2.Name = "lblValorConv2";
            this.lblValorConv2.Size = new System.Drawing.Size(0, 18);
            this.lblValorConv2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lblValorConv2);
            this.panel1.Controls.Add(this.txtValorConv1);
            this.panel1.Controls.Add(this.txtValorConv2);
            this.panel1.Controls.Add(this.lblValorConv1);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 131);
            this.panel1.TabIndex = 8;
            // 
            // fmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(419, 385);
            this.Controls.Add(this.cbTemperatura);
            this.Controls.Add(this.txtValorTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 424);
            this.Name = "fmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorTemp;
        private System.Windows.Forms.ComboBox cbTemperatura;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorConv2;
        private System.Windows.Forms.TextBox txtValorConv1;
        private System.Windows.Forms.Label lblValorConv1;
        private System.Windows.Forms.Label lblValorConv2;
        private System.Windows.Forms.Panel panel1;
    }
}

