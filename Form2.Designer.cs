namespace Aply
{
    partial class Form2
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textNome = new TextBox();
            textEmail = new TextBox();
            textEndereco = new TextBox();
            textCondominio = new TextBox();
            textSenha = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 64);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 104);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 143);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Endereço";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 183);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "Condomínio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 223);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Senha";
            // 
            // textNome
            // 
            textNome.Location = new Point(52, 81);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(326, 23);
            textNome.TabIndex = 6;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(52, 121);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(326, 23);
            textEmail.TabIndex = 7;
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(52, 160);
            textEndereco.Margin = new Padding(3, 2, 3, 2);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(326, 23);
            textEndereco.TabIndex = 8;
            textEndereco.TextChanged += textEndereco_TextChanged;
            // 
            // textCondominio
            // 
            textCondominio.Location = new Point(52, 200);
            textCondominio.Margin = new Padding(3, 2, 3, 2);
            textCondominio.Name = "textCondominio";
            textCondominio.Size = new Size(326, 23);
            textCondominio.TabIndex = 9;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(52, 240);
            textSenha.Margin = new Padding(3, 2, 3, 2);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(326, 23);
            textSenha.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 292);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 327);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 12;
            label8.Text = "Já tem conta?";
            // 
            // button1
            // 
            button1.Location = new Point(270, 324);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 22);
            button1.TabIndex = 13;
            button1.Text = "Ir para Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 285);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(326, 22);
            button2.TabIndex = 14;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(431, 379);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textSenha);
            Controls.Add(textCondominio);
            Controls.Add(textEndereco);
            Controls.Add(textEmail);
            Controls.Add(textNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            ShowIcon = false;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textNome;
        private TextBox textEmail;
        private TextBox textEndereco;
        private TextBox textCondominio;
        private TextBox textSenha;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}