using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_baixa_peca : Form
    {
        public Form_janela_baixa_peca()
        {
            InitializeComponent();

            Carregar_material();
            Carregar_tipo_movi();

            Carregar_unid_medida();
            Carregar_ordem_serv();

            Carregar_grid_relatorio();

            Carregar_empresa();

            Carregar_ordem_relatorio();
        }

        private void Carregar_empresa()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_empresa";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Items.Add(myreader["nome_empresa"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Carregar_material()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cadastro_peca";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_material.Items.Add(myreader["nome_peca"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_tipo_movi()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cad_tipo_movi";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_tipo_movimento.Items.Add(myreader["nome_movimento"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private string carregar_unidade01(string nome_peca)
        {
            string resultado = string.Empty;
            try
            {

                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cadastro_peca where nome_peca ='" + nome_peca + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado = myreader["und_medida"].ToString();
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return resultado;

        }
        private void Carregar_unid_medida()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_cad_unidade_medida";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_unidade_medida.Items.Add(myreader["nome_unidade"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            // db_cad_unidade_medida
            // nome_unidade
        }
        private void Carregar_ordem_serv()
        {
            // Programada
            try
            {
                string status = "Programada";
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "SELECT DISTINCT  num_os FROM db_ordem_servi where status = '" + status + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_ordem_serv.Items.Add(myreader["num_os"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_ordem_relatorio()
        {
            try 
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "SELECT DISTINCT  ordem_servi FROM db_baixa_material";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_relatorio_ordem_serv.Items.Add(myreader["ordem_servi"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void carregar_registro_baixa(string id_material)
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_baixa_material where id_material=" + Convert.ToDouble(id_material);

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_empresa.Text = myreader["empresa"].ToString();
                    combo_material.Text = myreader["material_usado"].ToString();
                    text_qtd_usada.Text = myreader["qtd_usada"].ToString();
                    combo_unidade_medida.Text = myreader["und_medida"].ToString();
                    combo_ordem_serv.Text = myreader["ordem_servi"].ToString();
                    combo_tipo_movimento.Text = myreader["tipo_movimento"].ToString();
                    dt_baixa.Value = Convert.ToDateTime(myreader["data_movimento"].ToString());
                    rich_observacao.Text = myreader["observacao"].ToString();

                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #region Controles_relatorio / filtros

        private void Carregar_grid_relatorio()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select id_material, empresa, material_usado, qtd_usada, und_medida, ordem_servi, tipo_movimento, data_movimento, observacao from db_baixa_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_baixa_material");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                //dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_relatorio_baixa_peca.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_data(DateTime data_baixa)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_baixa_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_baixa_material");
                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "data_movimento", data_baixa);

                Grid_relatorio_baixa_peca.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_Mes(int mes_movi)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_baixa_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_baixa_material");
                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "mes_movi", mes_movi);

                Grid_relatorio_baixa_peca.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Filtrar_ano(int ano_movi)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_baixa_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_baixa_material");
                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "ano_movi", ano_movi);

                Grid_relatorio_baixa_peca.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void filtrar_ordem_serv(double ordem_servi)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_baixa_material";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_baixa_material");
                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Convert([{0}], System.String) LIKE '%{1}%'", "ordem_servi", ordem_servi);

                Grid_relatorio_baixa_peca.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void Filtrar_tipo_movi(string tipo_movi)
        {

        }

        #endregion

        private void limpar_campos()
        {
            combo_empresa.Text = string.Empty;
            combo_material.Text = string.Empty;
            text_qtd_usada.Text = "0";
            combo_unidade_medida.Text = string.Empty;
            combo_ordem_serv.Text = string.Empty;
            combo_tipo_movimento.Text = string.Empty;
            //DateTime data_movimento = dt_baixa.Value;
            //int mes_movi = data_movimento.Month;
            //int ano_movi = data_movimento.Year;
            rich_observacao.Text = string.Empty;
        }
        private void Confirmar_baixar()
        {
            string empresa = combo_empresa.Text;
            string material_usado = combo_material.Text;
            double qtd_usada = Convert.ToDouble(text_qtd_usada.Text);
            string und_medida = combo_unidade_medida.Text;
            double ordem_servi = Convert.ToDouble(combo_ordem_serv.Text);
            string tipo_movimento = combo_tipo_movimento.Text;
            DateTime data_movimento = dt_baixa.Value;
            int mes_movi = data_movimento.Month;
            int ano_movi = data_movimento.Year;
            string observacao = rich_observacao.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();
                string comando_sql;

                comando_sql = "INSERT INTO db_baixa_material(empresa, material_usado, qtd_usada, und_medida, ordem_servi, tipo_movimento, data_movimento, mes_movi, ano_movi, observacao) " +
                    "VALUES('" + empresa + "','" + material_usado + "','" + qtd_usada + "','" + und_medida + "','" + ordem_servi + "','" + tipo_movimento + "','" + data_movimento + "','" + mes_movi + "','" + ano_movi + "','" + observacao + "')";

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Baixa feita com sucesso!");
                limpar_campos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }
        private void Atualizar_baixa(string id_material)
        {
            string empresa = combo_empresa.Text;
            string material_usado = combo_material.Text;
            double qtd_usada = Convert.ToDouble(text_qtd_usada.Text);
            string und_medida = combo_unidade_medida.Text;
            double ordem_servi = Convert.ToDouble(combo_ordem_serv.Text);
            string tipo_movimento = combo_tipo_movimento.Text;
            DateTime data_movimento = dt_baixa.Value;
            int mes_movi = data_movimento.Month;
            int ano_movi = data_movimento.Year;
            string observacao = rich_observacao.Text;

            try
            {
                string comando_sql;
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();
                comando_sql = "UPDATE db_baixa_material SET " +
                        "empresa='" + empresa +
                        "', material_usado='" + material_usado +
                        "', qtd_usada='" + qtd_usada +
                        "', und_medida='" + und_medida +
                        "', ordem_servi='" + ordem_servi +
                        "', tipo_movimento='" + tipo_movimento +
                        "', data_movimento='" + data_movimento +
                        "', mes_movi='" + mes_movi +
                        "', ano_movi='" + ano_movi +
                        "', observacao='" + observacao +
                        "' WHERE id_material=" + Convert.ToDouble(id_material);


                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Atualizado com sucesso!");
                limpar_campos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Deletar_baixa(string id_material)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection conexao = new OleDbConnection(conecta_string);
                conexao.Open();

                string comando_sql;

                comando_sql = "DELETE FROM db_baixa_material WHERE id_material = " + Convert.ToDouble(id_material);

                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Deletado com sucesso!");
                limpar_campos();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void combo_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_unidade_medida.Text = carregar_unidade01(combo_material.Text);
        }

        private void dt_relatorio_data_ValueChanged(object sender, EventArgs e)
        {
            Filtrar_data(dt_relatorio_data.Value);
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            Confirmar_baixar();
            Carregar_grid_relatorio();
            //limpar_campos();
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_baixa(label_id_peca.Text);
            Carregar_grid_relatorio();
            //limpar_campos();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Deletar_baixa(label_id_peca.Text);
            Carregar_grid_relatorio();
            //limpar_campos();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_relatorio_baixa_peca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_baixa_peca.Text = Grid_relatorio_baixa_peca.CurrentRow.Cells[0].Value.ToString();

        }

        private void Grid_relatorio_baixa_peca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id_baixa_peca.Text = Grid_relatorio_baixa_peca.CurrentRow.Cells[0].Value.ToString();
            label_id_peca.Text = label_id_baixa_peca.Text;
            tab_janela_baixa_peca.SelectedTab = tab_baixa_pecas;
            carregar_registro_baixa(label_id_baixa_peca.Text);
        }

        private void combo_relatorio_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_Mes(Convert.ToInt32(combo_relatorio_mes.Text));
        }

        private void combo_relatorio_ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar_ano(Convert.ToInt32(combo_relatorio_ano.Text));
        }

        private void combo_relatorio_ordem_serv_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar_ordem_serv(Convert.ToDouble(combo_relatorio_ordem_serv.Text));
        }

        private void button_limpar_filtro_Click(object sender, EventArgs e)
        {
            Carregar_grid_relatorio();
        }
    }

}
