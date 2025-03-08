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
    public partial class FormEx12 : Form
    {
        public FormEx12()
        {
            InitializeComponent();
        }
        public int[] numeros = new int[20];
        public int[] pares = new int[0];
        public int[] impares = new int[0];
        public int contagem = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            numeros[contagem] = numero;
            contagem++;
            if (numero % 2 == 0)
            {
                Array.Resize(ref pares, pares.Length + 1);
                pares[contagem] = numero;
            }

            contagem++;
            
                }
    }
}
