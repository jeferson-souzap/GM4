using GM4.Configuração;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_inicial : Form
    {
        public Form_inicial()
        {
            InitializeComponent();
            Testar_conecxao();

            string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            

            StripStatus_versao.Text = "| Versão do Aplicativo >> " + ver + " | ";
            label_titulo_janela.Text = string.Empty;

            CONFIG janela_config = new CONFIG();
            janela_config.fazer_backup();
            janela_config.criar_pasta_app();




        }
        
        
        private void Testar_conecxao()
        {

            try
            {
                //string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string local_default = @"C:\GM4";
                string conecta_string = config_ini.IniReadString("STRING_DB", "local_banco", local_default);

                OleDbConnection connection = new OleDbConnection(conecta_string);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    StatusLabel_conexao_db.Text = "Banco de dados Conectado com sucesso!";

                }
                else
                {
                    StatusLabel_conexao_db.Text = "Banco de dados Não conectado!";

                }


                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show(erro.Message);
            }


        }

        private void abrir_janelas(object formularios)
        {
            if (this.panel_central.Controls.Count > 0)
                this.panel_central.Controls.RemoveAt(0);

            Form janela = formularios as Form;
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.panel_central.Controls.Add(janela);
            this.panel_central.Tag = janela;
            janela.Show();
        }

        private void button_ordem_serv_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_ordem());
            label_titulo_janela.Text = "Janela de Abertura e Fechamento de Ordem!";

        }

        private void button_cad_ativ_preventiva_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_preventiva());
            label_titulo_janela.Text = "Cadastro de Preventivas";
        }

        private void button_cad_componentes_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_cad_componentes());
            label_titulo_janela.Text = "Cadastro de Componentes";
        }

        private void button_cad_equipamento_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_cad_equipamento());
            label_titulo_janela.Text = "Cadastro de Equipamentos";
        }

        private void button_prestadores_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_prestadores());
            label_titulo_janela.Text = "Cadastro de Prestadores";
        }

        private void button_colaboradores_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_executante());
            label_titulo_janela.Text = "Cadastro de Executantes";
        }

        private void button_serv_terceiros_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_serv_terceiros());
            label_titulo_janela.Text = "Lançamento de serviço de terceiros";
        }

        private void button_cad_pecas_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_peca());
            label_titulo_janela.Text = "Cadastro de Peça";

        }

        private void button_configuração_Click(object sender, EventArgs e)
        {
            abrir_janelas(new CONFIG());
        }

        private void button_baixa_pc_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_baixa_peca());
        }
    }
}
