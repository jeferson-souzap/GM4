﻿using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_config : Form
    {




        public Form_janela_config()
        {
            InitializeComponent();


            text_endereco.Text = Properties.Settings.Default.db_manutencaoConnectionString;

        }

        //01 - definir o caminho do banco de dados padrão
        //02 - Definir o caminho dos arquivo exportados do sistema AC4
        //03 - SAlvar os caminhos no campo de configuração do aplicativo
        //04 - puxar os caminhos assim que abrir a aba de config >> CONF01

        //Extra
        //05 - Local pra mostrar a versão do arquivo
        //06 - Criar e mostrar a documentação de uso de cada tela do programa
        //07 - Criar um botão de buscar atualização e baixar quando estiver disponivel ( ainda nao resolvido o servidor FTP )

        // link util >> http://www.macoratti.net/15/03/c_locarq1.htm

        private void Testar_conexao()
        {

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                OleDbConnection connection = new OleDbConnection(conecta_string);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    label_status_con.Text = "Conectado com sucesso!";

                }
                else
                {
                    label_status_con.Text = "Não conectado, verifique o local!";

                }
                connection.Close();

            }
            catch (Exception)
            {
                //MessageBox.Show(erro.Message);
            }


        }
        private string Procurar_pasta()
        {
            string local_pasta = string.Empty;
            string nome_arquivo = string.Empty;
            string endereco_completo = string.Empty;
            string texto_conecta = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";


            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                nome_arquivo = Path.GetFileName(folderBrowser.FileName);

                endereco_completo = texto_conecta + @"""" + local_pasta + @"\" + nome_arquivo + @"""";
            }

            return endereco_completo;
        }
        private void Salvar_local()
        {

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionString = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionString.ConnectionStrings["GM4.Properties.Settings.db_manutencaoConnectionString"].ConnectionString = text_endereco.Text; //"Data Source=NewSource;Initial Catalog=NewCatalog;UID=NewUser;password=NewPassword";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");                

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void Reset_aplicativo()
        {
            MessageBox.Show("Aplicativo deve ser reiniciado!");
            Application.Restart();
        }


        private void button_buscar_local_Click(object sender, EventArgs e)
        {
            text_endereco.Text = Procurar_pasta();
        }

        private void button_salvar_endereco_Click(object sender, EventArgs e)
        {

            Salvar_local();
            Testar_conexao();
            Reset_aplicativo();


        }
    }
}
