using System.Windows.Forms;

namespace Aply
{
    partial class Form3
    {
        
        private System.ComponentModel.IContainer components = null;

      
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            condomínioToolStripMenuItem = new ToolStripMenuItem();
            belaAlvoradaToolStripMenuItem = new ToolStripMenuItem();
            paraísoNovoToolStripMenuItem = new ToolStripMenuItem();
            alphavilleToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            torre2ToolStripMenuItem = new ToolStripMenuItem();
            torre3ToolStripMenuItem = new ToolStripMenuItem();
            torre4ToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarMoradorToolStripMenuItem = new ToolStripMenuItem();
            pesquisaDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem1 = new ToolStripMenuItem();
            entregadorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEntregadorToolStripMenuItem = new ToolStripMenuItem();
            procurarEntregadorToolStripMenuItem = new ToolStripMenuItem();
            lojasParceirasToolStripMenuItem = new ToolStripMenuItem();
            cadastrarLojasToolStripMenuItem = new ToolStripMenuItem();
            procurarLojasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
           
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 299);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            
            condomínioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { belaAlvoradaToolStripMenuItem, paraísoNovoToolStripMenuItem, alphavilleToolStripMenuItem });
            condomínioToolStripMenuItem.Name = "condomínioToolStripMenuItem";
            condomínioToolStripMenuItem.Size = new Size(85, 20);
            condomínioToolStripMenuItem.Text = "Condomínio";
            condomínioToolStripMenuItem.Click += condomínioToolStripMenuItem_Click;
           
            belaAlvoradaToolStripMenuItem.CheckOnClick = true;
            belaAlvoradaToolStripMenuItem.Name = "belaAlvoradaToolStripMenuItem";
            belaAlvoradaToolStripMenuItem.Size = new Size(151, 22);
            belaAlvoradaToolStripMenuItem.Text = "Bela Alvorada";
            belaAlvoradaToolStripMenuItem.Click += belaAlvoradaToolStripMenuItem_Click;
            
            paraísoNovoToolStripMenuItem.CheckOnClick = true;
            paraísoNovoToolStripMenuItem.Name = "paraísoNovoToolStripMenuItem";
            paraísoNovoToolStripMenuItem.Size = new Size(151, 22);
            paraísoNovoToolStripMenuItem.Text = "Paraíso Novo";
            paraísoNovoToolStripMenuItem.Click += paraísoNovoToolStripMenuItem_Click;
           
            alphavilleToolStripMenuItem.CheckOnClick = true;
            alphavilleToolStripMenuItem.Name = "alphavilleToolStripMenuItem";
            alphavilleToolStripMenuItem.Size = new Size(151, 22);
            alphavilleToolStripMenuItem.Text = "Alphaville";
            alphavilleToolStripMenuItem.Click += alphavilleToolStripMenuItem_Click;
        
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, torre2ToolStripMenuItem, torre3ToolStripMenuItem, torre4ToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(64, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
           
            toolStripMenuItem1.CheckOnClick = true;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(110, 22);
            toolStripMenuItem1.Text = "Torre1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            
            torre2ToolStripMenuItem.CheckOnClick = true;
            torre2ToolStripMenuItem.Name = "torre2ToolStripMenuItem";
            torre2ToolStripMenuItem.Size = new Size(110, 22);
            torre2ToolStripMenuItem.Text = "Torre2";
            torre2ToolStripMenuItem.Click += torre2ToolStripMenuItem_Click;
           
            torre3ToolStripMenuItem.CheckOnClick = true;
            torre3ToolStripMenuItem.Name = "torre3ToolStripMenuItem";
            torre3ToolStripMenuItem.Size = new Size(110, 22);
            torre3ToolStripMenuItem.Text = "Torre3";
            
            torre4ToolStripMenuItem.CheckOnClick = true;
            torre4ToolStripMenuItem.Name = "torre4ToolStripMenuItem";
            torre4ToolStripMenuItem.Size = new Size(110, 22);
            torre4ToolStripMenuItem.Text = "Torre4";
          
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarMoradorToolStripMenuItem, pesquisaDeUsuárioToolStripMenuItem, usuáriosToolStripMenuItem1 });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(68, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            
            cadastrarMoradorToolStripMenuItem.Name = "cadastrarMoradorToolStripMenuItem";
            cadastrarMoradorToolStripMenuItem.Size = new Size(192, 22);
            cadastrarMoradorToolStripMenuItem.Text = "Cadastrar morador";
            cadastrarMoradorToolStripMenuItem.Click += cadastrarMoradorToolStripMenuItem_Click_1;
            
            pesquisaDeUsuárioToolStripMenuItem.Name = "pesquisaDeUsuárioToolStripMenuItem";
            pesquisaDeUsuárioToolStripMenuItem.Size = new Size(192, 22);
            pesquisaDeUsuárioToolStripMenuItem.Text = "Pesquisa de Morador";
            pesquisaDeUsuárioToolStripMenuItem.Click += pesquisaDeUsuárioToolStripMenuItem_Click;
            
            usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            usuáriosToolStripMenuItem1.Size = new Size(192, 22);
            usuáriosToolStripMenuItem1.Text = "Usuários";
           
            entregadorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarEntregadorToolStripMenuItem, procurarEntregadorToolStripMenuItem });
            entregadorToolStripMenuItem.Name = "entregadorToolStripMenuItem";
            entregadorToolStripMenuItem.Size = new Size(80, 20);
            entregadorToolStripMenuItem.Text = "Entregador";
            
            cadastrarEntregadorToolStripMenuItem.Name = "cadastrarEntregadorToolStripMenuItem";
            cadastrarEntregadorToolStripMenuItem.Size = new Size(193, 22);
            cadastrarEntregadorToolStripMenuItem.Text = "Cadastrar entregador";
            cadastrarEntregadorToolStripMenuItem.Click += cadastrarEntregadorToolStripMenuItem_Click;
          
            procurarEntregadorToolStripMenuItem.Name = "procurarEntregadorToolStripMenuItem";
            procurarEntregadorToolStripMenuItem.Size = new Size(193, 22);
            procurarEntregadorToolStripMenuItem.Text = "Pesquisar entregador";
            procurarEntregadorToolStripMenuItem.Click += procurarEntregadorToolStripMenuItem_Click;
         
            lojasParceirasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarLojasToolStripMenuItem, procurarLojasToolStripMenuItem });
            lojasParceirasToolStripMenuItem.Name = "lojasParceirasToolStripMenuItem";
            lojasParceirasToolStripMenuItem.Size = new Size(105, 20);
            lojasParceirasToolStripMenuItem.Text = "Lojas Parceiras";
          
            cadastrarLojasToolStripMenuItem.Name = "cadastrarLojasToolStripMenuItem";
            cadastrarLojasToolStripMenuItem.Size = new Size(163, 22);
            cadastrarLojasToolStripMenuItem.Text = "Cadastrar Lojas";
            cadastrarLojasToolStripMenuItem.Click += cadastrarLojasToolStripMenuItem_Click;
           
            procurarLojasToolStripMenuItem.Name = "procurarLojasToolStripMenuItem";
            procurarLojasToolStripMenuItem.Size = new Size(163, 22);
            procurarLojasToolStripMenuItem.Text = "Pesquisar Lojas";
            procurarLojasToolStripMenuItem.Click += procurarLojasToolStripMenuItem_Click;
          
            menuStrip1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { condomínioToolStripMenuItem, pedidosToolStripMenuItem, usuáriosToolStripMenuItem, entregadorToolStripMenuItem, lojasParceirasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(560, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(560, 323);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            ShowIcon = false;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void paraísoNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alphavilleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void torre2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarMoradorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form botao_cadastro_morador = new Form4();
            botao_cadastro_morador.Show();
        }

        private void cadastrarEntregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form botao_cadastro_entregador = new Form5();
            botao_cadastro_entregador.Show();
        }

        private void procurarEntregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarLojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form botao_cadastro_loja = new Form6();
            botao_cadastro_loja.Show();
        }

        private void procurarLojasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem condomínioToolStripMenuItem;
        private ToolStripMenuItem belaAlvoradaToolStripMenuItem;
        private ToolStripMenuItem paraísoNovoToolStripMenuItem;
        private ToolStripMenuItem alphavilleToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem torre2ToolStripMenuItem;
        private ToolStripMenuItem torre3ToolStripMenuItem;
        private ToolStripMenuItem torre4ToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem pesquisaDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem entregadorToolStripMenuItem;
        private ToolStripMenuItem cadastrarEntregadorToolStripMenuItem;
        private ToolStripMenuItem procurarEntregadorToolStripMenuItem;
        private ToolStripMenuItem lojasParceirasToolStripMenuItem;
        private ToolStripMenuItem cadastrarLojasToolStripMenuItem;
        private ToolStripMenuItem procurarLojasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarMoradorToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem1;
    }
}