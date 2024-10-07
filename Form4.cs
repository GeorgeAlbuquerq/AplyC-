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
    public partial class Form4 : Form
    {
        MySqlConnection Conexao;
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                string sql = "INSERT INTO moradores (nome, torre, apartamento)" + "Values " + "('" + textNomeM.Text + "', '" + textTorreM.Text + "', '" + textApartamentoM.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar " + ex.Message);
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
