using GM4.Configuração;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace GM4
{
    public partial class CONFIG : Form
    {
        public CONFIG()
        {
            InitializeComponent();

            //text_endereco.Text = Properties.Settings.Default.db_manutencaoConnectionString;

            Ler_arquivo_config_ini();



        }

       
        #region Metodos de config INI
        public void Criar_arquivo_padrao_INI()
        {
            IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");

            config_ini.IniWriteString("STRING_DB", "local_banco", string.Empty);
            config_ini.IniWriteString("LOCAL_ORIGEM_BK", "local_origem_bk", string.Empty);
            config_ini.IniWriteString("LOCAL_DESTINO_BK", "local_destino_bk", string.Empty);
            config_ini.IniWriteString("DT_ULTIMO_BK", "data_ultimo_bk", "01/01/2021");

        }

        public void criar_pasta_app()
        {
            string local_db = @"C:\GM4";

            string folderName = local_db;
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
                Criar_arquivo_padrao_INI();
            }
        }



        private void Ler_arquivo_config_ini()
        {
            IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");

            string local_default = @"C:\GM4";
            text_endereco.Text = config_ini.IniReadString("STRING_DB", "local_banco", local_default);
            text_endereco_backup_orig.Text = config_ini.IniReadString("LOCAL_ORIGEM_BK", "local_origem_bk", local_default);
            text_endereco_backup_dest.Text = config_ini.IniReadString("LOCAL_DESTINO_BK", "local_destino_bk", local_default);
            label_ultimo_bk.Text = config_ini.IniReadString("DT_ULTIMO_BK", "data_ultimo_bk", local_default);
        }
        private void gravar_configuracao_ini()
        {
            // Metodo de teste

            IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");

            config_ini.IniWriteString("STRING_DB", "local_banco", text_endereco.Text);
            config_ini.IniWriteString("LOCAL_ORIGEM_BK", "local_origem_bk", text_endereco.Text);
            config_ini.IniWriteString("LOCAL_DESTINO_BK", "local_destino_bk", text_endereco_backup_orig.Text);
            config_ini.IniWriteString("DT_ULTIMO_BK", "data_ultimo_bk", label_ultimo_bk.Text);

        }


        #endregion


        #region Metodos de Backup
        private void criar_pasta_backup(string local_db)
        {
            string folderName = local_db + @"\db_backup_gm4";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
        private void backup_db()
        {
            try
            {
                string fileName = "db_manutencao.mdb";
                string sourcePath = text_endereco_backup_orig.Text;
                string targetPath = text_endereco_backup_dest.Text;

                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, "bk_" + fileName);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(sourceFile, destFile, true);

                MessageBox.Show("Backup feito com sucesso!");

                label_ultimo_bk.Text = DateTime.Today.ToString("dd/MM/yyyy");

                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                config_ini.IniWriteString("DT_ULTIMO_BK", "data_ultimo_bk", label_ultimo_bk.Text);


                //Salvar_ultima_data_backup();
                //Reset_aplicativo();


            }
            catch (Exception)
            {
                MessageBox.Show("Falha durante o backup!");
            }
        }
        public void fazer_backup()
        {
            try
            {
                //string dataInicial = Properties.Settings.Default.dt_ultimo_backup;

                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                string dataInicial = config_ini.IniReadString("DT_ULTIMO_BK", "data_ultimo_bk", "01/11/2021");

                string dataFinal = Convert.ToString(DateTime.Today);


                TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);
                int totalDias = date.Days;
                //MessageBox.Show(totalDias.ToString());

                if (totalDias > 2)
                {
                    backup_db();
                }
            }
            catch (Exception)
            {
                //backup_db();
                MessageBox.Show("Erro ao fazer backup!");
            }


        }



        #endregion

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
        private string Procurar_pasta_backup()
        {
            string local_pasta;
            //string nome_arquivo;
            string endereco_completo = string.Empty;
            OpenFileDialog folderBrowser = new OpenFileDialog();

            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            folderBrowser.FileName = "Localizar Arquivo";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                local_pasta = Path.GetDirectoryName(folderBrowser.FileName);
                endereco_completo = local_pasta;
            }

            return endereco_completo;
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
            if (text_endereco.Text != string.Empty)
            {
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                config_ini.IniWriteString("STRING_DB", "local_banco", text_endereco.Text);

                MessageBox.Show("Salvo com sucesso!");

            }
            else
            {
                MessageBox.Show("Campo de endereço não pode ficar em branco!");
            }

        }
        private void button_busca_end_bk_Click(object sender, EventArgs e)
        {
            text_endereco_backup_orig.Text = Procurar_pasta_backup();
            criar_pasta_backup(text_endereco_backup_orig.Text);
            text_endereco_backup_dest.Text = text_endereco_backup_orig.Text + @"\db_backup_gm4";
        }
        private void button_salvar_end_bk_Click(object sender, EventArgs e)
        {
            if (text_endereco_backup_dest.Text != string.Empty)
            {
                IniFile config_ini = new IniFile(@"C:\GM4", "config_app_manutencao");
                //config_ini.IniWriteString("LOCAL_ORIGEM_BK", "local_origem_bk", text_endereco_backup_orig.Text);
                //criar_pasta_backup(text_endereco_backup_orig.Text);
                config_ini.IniWriteString("LOCAL_DESTINO_BK", "local_destino_bk", text_endereco_backup_dest.Text);
                
                MessageBox.Show("Salvo com sucesso!");

            }
            else
            {
                MessageBox.Show("Campo de endereço não pode ficar em branco!");
            }
        }
    }
}

