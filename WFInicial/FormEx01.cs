namespace WFInicial
{
    public partial class FormEx01 : Form
    {
        public FormEx01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text); //convertendo o valor de entrada de texto para numero com virgula(double).
            double nota2 = double.Parse(txtNota2.Text); //convertendo o valor de entrada de texto para numero com virgula(double).
            double media = (nota1 + nota2) / 2;         //calculando m�dia

            if (media >= 7)
            {
                MessageBox.Show(                  //cria uma janela de mensagem com texto, bot~ies e simbolos para instru��o
                    "aprovado",                   //descri��o
                    "OK",                         //nome da forma
                    MessageBoxButtons.OK,         //bot�o de ok para confirmar
                    MessageBoxIcon.Information);  //define o tipo de icone a ser exibido
            }
            else if (nota1 < 5) {
                MessageBox.Show(
                    "Reprovado",
                    "DEU RUIM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }
            else {
                MessageBox.Show(
                    "Recupera��o", 
                    "Aten��o",     
                    MessageBoxButtons.OK,   
                    MessageBoxIcon.Warning); 
                    }
        }
    }
}
