namespace Aply
{
    partial class Form6
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
            textEndereçoL = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Cadastrar = new Button();
            textNomeL = new TextBox();
            label1 = new Label();
            BuscaLojas = new Button();
            EscreverBusca = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(437, 182);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 21;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(266, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(252, 23);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textEndereçoL
            // 
            textEndereçoL.Location = new Point(23, 122);
            textEndereçoL.Margin = new Padding(3, 2, 3, 2);
            textEndereçoL.Name = "textEndereçoL";
            textEndereçoL.Size = new Size(212, 23);
            textEndereçoL.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 105);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 16;
            label4.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 62);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 15);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 14;
            label2.Text = "Lojas";
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(152, 182);
            Cadastrar.Margin = new Padding(3, 2, 3, 2);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(82, 22);
            Cadastrar.TabIndex = 13;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // textNomeL
            // 
            textNomeL.Location = new Point(23, 80);
            textNomeL.Margin = new Padding(3, 2, 3, 2);
            textNomeL.Name = "textNomeL";
            textNomeL.Size = new Size(212, 23);
            textNomeL.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // BuscaLojas
            // 
            BuscaLojas.Location = new Point(437, 49);
            BuscaLojas.Name = "BuscaLojas";
            BuscaLojas.Size = new Size(81, 20);
            BuscaLojas.TabIndex = 22;
            BuscaLojas.Text = "Busca";
            BuscaLojas.UseVisualStyleBackColor = true;
            BuscaLojas.Click += BuscaLojas_Click;
            // 
            // EscreverBusca
            // 
            EscreverBusca.Location = new Point(266, 80);
            EscreverBusca.Margin = new Padding(3, 2, 3, 2);
            EscreverBusca.Name = "EscreverBusca";
            EscreverBusca.Size = new Size(252, 23);
            EscreverBusca.TabIndex = 23;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 220);
            Controls.Add(EscreverBusca);
            Controls.Add(BuscaLojas);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textEndereçoL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cadastrar);
            Controls.Add(textNomeL);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private TextBox textEndereçoL;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Cadastrar;
        private TextBox textNomeL;
        private Label label1;
        private Button BuscaLojas;
        private TextBox EscreverBusca;
    }
}