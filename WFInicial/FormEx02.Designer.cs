namespace WFInicial
{
    partial class FormEx02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEscolher = new Button();
            lblDiaDaSemana = new Label();
            txtDiaSemana = new TextBox();
            SuspendLayout();
            // 
            // btnEscolher
            // 
            btnEscolher.Location = new Point(175, 59);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(75, 23);
            btnEscolher.TabIndex = 0;
            btnEscolher.Text = "Escolher";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // lblDiaDaSemana
            // 
            lblDiaDaSemana.AutoSize = true;
            lblDiaDaSemana.Location = new Point(60, 33);
            lblDiaDaSemana.Name = "lblDiaDaSemana";
            lblDiaDaSemana.Size = new Size(84, 15);
            lblDiaDaSemana.TabIndex = 1;
            lblDiaDaSemana.Text = "Dia da semana";
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(150, 30);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(100, 23);
            txtDiaSemana.TabIndex = 2;
            // 
            // FormEx02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 139);
            Controls.Add(txtDiaSemana);
            Controls.Add(lblDiaDaSemana);
            Controls.Add(btnEscolher);
            Name = "FormEx02";
            Text = "FormEx02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEscolher;
        private Label lblDiaDaSemana;
        private TextBox txtDiaSemana;
    }
}