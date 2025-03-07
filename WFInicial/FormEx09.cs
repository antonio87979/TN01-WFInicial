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
    public partial class FormEx09 : Form
    {
        public FormEx09()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario us1 = new usuario();
            bool entrou = true;
            us1.Nome = txtUsuario.Text;
            us1.Senha = txtSenha.Text;

            entrou = us1.EfetuarLogin();
            if (entrou == false)
            {
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Bem vindo ao sistema!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Dispose(); //fecha a janela do formulario
            }
        }
    }
}
