using GM4.Configuração;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_serv_terceiros : Form
    {
        public Form_janela_serv_terceiros()
        {
            InitializeComponent();

            Carregar_empresa();
            Carregar_nome_relatorio();
            Carregar_identificador();

            Carregar_grid();


        }

        // Aba Relatorio

        private void Carregar_serv_terceiro02(string identificador)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\JP4", "config_app");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros where id_servi ='" + identificador + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Text = myreader["empresa"].ToString();
                    combo_nome.Text = myreader["nome"].ToString();
                    text_telefone.Text = myreader["telefone"].ToString();
                    text_email.Text = myreader["email"].ToString();
                    richText_serv_prestado.Text = myreader["serv_prestado"].ToString();
                    dt_inicio.Value = Convert.ToDateTime(myreader["data_inicio"].ToString());
                    dt_final.Value = Convert.ToDateTime(myreader["data_final"].ToString());
                    text_custo.Text = string.Format(myreader["custo_serv"].ToString(), "00,00");
                    text_identifica.Text = myreader["id_servi"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void carregar_serv_terceiro(string id_serv_terceiro)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros where id_serv_terceiro =" + Convert.ToInt32(id_serv_terceiro) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Text = myreader["empresa"].ToString();
                    combo_nome.Text = myreader["nome"].ToString();
                    text_telefone.Text = myreader["telefone"].ToString();
                    text_email.Text = myreader["email"].ToString();
                    richText_serv_prestado.Text = myreader["serv_prestado"].ToString();
                    dt_inicio.Value = Convert.ToDateTime(myreader["data_inicio"].ToString());
                    dt_final.Value = Convert.ToDateTime(myreader["data_final"].ToString());
                    text_custo.Text = string.Format(myreader["custo_serv"].ToString(), "00,00");
                    text_identifica.Text = myreader["id_servi"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_grid()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_servi_terceiros");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("empresa like '%{0}%'", empresa);
                //dv.RowFilter = string.Format("nome like '%{0}%'", nome);
                //dv.RowFilter = string.Format("data_final like '%{0}%'", data_final);
                Grid_relatorio_serv_terceiro.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_empresa(string empresa)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_servi_terceiros");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format("empresa like '%{0}%'", empresa);
                //dv.RowFilter = string.Format("nome like '%{0}%'", nome);
                //dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "data_final", data_final);

                Grid_relatorio_serv_terceiro.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_nome(string nome)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_servi_terceiros");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("empresa like '%{0}%'", empresa);
                dv.RowFilter = string.Format("nome like '%{0}%'", nome);
                //dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "data_final", data_final);

                Grid_relatorio_serv_terceiro.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_data(DateTime data_final)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_servi_terceiros");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("empresa like '%{0}%'", empresa);
                //dv.RowFilter = string.Format("nome like '%{0}%'", nome);
                dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "data_final", data_final);

                Grid_relatorio_serv_terceiro.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_empresa()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_empresa";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_relatorio_empresa.Items.Add(myreader["nome_empresa"].ToString());
                    combo_empresa.Items.Add(myreader["nome_empresa"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_nome_relatorio()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cad_prestadores";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_relatorio_nome.Items.Add(myreader["nome"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_identificador()
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_servi_terceiros";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_identificacao.Items.Add(myreader["id_servi"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_nome_prestadores(string empresa)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cad_prestadores where empresa ='" + empresa + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_nome.Items.Add(myreader["nome"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_telefone_prestador(string nome)
        {
            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                string comando_sql = "select * from db_cad_prestadores where nome ='" + nome + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    text_telefone.Text = myreader["telefone"].ToString();
                    text_email.Text = myreader["email"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Limpar_campos()
        {
            combo_empresa.Text = string.Empty;
            combo_nome.Text = string.Empty;
            text_telefone.Text = string.Empty;
            text_email.Text = string.Empty;
            richText_serv_prestado.Text = string.Empty;
            DateTime data_inicio = dt_inicio.Value;
            DateTime data_final = dt_final.Value;
            text_custo.Text = "0";
            text_identifica.Text = string.Empty;
        }
        private void Salvar_serv_terceiros()
        {
            string empresa = combo_empresa.Text;
            string nome = combo_nome.Text;
            string telefone = text_telefone.Text;
            string email = text_email.Text;
            string serv_prestado = richText_serv_prestado.Text;
            DateTime data_inicio = dt_inicio.Value;
            DateTime data_final = dt_final.Value;
            double custo_serv = Convert.ToDouble(text_custo.Text);
            string id_servi = text_identifica.Text;


            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "INSERT INTO db_servi_terceiros(empresa, nome, telefone, email, serv_prestado, data_inicio, data_final, custo_serv, id_servi) " +
                    " VALUES('" + empresa + "','" + nome + "','" + telefone + "','" + email + "','" + serv_prestado + "','" + data_inicio + "','" + data_final + "','" + custo_serv + "','" + id_servi + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }



        }
        private void Atualizar_servi_terceiros(string id_serv_terceiro)
        {
            string empresa = combo_empresa.Text;
            string nome = combo_nome.Text;
            string telefone = text_telefone.Text;
            string email = text_email.Text;
            string serv_prestado = richText_serv_prestado.Text;
            DateTime data_inicio = dt_inicio.Value;
            DateTime data_final = dt_final.Value;
            double custo_serv = Convert.ToDouble(text_custo.Text);
            string id_servi = text_identifica.Text;

            try
            {
                string comando_sql;

                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                comando_sql = "UPDATE db_servi_terceiros SET " +
                       "empresa='" + empresa +
                       "', nome='" + nome +
                       "', telefone='" + telefone +
                       "', email='" + email +
                       "', serv_prestado='" + serv_prestado +
                       "', data_inicio='" + data_inicio +
                       "', data_final='" + data_final +
                       "', custo_serv='" + custo_serv +
                       "', id_servi='" + id_servi +
                       "' WHERE id_serv_terceiro=" + id_serv_terceiro + "";


                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Excluir_servi_terceiros(string id_serv_terceiro)
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

                comando_sql = "DELETE FROM db_servi_terceiros WHERE id_serv_terceiro = " + Convert.ToInt32(id_serv_terceiro) + "";

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
            DialogResult resposta = MessageBox.Show(this, "Deseja lançar serviço ?", "Terceiros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Salvar_serv_terceiros();
                MessageBox.Show("Salvo com Sucesso!");
                Limpar_campos();

                combo_identificacao.Items.Clear();
                Carregar_identificador();
            }
            else if (resposta == DialogResult.No)
            {
                return;
            }
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_servi_terceiros(label_id_serv_prestado.Text);
            MessageBox.Show("Atualizado com sucesso!");
            Limpar_campos();

            combo_identificacao.Items.Clear();
            Carregar_identificador();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja confirmar exclusão?", "Terceiros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Excluir_servi_terceiros(label_id_serv_prestado.Text);
                MessageBox.Show("Deletado com sucesso!");
                Limpar_campos();

                combo_identificacao.Items.Clear();
                Carregar_identificador();
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

        private void combo_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_nome.Items.Clear();
            Carregar_nome_prestadores(combo_empresa.Text);
        }

        private void combo_nome_SelectedIndexChanged(object sender, EventArgs e)
        {

            Carregar_telefone_prestador(combo_nome.Text);
        }

        private void combo_relatorio_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_empresa(combo_relatorio_empresa.Text);
        }

        private void combo_relatorio_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_nome(combo_relatorio_nome.Text);
        }

        private void Grid_relatorio_serv_terceiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_serv_terceiros.Text = Grid_relatorio_serv_terceiro.CurrentRow.Cells[0].Value.ToString();

        }

        private void tab_servico_terceiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_grid();
        }

        private void button_limpar_filtro_relatorio_Click(object sender, EventArgs e)
        {

            combo_relatorio_empresa.Text = string.Empty;
            combo_relatorio_nome.Text = string.Empty;
            Carregar_grid();
        }

        private void dt_final_relatorio_ValueChanged(object sender, EventArgs e)
        {
            Filtrar_data(dt_final.Value);
        }

        private void Grid_relatorio_serv_terceiro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_serv_prestado.Text = Grid_relatorio_serv_terceiro.CurrentRow.Cells[0].Value.ToString();
            tab_servico_terceiros.SelectedTab = tab_serv_terceiro;
            carregar_serv_terceiro(label_id_serv_prestado.Text);
        }

        private void combo_identificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpar_campos();
            Carregar_serv_terceiro02(combo_identificacao.Text);
        }
    }
}
