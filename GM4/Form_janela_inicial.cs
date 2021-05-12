using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_inicial : Form
    {
        public Form_inicial()
        {
            InitializeComponent();
            Testar_conecxao();

            StripStatus_versao.Text = "| Versão do Aplicativo >> " + Application.ProductVersion + " | ";


        }

        private void Testar_conecxao()
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
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
        }

        private void button_cad_ativ_preventiva_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_preventiva());
        }

        private void button_cad_componentes_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_cad_componentes());
        }

        private void button_cad_equipamento_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_cad_equipamento());
        }

        private void button_prestadores_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_prestadores());
        }

        private void button_colaboradores_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_executante());
        }

        private void button_serv_terceiros_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_serv_terceiros());
        }

        private void button_cad_pecas_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_cad_peca());
        }

        private void button_configuração_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_janela_config());
        }
    }
}
