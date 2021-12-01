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
    public partial class Form_cad_componentes : Form
    {
        public Form_cad_componentes()
        {
            InitializeComponent();

            Carregar_grid();

            bloquear_controles();
        }

        private void bloquear_controles()
        {
            textBox_componente.Enabled = false;
            richText_observacao.Enabled = false;
            label_id_componente.Enabled = false;
        }

        private void desbloquear_controles()
        {
            textBox_componente.Enabled = true;
            richText_observacao.Enabled = true;
            label_id_componente.Enabled = true;
        }

        private void Carregar_grid()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select id_componentes, nome_componente, observacao from db_componentes";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_componentes");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_cad_componentes.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void carregar_componente(string id_componentes)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_componentes where id_componentes = "+ Convert.ToInt32(id_componentes) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    textBox_componente.Text = myreader["nome_componente"].ToString();
                    richText_observacao.Text = myreader["observacao"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Salvar_componente(string nome_componente, string observacao)
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

                comando_sql = "INSERT INTO db_componentes(nome_componente, observacao) " +
                    "VALUES('" + nome_componente +"','"+ observacao+ "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
                
                MessageBox.Show("Salvo Com sucesso!");
                Carregar_grid();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Atualizar_componente(string nome_componente,  string observacao, string id_componentes)
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

                comando_sql = "UPDATE db_componentes SET nome_componente='" + nome_componente + "', observacao='" + observacao +"' WHERE id_componentes=" + Convert.ToDouble(id_componentes) + "";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado Com sucesso!");
                Carregar_grid();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void deletar_componente(string id_componentes)
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

                comando_sql = "DELETE FROM db_componentes WHERE id_componentes = "+ id_componentes + "";

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
            Salvar_componente(textBox_componente.Text, richText_observacao.Text);
            bloquear_controles();
        }
        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_componente(textBox_componente.Text, richText_observacao.Text, label_id_componente.Text);
            bloquear_controles();
        }
        private void button_excluir_Click(object sender, EventArgs e)
        {
            deletar_componente(label_id_componente.Text);
            MessageBox.Show("Exluido Sucesso!");
            Carregar_grid();
            bloquear_controles();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_cad_componentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_componente.Text = Grid_cad_componentes.CurrentRow.Cells[0].Value.ToString();
            carregar_componente(label_id_componente.Text);
        }

        private void button_iniciar_cadastro_Click(object sender, EventArgs e)
        {
            desbloquear_controles();
        }
    }
}
