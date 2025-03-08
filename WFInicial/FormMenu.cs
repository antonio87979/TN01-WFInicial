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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEx01_Click(object sender, EventArgs e)
        {
            FormEx01 formEx01 = new FormEx01();
            formEx01.ShowDialog();
        }

        private void btnEx02_Click(object sender, EventArgs e)
        {
            FormEx02 formEx02 = new FormEx02();
            formEx02.ShowDialog();
        }

        private void btnEx11_Click(object sender, EventArgs e)
        {

            FormEx11 formEx11 = new FormEx11();
            formEx11.ShowDialog();
        }

        private void btnEx03_Click(object sender, EventArgs e)
        {
            FormEx03 formEx03 = new FormEx03();
            formEx03.ShowDialog();
        }
    }
}
