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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Criando uma instância do segundo formulário
            FrmCalculadora FrmCalc = new FrmCalculadora();

            //Mostrando o segundo formulário
            FrmCalc.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //Criando uma instância do terceiro formulário
            FrmMedia FrmMed = new FrmMedia();

            //Mostrando o terceiro formulário
            FrmMed.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();//Fecha a janela
        }
    }
}
