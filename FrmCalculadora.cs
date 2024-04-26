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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Double v1, v2, soma;//Declara variável
            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            soma = v1 + v2;//somando os valores
            txtResultado.Text = soma.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Double v1, v2, sub;//Declara variável
            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            sub = v1 - v2;//subtraindo os valores
            txtResultado.Text = sub.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Double v1, v2, mult;//Declara variável
            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            mult = v1 * v2;//multiplicando os valores
            txtResultado.Text = mult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double v1, v2, div;//Declara variável
            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);
            div = v1 / v2;//dividindo os valores
            txtResultado.Text = div.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando caixas de texto
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();

            //Focar o ponto de Inserção no primeiro textbox(txtValor1)
            txtValor1.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();//Fecha a janela
        }
    }
}
