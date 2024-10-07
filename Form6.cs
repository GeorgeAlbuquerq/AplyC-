using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form6 : Form
    {
        MySqlConnection Conexao;
        public Form6()
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
                string sql = "INSERT INTO lojas (nome, endereço)" + "Values " + "('" + textNomeL.Text + "', '" + textEndereçoL.Text + "')";

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

        private void BuscaLojas_Click(object sender, EventArgs e)
        {


            //conexão com mysql
            string data_source = "datasource=127.0.0.1;username=root;password=123deolivera4;database=atividade";
            var Conexao = new MySqlConnection(data_source);
            Conexao.Open();

            //executar o comando Insert (inserir os dados)
            string sql = "SELECT * FROM lojas (nome, endereço)" + "Values " + "('" + textNomeL.Text + "', '" + textEndereçoL.Text + "')";

            
        }
    }
}
