using System;
using System.Data.OleDb;
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
            Carregar_executante();
            Carregar_empresa();
        }


        #region Metodos / Calculos / funções
        private TimeSpan calculo_hora(DateTime hora_inicio, DateTime hora_fim)
        {
            TimeSpan resultado;

            TimeSpan horaIni = new TimeSpan(hora_inicio.Hour, hora_inicio.Minute, 0);
            TimeSpan horaFim = new TimeSpan(hora_fim.Hour, hora_fim.Minute, 0);
            resultado = horaFim.Subtract(horaIni);

            if (horaFim < horaIni)
            {
                return TimeSpan.FromHours(0);
            }
            else
            {
                return resultado;
            }

        }
        private double gerar_ordem_serv()
        {
            double ordem = 0;
            double resultado = 0;

            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select num_os from db_ordem_servi where num_os = (select max(num_os) from db_ordem_servi)";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado = Convert.ToDouble(myreader["num_os"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


            ordem = resultado + 1;

            return ordem;
        }
        private void Salvar_os()
        {

            string empresa = combo_empresa.Text;
            double num_os = Convert.ToDouble(label_numero_os.Text);
            string equipamento = combo_equipamento.Text;
            string tipo_servico = combo_tipo_serv.Text;
            DateTime data_solicitacao = dt_solicitacao.Value;
            int dia_emissao = data_solicitacao.Day;
            int mes_emissao = data_solicitacao.Month;
            int ano_emissao = data_solicitacao.Year;

            string maquina_parada = " ";

            if (check_sim.Checked)
            {
                maquina_parada = "Sim";
                check_nao.Checked = false;
            }

            if (check_nao.Checked)
            {
                maquina_parada = "Não";
                check_sim.Checked = false;
            }

            int horas_parada = Convert.ToInt32(text_hr_paradas.Text);
            string periodicidade = combo_periodicidade.Text;
            int periodo_meses = Convert.ToInt32(combo_periodo_meses.Text);
            int periodo_anos = Convert.ToInt32(combo_periodo_anos.Text);

            string componente;
            string atividade;
            string executante;
            DateTime hora_inicio;
            DateTime hora_final;
            TimeSpan total_horas;
            string status = "";
            string obs = richText_observacao.Text;

            if (combo_componente01.Text != string.Empty && text_atividades01.Text != string.Empty)
            {
                componente = combo_componente01.Text;
                atividade = text_atividades01.Text;
                executante = combo_executante01.Text;
                hora_inicio = hr_inicio_ativ_01.Value;
                hora_final = hr_final_ativ_01.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente02.Text != string.Empty && text_atividades02.Text != string.Empty)
            {
                componente = combo_componente02.Text;
                atividade = text_atividades02.Text;
                executante = combo_executante02.Text;
                hora_inicio = hr_inicio_ativ_02.Value;
                hora_final = hr_final_ativ_02.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente03.Text != string.Empty && text_atividades03.Text != string.Empty)
            {
                componente = combo_componente03.Text;
                atividade = text_atividades03.Text;
                executante = combo_executante03.Text;
                hora_inicio = hr_inicio_ativ_03.Value;
                hora_final = hr_final_ativ_03.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente04.Text != string.Empty && text_atividades04.Text != string.Empty)
            {
                componente = combo_componente04.Text;
                atividade = text_atividades04.Text;
                executante = combo_executante04.Text;
                hora_inicio = hr_inicio_ativ_04.Value;
                hora_final = hr_final_ativ_04.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente05.Text != string.Empty && text_atividades05.Text != string.Empty)
            {
                componente = combo_componente05.Text;
                atividade = text_atividades05.Text;
                executante = combo_executante05.Text;
                hora_inicio = hr_inicio_ativ_05.Value;
                hora_final = hr_final_ativ_05.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente06.Text != string.Empty && text_atividades06.Text != string.Empty)
            {
                componente = combo_componente06.Text;
                atividade = text_atividades06.Text;
                executante = combo_executante06.Text;
                hora_inicio = hr_inicio_ativ_06.Value;
                hora_final = hr_final_ativ_06.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente07.Text != string.Empty && text_atividades07.Text != string.Empty)
            {
                componente = combo_componente07.Text;
                atividade = text_atividades07.Text;
                executante = combo_executante07.Text;
                hora_inicio = hr_inicio_ativ_07.Value;
                hora_final = hr_final_ativ_07.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente08.Text != string.Empty && text_atividades08.Text != string.Empty)
            {
                componente = combo_componente08.Text;
                atividade = text_atividades08.Text;
                executante = combo_executante08.Text;
                hora_inicio = hr_inicio_ativ_08.Value;
                hora_final = hr_final_ativ_08.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente09.Text != string.Empty && text_atividades09.Text != string.Empty)
            {
                componente = combo_componente09.Text;
                atividade = text_atividades09.Text;
                executante = combo_executante09.Text;
                hora_inicio = hr_inicio_ativ_09.Value;
                hora_final = hr_final_ativ_09.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente10.Text != string.Empty && text_atividades10.Text != string.Empty)
            {
                componente = combo_componente10.Text;
                atividade = text_atividades10.Text;
                executante = combo_executante10.Text;
                hora_inicio = hr_inicio_ativ_10.Value;
                hora_final = hr_final_ativ_10.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente11.Text != string.Empty && text_atividades11.Text != string.Empty)
            {
                componente = combo_componente11.Text;
                atividade = text_atividades11.Text;
                executante = combo_executante11.Text;
                hora_inicio = hr_inicio_ativ_11.Value;
                hora_final = hr_final_ativ_11.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (combo_componente12.Text != string.Empty && text_atividades12.Text != string.Empty)
            {
                componente = combo_componente12.Text;
                atividade = text_atividades12.Text;
                executante = combo_executante12.Text;
                hora_inicio = hr_inicio_ativ_12.Value;
                hora_final = hr_final_ativ_12.Value;
                total_horas = calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "')";

                    OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        }

        private void Abrir_ordem_preventiva(string periodicidade, int Qtde_Meses, int Qtde_Anos)
        {
            int Qtde_OS = 0;
            int Prox_Prev = 0; // Soma esse valor a data de abertura da ordem preventiva ou seja se for 30 vai somar 30 dias a partir da data de abertura

            // "Semanal"
            //"Quinzenal"
            //"Mensal"
            //"Bimestral"
            //"Trimestral"
            //"Quadrimestral"
            // "Semestral"
            //"Anual"
            if (combo_seleciona_os.Text == "Semanal")
            {
                Qtde_OS = 48;
                Prox_Prev = 7;
            }
            else if (combo_seleciona_os.Text == "Quinzenal")
            {
                Qtde_OS = 24;
                Prox_Prev = 15;
            }
            else if (combo_seleciona_os.Text == "Mensal")
            {
                Qtde_OS = 12;
                Prox_Prev = 30;
            } else if (combo_seleciona_os.Text == "Trimestral")
            {
                Qtde_OS = 4;
                Prox_Prev = 90;
            } else if (combo_seleciona_os.Text == "Quadrimestral")
            {
                Qtde_OS = 3;
                Prox_Prev = 120;
            } else if (combo_seleciona_os.Text == "Semestral")
            {
                Qtde_OS = 2;
                Prox_Prev = 180;
            } else if (combo_seleciona_os.Text == "Anual")
            {
                Qtde_OS = 1;
                Prox_Prev = 365;
            }

            Qtde_OS = Qtde_OS * Qtde_Anos;

            // Criar uma forma de abrir somente a qtd de meses estipulado pelo usuario

            //daqui pra frente é só salvar tudo no bando somando a data com a variavel prox_prev
            //Abrir e deixar campo OS em brando status Programada
            // Criar uma forma de visualar o que esta pendente, e da opção de exluir
            // Criar forma de ver o que esta aberto e falta finalizar;

        }

        #endregion

        #region Carregar controles
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
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_executante";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    combo_executante01.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante02.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante03.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante04.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante05.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante06.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante07.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante08.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante09.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante10.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante11.Items.Add(myreader["nome_executante"].ToString());
                    combo_executante12.Items.Add(myreader["nome_executante"].ToString());

                }
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        #endregion


        #region Botoes

        private void button_abrir_os_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(this, "Deseja Abrir OS Preventiva ?", "Ordem Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {

            }
            else if (resposta == DialogResult.No)
            {
                label_numero_os.Text = Convert.ToString(gerar_ordem_serv());
            }



            //MessageBox.Show(Convert.ToString(gerar_ordem_serv()));
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

        //private void button_cancelar_Click(object sender, EventArgs e) { }

        private void button_excluir_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void button_salvar_os_Click(object sender, EventArgs e)
        {
            Salvar_os();
        }
    }
}
