using MySql.Data.MySqlClient;
namespace conectionBd

{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Condicional de verificação de label aberto

            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira seu nome");
            }
            else
            {
                button1.Enabled = false;
            }



            if (txtEmail.Text == "")
            {
                MessageBox.Show("Insira seu Email");
            }
            else
            {
                button1.Enabled = false;
            }

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Insira seu Telefone");
            }

            // Bloqueio de inserção no banco sem dados
            else
            {
                button1.Enabled = false;
            }
            // Validação ultilizando o uso de Try e Catch

            try
            {
                // Parametros de conexão

                string dataSource = "datasource=localhost;username=root;password=;database=db_agenda";


                // Criar conex�o MySql
                Conexao = new MySqlConnection(dataSource);

                // Executar Comando Insert

                string sql = "INSERT INTO contato (nome , email , telefone) VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";

                // Executar comando no banco com conexão

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Seus dados foram inseridos corretamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }


    }
}