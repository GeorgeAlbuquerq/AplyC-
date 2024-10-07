namespace Aply
{
    partial class Form4
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
            textNomeM = new TextBox();
            Cadastrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textTorreM = new TextBox();
            label5 = new Label();
            textApartamentoM = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // textNomeM
            // 
            textNomeM.Location = new Point(20, 63);
            textNomeM.Margin = new Padding(3, 2, 3, 2);
            textNomeM.Name = "textNomeM";
            textNomeM.Size = new Size(212, 23);
            textNomeM.TabIndex = 1;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(148, 185);
            Cadastrar.Margin = new Padding(3, 2, 3, 2);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(82, 22);
            Cadastrar.TabIndex = 2;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 18);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Moradores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 45);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 88);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Torre";
            // 
            // textTorreM
            // 
            textTorreM.Location = new Point(20, 105);
            textTorreM.Margin = new Padding(3, 2, 3, 2);
            textTorreM.Name = "textTorreM";
            textTorreM.Size = new Size(212, 23);
            textTorreM.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 135);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 7;
            label5.Text = "Apartamento";
            // 
            // textApartamentoM
            // 
            textApartamentoM.Location = new Point(20, 152);
            textApartamentoM.Margin = new Padding(3, 2, 3, 2);
            textApartamentoM.Name = "textApartamentoM";
            textApartamentoM.Size = new Size(212, 23);
            textApartamentoM.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Location = new Point(262, 63);
            listView1.Name = "listView1";
            listView1.Size = new Size(252, 112);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(432, 185);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 10;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(529, 235);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textApartamentoM);
            Controls.Add(label5);
            Controls.Add(textTorreM);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cadastrar);
            Controls.Add(textNomeM);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "Form4";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNomeM;
        private Button Cadastrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textTorreM;
        private Label label5;
        private TextBox textApartamentoM;
        private ListView listView1;
        private Button button1;
    }
}