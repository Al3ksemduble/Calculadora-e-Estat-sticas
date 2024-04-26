namespace Calculadora_e_Estatísticas
{
    partial class FrmCalculadora
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
            this.lblInstrucao1 = new System.Windows.Forms.Label();
            this.lblInstrucao2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(607, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Básica";
            // 
            // lblInstrucao1
            // 
            this.lblInstrucao1.AutoSize = true;
            this.lblInstrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao1.Location = new System.Drawing.Point(212, 105);
            this.lblInstrucao1.Name = "lblInstrucao1";
            this.lblInstrucao1.Size = new System.Drawing.Size(45, 17);
            this.lblInstrucao1.TabIndex = 1;
            this.lblInstrucao1.Text = "Num1";
            // 
            // lblInstrucao2
            // 
            this.lblInstrucao2.AutoSize = true;
            this.lblInstrucao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInstrucao2.Location = new System.Drawing.Point(212, 153);
            this.lblInstrucao2.Name = "lblInstrucao2";
            this.lblInstrucao2.Size = new System.Drawing.Size(45, 17);
            this.lblInstrucao2.TabIndex = 2;
            this.lblInstrucao2.Text = "Num2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado.Location = new System.Drawing.Point(185, 276);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 398);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 40);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSomar.Location = new System.Drawing.Point(263, 195);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(135, 31);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSub.Location = new System.Drawing.Point(404, 195);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(125, 31);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMult.Location = new System.Drawing.Point(263, 224);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(135, 31);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(404, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 31);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDiv.Location = new System.Drawing.Point(404, 224);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(125, 31);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(263, 104);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(266, 20);
            this.txtValor1.TabIndex = 10;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(263, 152);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(266, 20);
            this.txtValor2.TabIndex = 11;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(263, 275);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(266, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInstrucao2);
            this.Controls.Add(this.lblInstrucao1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstrucao1;
        private System.Windows.Forms.Label lblInstrucao2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}