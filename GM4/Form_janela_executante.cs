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
    public partial class Form_janela_executante : Form
    {
        public Form_janela_executante()
        {
            InitializeComponent();

            Carregar_grid();

        }

        private void Carregar_grid()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_executante";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_executante");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_executante.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_executante(string id_executante)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_executante where id_executante = " + Convert.ToInt32(id_executante) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_cod_executante.Text = myreader["cod_executante"].ToString();
                    text_executante.Text = myreader["nome_executante"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void Salvar_executante_terceiros(string nome_executante, string cod_executante = "10")
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_executante(cod_executante,nome_executante ) VALUES('" + cod_executante + "','" + nome_executante + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Salvar_executante()
        {
            string cod_executante = text_cod_executante.Text;
            string nome_executante = text_executante.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_executante(cod_executante,nome_executante ) VALUES('" + cod_executante + "','"+ nome_executante + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Atualizar_executante(string id_executante)
        {

            string cod_executante = text_cod_executante.Text;
            string nome_executante = text_executante.Text;

            try
            {
                string comando_sql;

                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_executante SET cod_executante='" + cod_executante + "', nome_executante='"+ nome_executante + "'  WHERE id_executante=" + Convert.ToInt32(id_executante) + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Deletar_executante(string id_executante)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_executante WHERE id_executante = " + id_executante + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Salvar_executante();
            MessageBox.Show("Salvo com sucesso!");
            Carregar_grid();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_executante(label_id_executante.Text);
            MessageBox.Show("Atualizado com sucesso!");
            Carregar_grid();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Deletar_executante(label_id_executante.Text);
            MessageBox.Show("Deletado com sucesso!");
            Carregar_grid();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_cad_executante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_executante.Text = Grid_cad_executante.CurrentRow.Cells[0].Value.ToString();
            Carregar_executante(label_id_executante.Text);
        }
    }
}
