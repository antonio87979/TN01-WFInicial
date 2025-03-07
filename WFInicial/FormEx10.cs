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
    public partial class FormEx10 : Form
    {
        public FormEx10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuemro_Leave(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string tabuada = "";

            for (int i = 1; i <= 10; i++)
            {
                tabuada = tabuada + $"{numero} X {i} = {numero * i} \r\n";
            }
            txtResultado.Text = tabuada;
        }
    }
}
