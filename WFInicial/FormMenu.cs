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



        private void btnEx03_Click(object sender, EventArgs e)
        {
            FormEx03 formEx03 = new FormEx03();
            formEx03.ShowDialog();
        }

        private void btnEx04_Click(object sender, EventArgs e)
        {
            FormEx04 formEx04 = new FormEx04();
            formEx04.ShowDialog();
        }

        private void btnEx05_Click(object sender, EventArgs e)
        {
            FormEx05 formEx05 = new FormEx05();
            formEx05.ShowDialog();
        }

        private void btnEx06_Click(object sender, EventArgs e)
        {
            FormEx06 formEx06 = new FormEx06();
            formEx06.ShowDialog();
        }

        private void btnEx07_Click(object sender, EventArgs e)
        {
            FormEx07 formEx07 = new FormEx07();
            formEx07.ShowDialog();
        }

        private void btnEx08_Click(object sender, EventArgs e)
        {
            FormEx08 formEx08 = new FormEx08();
            formEx08.ShowDialog();
        }

        private void btnEx09_Click(object sender, EventArgs e)
        {
            FormEx09 formEx09 = new FormEx09();
            formEx09.ShowDialog();
        }

        private void btnEx10_Click(object sender, EventArgs e)
        {
            FormEx10 formEx10 = new FormEx10();
            formEx10.ShowDialog();
        }

        private void btnEx11_Click(object sender, EventArgs e)
        {

            FormEx11 formEx11 = new FormEx11();
            formEx11.ShowDialog();
        }

        private void btnEx12_Click(object sender, EventArgs e)
        {
            FormEx12 formEx12 = new FormEx12();
            formEx12.ShowDialog();
        }
    }
}
}
