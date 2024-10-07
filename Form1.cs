using MySql.Data.MySqlClient;

namespace Aply
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                var strConexao = "server=localhost;uid=root;pwd=123deolivera4";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexao está correta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar se conectar à DB" + ex.Message);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form botao_logar = new Form3();
            botao_logar.Show();
            /*try
             {
                 //conexão com mysql
                 string data_source = "datasource=127.0.0.1;username=root;password=123deolivera4;database=atividade";
                 var Conexao = new MySqlConnection(data_source);
                 Conexao.Open();

                 //executar o comando Insert (inserir os dados)
                 string sql = "SELECT * FROM login (emails, senhas)" + "Values " + "('" + textEmail.Text + "', '" + textSenha.Text + "')";

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

        } */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form botao_cadastro = new Form2();
            botao_cadastro.Show();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}