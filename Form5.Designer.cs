namespace Aply
{
    partial class Form5
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
            button1 = new Button();
            listView1 = new ListView();
            textLojaE = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Cadastrar = new Button();
            textNomeE = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(428, 181);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 21;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(257, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(252, 112);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textLojaE
            // 
            textLojaE.Location = new Point(14, 119);
            textLojaE.Margin = new Padding(3, 2, 3, 2);
            textLojaE.Name = "textLojaE";
            textLojaE.Size = new Size(212, 23);
            textLojaE.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 103);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 16;
            label4.Text = "Loja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 59);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 14);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 14;
            label2.Text = "Entregador";
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(144, 181);
            Cadastrar.Margin = new Padding(3, 2, 3, 2);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(82, 22);
            Cadastrar.TabIndex = 13;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // textNomeE
            // 
            textNomeE.Location = new Point(14, 77);
            textNomeE.Margin = new Padding(3, 2, 3, 2);
            textNomeE.Name = "textNomeE";
            textNomeE.Size = new Size(212, 23);
            textNomeE.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(524, 228);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textLojaE);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cadastrar);
            Controls.Add(textNomeE);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            ShowIcon = false;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private TextBox textLojaE;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Cadastrar;
        private TextBox textNomeE;
        private Label label1;
    }
}