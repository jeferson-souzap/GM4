using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_cad_peca : Form
    {
        public Form_janela_cad_peca()
        {
            InitializeComponent();

            Carregar_grid_componente();
            Carregar_local_aplicacao();
        }

        private void limpar_registro()
        {
            text_peca.Text = string.Empty;
            combo_local_aplicacao.Text = string.Empty;
            richTex_observacao.Text = string.Empty;
        }
        private void Carregar_local_aplicacao()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_equipamento";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_local_aplicacao.Items.Add(myreader["nome_equipamento"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carrega_pecas(string id_peca)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cadastro_peca where id_peca =" + Convert.ToInt32(id_peca) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_peca.Text = myreader["nome_peca"].ToString();
                    combo_local_aplicacao.Text = myreader["local_aplicacao"].ToString();
                    richTex_observacao.Text = myreader["observacao"].ToString();

                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Salvar_componente()
        {

            string nome_peca = text_peca.Text;
            string local_aplicacao = combo_local_aplicacao.Text;
            string observacao = richTex_observacao.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_cadastro_peca(nome_peca, local_aplicacao, observacao) " +
                    "VALUES('" + nome_peca + "','"+ local_aplicacao + "','"+ observacao + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_componente(string id_peca)
        {
            string nome_peca = text_peca.Text;
            string local_aplicacao = combo_local_aplicacao.Text;
            string observacao = richTex_observacao.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_cadastro_peca SET nome_peca='" + nome_peca + "',local_aplicacao='"+ local_aplicacao + "',observacao='"+ observacao + "'   WHERE id_peca=" + id_peca + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_componente(string id_peca)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_cadastro_peca WHERE id_peca = " + id_peca + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid_componente()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select id_peca, nome_peca, local_aplicacao, observacao from db_cadastro_peca";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_componentes");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_pecas.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja salvar ?", "Cadastro Componentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Salvar_componente();
                MessageBox.Show("Salvo com sucesso!");
                Carregar_grid_componente();
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
            Atualizar_componente(label_id_peca.Text);
            MessageBox.Show("Atualizado Com sucesso!");
            Carregar_grid_componente();
            limpar_registro();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja Deletar Registro ?", "Cadastro Componentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Deletar_componente(label_id_peca.Text);
                MessageBox.Show("Deletado com sucesso!");
                Carregar_grid_componente();
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

        private void Grid_cad_pecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_peca.Text = Grid_cad_pecas.CurrentRow.Cells[0].Value.ToString();
            Carrega_pecas(label_id_peca.Text);
        }

        private void Grid_cad_pecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_limpar_campos_Click(object sender, EventArgs e)
        {
            text_peca.Text = string.Empty;
            combo_local_aplicacao.Text = string.Empty;
            richTex_observacao.Text = "..";
        }
    }
}
