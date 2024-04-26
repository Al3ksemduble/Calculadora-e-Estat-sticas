namespace Calculadora_e_Estatísticas
{
    partial class FrmMedia
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
            this.lblInstrucao2 = new System.Windows.Forms.Label();
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.lblInstrucao3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(641, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Média Mediana";
            // 
            // lblInstrucao2
            // 
            this.lblInstrucao2.AutoSize = true;
            this.lblInstrucao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao2.Location = new System.Drawing.Point(308, 120);
            this.lblInstrucao2.Name = "lblInstrucao2";
            this.lblInstrucao2.Size = new System.Drawing.Size(45, 17);
            this.lblInstrucao2.TabIndex = 1;
            this.lblInstrucao2.Text = "Num2";
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(308, 94);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(45, 17);
            this.lblInstrucao1.TabIndex = 2;
            this.lblInstrucao1.Text = "Num1";
            // 
            // lblInstrucao3
            // 
            this.lblInstrucao3.AutoSize = true;
            this.lblInstrucao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao3.Location = new System.Drawing.Point(308, 148);
            this.lblInstrucao3.Name = "lblInstrucao3";
            this.lblInstrucao3.Size = new System.Drawing.Size(45, 17);
            this.lblInstrucao3.TabIndex = 3;
            this.lblInstrucao3.Text = "Num3";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado.Location = new System.Drawing.Point(288, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(366, 93);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(164, 20);
            this.txtValor1.TabIndex = 5;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(366, 119);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(164, 20);
            this.txtValor2.TabIndex = 6;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(366, 147);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(164, 20);
            this.txtValor3.TabIndex = 7;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(366, 254);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(409, 218);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 30);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(107, 37);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(409, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 30);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInstrucao3);
            this.Controls.Add(this.lblInstrucao1);
            this.Controls.Add(this.lblInstrucao2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMedia";
            this.Text = "Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstrucao2;
        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.Label lblInstrucao3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCalcular;
    }
}