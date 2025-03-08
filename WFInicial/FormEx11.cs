using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx11 : Form
    {
        public double[] salariosbruto = new double[5];
        public int contador = 0;
        public FormEx11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if (contador < 5)
            {
                
                double Salariobruto =
                    double.Parse(txtSalarioBruto.Text);
                double SalarioLiquido =
                   Salariobruto * 0.88;

                salariosbruto[contador] = Salariobruto;

                txtResultado.Text +=
                    $"Valor Bruto: {Salariobruto} \n" +
                    $"Valor Liquido: {SalarioLiquido} \n" +
                    "\n";
            }
            else
            {
                MessageBox.Show("Quantidade maxima!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } contador++;
        }
    }
}
