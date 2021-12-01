using GM4.Configuração;
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
    public partial class Form_cad_equipamento : Form
    {
        public Form_cad_equipamento()
        {
            InitializeComponent();

            Carregar_grid();
        }


        private void limpar_campos()
        {
            text_equipamento.Text = string.Empty;
            text_descri_equipamento.Text = string.Empty;
            label_id_equipamento.Text = "---";
        }

        private void Carregar_grid()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_equipa, empresa, nome_equipamento, descri_equipamento from db_equipamento";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_equipamento");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_equipamento.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_equipamento(string id_componentes)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_equipamento where id_equipa = " + Convert.ToInt32(id_componentes) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_equipamento.Text = myreader["nome_equipamento"].ToString();
                    text_descri_equipamento.Text = myreader["descri_equipamento"].ToString();

                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Salvar_componente(string nome_equipamento, string descri_equipamento)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_equipamento(nome_equipamento, descri_equipamento) VALUES('" + nome_equipamento + "','"+ descri_equipamento + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_equipamento(string nome_equipamento, string descri_equipamento, string id_equipa)
        {
            try
            {
                string comando_sql;

                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_equipamento SET nome_equipamento='" + nome_equipamento + "', descri_equipamento='" + descri_equipamento + "' WHERE id_equipa=" + id_equipa + "";
                

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void deletar_equipamento(string id_equipa)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_equipamento WHERE id_equipa = " + Convert.ToInt32(id_equipa) + "";

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
            Salvar_componente(text_equipamento.Text, text_descri_equipamento.Text);
            MessageBox.Show("Salvo com sucesso");
            Carregar_grid();
            limpar_campos();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_equipamento(text_equipamento.Text, text_descri_equipamento.Text, label_id_equipamento.Text);
            MessageBox.Show("Atualiado Com sucesso!");
            Carregar_grid();
            limpar_campos();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            deletar_equipamento(label_id_equipamento.Text);
            MessageBox.Show("Deletado com sucesso!");
            Carregar_grid();
            limpar_campos();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_cad_equipamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_equipamento.Text = Grid_cad_equipamento.CurrentRow.Cells[0].Value.ToString();
            Carregar_equipamento(label_id_equipamento.Text);
        }
    }
}
