using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aply
{
    public partial class Form5 : Form
    {
        MySqlConnection Conexao;
        public Form5()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //conexão com mysql
                string data_source = "datasource=127.0.0.1;username=root;password=123deolivera4;database=atividade";
                var Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //executar o comando Insert (inserir os dados)
                string sql = "INSERT INTO entregador (nome, loja)" + "Values " + "('" + textNomeE.Text + "', '" + textLojaE.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar logar " + ex.Message);
            }
            finally
            {
                if (Conexao != null)
                {
                    Conexao.Close();
                }
            }
        }
    }
}
