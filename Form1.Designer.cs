namespace Aply
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textEmail = new TextBox();
            textSenha = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 20);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 113);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(20, 74);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(159, 23);
            textEmail.TabIndex = 3;
            textEmail.TextChanged += textBox1_TextChanged;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(20, 131);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(159, 23);
            textSenha.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Manter-me logado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(20, 204);
            button1.Name = "button1";
            button1.Size = new Size(313, 23);
            button1.TabIndex = 6;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 273);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 7;
            label4.Text = "Ainda não tem conta?";
            // 
            // button2
            // 
            button2.Location = new Point(218, 269);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 8;
            button2.Text = "Cadastre-se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(345, 314);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textSenha);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textEmail;
        private TextBox textSenha;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}