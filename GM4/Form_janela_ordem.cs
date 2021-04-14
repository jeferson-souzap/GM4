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
    public partial class Form_janela_ordem : Form
    {
        public Form_janela_ordem()
        {
            InitializeComponent();

            Carregar_equipamentos();
            Carregar_tipo_servi();
            Carregar_periodicidade();
            Carregar_componentes();

        }


        #region Metodos / Calculos / funções


        #endregion

        #region Carregar controles
        private void Carregar_equipamentos()
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
                    combo_equipamento.Items.Add(myreader["nome_equipamento"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_tipo_servi()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_tipo_serv";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_tipo_serv.Items.Add(myreader["tipo_servico"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void Carregar_periodicidade()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_periodos_manutencao";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_periodicidade.Items.Add(myreader["periodicidade"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_componentes()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_componentes";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_componente01.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente02.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente03.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente04.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente05.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente06.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente07.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente08.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente09.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente10.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente11.Items.Add(myreader["nome_componente"].ToString());
                    combo_componente12.Items.Add(myreader["nome_componente"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void Carregar_executante()
        {

        }

        #endregion


        #region Botoes

        private void button_abrir_os_Click(object sender, EventArgs e)
        {

        }

        private void button_fechar_os_Click(object sender, EventArgs e)
        {

        }

        private void button_encerrar_Click(object sender, EventArgs e)
        {

        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void button_excluir_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
