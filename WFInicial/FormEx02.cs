using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFInicial
{
    public partial class FormEx02 : Form
    {
        public FormEx02()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
          
            byte opção = byte.Parse(txtDiaSemana.Text);

            switch (opção)
            {
                case 1:
                    MessageBox.Show(
                        "Dia da semana",
                        "Domingo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 2:
                    MessageBox.Show(
                        "Dia da semana",
                        "Segunda-feira",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 3:
                    MessageBox.Show(
                        "Dia da semana",
                        "Terça-feira",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 4:
                    MessageBox.Show(
                        "Dia da semana",
                        "Quarta-feira",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 5:
                    MessageBox.Show(
                        "Dia da semana",
                        "Quinta-feira",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 6:
                    MessageBox.Show(
                        "Dia da semana",
                        "Sexta-feira",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case 7:
                    MessageBox.Show(
                        "Dia da semana",
                        "Sábado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    break;
                default: //qualquer opção 
                    MessageBox.Show(
                        "opção inválida",
                        "erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
            }
        }
    }
}
