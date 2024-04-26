using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_e_Estatísticas
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = double.Parse(txtValor1.Text);
            n2 = double.Parse(txtValor2.Text);
            n3 = double.Parse(txtValor3.Text);

            media = (n1 + n2 + n3) / 3;

            txtResultado.Text = media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando as caixas de texto
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor3.Clear();
            txtResultado.Clear();
            //Iniciando cursor na primeria caixa de texto
            txtValor1.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();//Fecha a janela
        }
    }
}
