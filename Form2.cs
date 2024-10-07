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
    public partial class Form2 : Form

    {
        MySqlConnection Conexao;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //conexão com mysql
                string data_source = "datasource=127.0.0.1;username=root;password=123deolivera4;database=atividade";
                var Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //executar o comando Insert (inserir os dados)
                string sql = "INSERT INTO cadastro (nome, email, endereço, condominio, senha)" + "Values " + "('" + textNome.Text + "', '" + textEmail.Text + "', '" + textEndereco.Text + "', '" + textCondominio.Text + "', '" + textSenha.Text + "')";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form ir_login = new Form1();
            ir_login.Show();


        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
