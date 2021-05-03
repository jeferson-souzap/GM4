using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_cad_preventiva : Form
    {
        public Form_janela_cad_preventiva()
        {
            InitializeComponent();

            Carregar_grid_atividade();
        }


        private void limpar_registro()
        {
            text_atividade.Text = string.Empty;
        }
        private void Carregar_atividade(string id_atividade)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_atividades where id_atividade =" + Convert.ToInt32(id_atividade) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_atividade.Text = myreader["nome_atividade"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Salvar_atividade()
        {

            string nome_atividade = text_atividade.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_atividades(nome_atividade) VALUES('" + nome_atividade + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_atividades(string id_atividade)
        {
            string nome_atividade = text_atividade.Text;

            try
            {
                string comando_sql;
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_atividades SET nome_atividade ='" + nome_atividade + "' WHERE id_atividade =" + Convert.ToInt32(id_atividade);
                
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_atividade(string id_atividade)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_atividades WHERE id_atividade = " + Convert.ToInt32(id_atividade);

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid_atividade()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select id_atividade, nome_atividade from db_atividades";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_atividades");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_atividade.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Grid_cad_atividade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_atividade.Text = Grid_cad_atividade.CurrentRow.Cells[0].Value.ToString();
            Carregar_atividade(label_id_atividade.Text);
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja salvar ?", "Cadastro Atividades", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Salvar_atividade();
                MessageBox.Show("Salvo com sucesso!");
                Carregar_grid_atividade();
                limpar_registro();
                return;
            }
            else if (resposta == DialogResult.No)
            {
                return;
            }
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_atividades(label_id_atividade.Text);
            MessageBox.Show("Atualizado Com sucesso!");
            Carregar_grid_atividade();
            limpar_registro();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja Deletar ?", "Cadastro Ativdades", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Deletar_atividade(label_id_atividade.Text);
                MessageBox.Show("Salvo com sucesso!");
                Carregar_grid_atividade();
                limpar_registro();
                return;
            }
            else if (resposta == DialogResult.No)
            {
                return;
            }
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
