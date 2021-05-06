using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
            carregar_ordens_progr();

            Bloc_controles();

            // Aba ordem pendente
            carregar_grid("Programada");
            Carregar_filtro_aba_pendente();

            
        }


        #region Metodos / Calculos / funções
        private void limpar_campos()
        {
            // combo_empresa.Text = false;
            label_status_ordem.Text = "---";
            label_numero_os.Text = "0";
            combo_equipamento.Text = string.Empty;
            combo_tipo_serv.Text = string.Empty;
            //dt_solicitacao.Text = false;

            check_sim.Checked = false;
            check_nao.Checked = false;

            text_hr_paradas.Text = "0";
            combo_periodicidade.Text = "0";
            combo_periodo_meses.Text = "0";
            combo_periodo_anos.Text = "0";

            richText_observacao.Text = "0";

            combo_componente01.Text = string.Empty;
            text_atividades01.Text = string.Empty;
            combo_executante01.Text = string.Empty;
            hr_inicio_ativ_01.Text = string.Empty;
            hr_final_ativ_01.Text = string.Empty;
            check_replicar01.Text = string.Empty;

            combo_componente02.Text = string.Empty;
            text_atividades02.Text = string.Empty;
            combo_executante02.Text = string.Empty;
            hr_inicio_ativ_02.Text = string.Empty;
            hr_final_ativ_02.Text = string.Empty;
            check_replicar02.Text = string.Empty;

            combo_componente03.Text = string.Empty;
            text_atividades03.Text = string.Empty;
            combo_executante03.Text = string.Empty;
            hr_inicio_ativ_03.Text = string.Empty;
            hr_final_ativ_03.Text = string.Empty;
            check_replicar03.Text = string.Empty;

            combo_componente04.Text = string.Empty;
            text_atividades04.Text = string.Empty;
            combo_executante04.Text = string.Empty;
            hr_inicio_ativ_04.Text = string.Empty;
            hr_final_ativ_04.Text = string.Empty;
            check_replicar04.Text = string.Empty;

            combo_componente05.Text = string.Empty;
            text_atividades05.Text = string.Empty;
            combo_executante05.Text = string.Empty;
            hr_inicio_ativ_05.Text = string.Empty;
            hr_final_ativ_05.Text = string.Empty;
            check_replicar05.Text = string.Empty;

            combo_componente06.Text = string.Empty;
            text_atividades06.Text = string.Empty;
            combo_executante06.Text = string.Empty;
            hr_inicio_ativ_06.Text = string.Empty;
            hr_final_ativ_06.Text = string.Empty;
            check_replicar06.Text = string.Empty;

            combo_componente07.Text = string.Empty;
            text_atividades07.Text = string.Empty;
            combo_executante07.Text = string.Empty;
            hr_inicio_ativ_07.Text = string.Empty;
            hr_final_ativ_07.Text = string.Empty;
            check_replicar07.Text = string.Empty;

            combo_componente08.Text = string.Empty;
            text_atividades08.Text = string.Empty;
            combo_executante08.Text = string.Empty;
            hr_inicio_ativ_08.Text = string.Empty;
            hr_final_ativ_08.Text = string.Empty;
            check_replicar08.Text = string.Empty;

            combo_componente09.Text = string.Empty;
            text_atividades09.Text = string.Empty;
            combo_executante09.Text = string.Empty;
            hr_inicio_ativ_09.Text = string.Empty;
            hr_final_ativ_09.Text = string.Empty;
            check_replicar09.Text = string.Empty;

            combo_componente10.Text = string.Empty;
            text_atividades10.Text = string.Empty;
            combo_executante10.Text = string.Empty;
            hr_inicio_ativ_10.Text = string.Empty;
            hr_final_ativ_10.Text = string.Empty;
            check_replicar10.Text = string.Empty;

            combo_componente11.Text = string.Empty;
            text_atividades11.Text = string.Empty;
            combo_executante11.Text = string.Empty;
            hr_inicio_ativ_11.Text = string.Empty;
            hr_final_ativ_11.Text = string.Empty;
            check_replicar11.Text = string.Empty;

            combo_componente12.Text = string.Empty;
            text_atividades12.Text = string.Empty;
            combo_executante12.Text = string.Empty;
            hr_inicio_ativ_12.Text = string.Empty;
            hr_final_ativ_12.Text = string.Empty;
            check_replicar12.Text = string.Empty;

        }
        private void verifica_campos(int comando = 1)
        {
            // 1 - salvar
            // 2 - salvar preventiva
            // 3 - fechar

            if (comando == 1)
            {
                if (combo_equipamento.Text == string.Empty)
                {
                    MessageBox.Show("Preencher campo Equipamento");
                    combo_equipamento.Focus();
                    return;
                }

                if (combo_tipo_serv.Text == string.Empty)
                {
                    MessageBox.Show("Selecionar tipo do serviço");
                    combo_tipo_serv.Focus();
                    return;
                }

                if (combo_empresa.Text == string.Empty)
                {
                    MessageBox.Show("Preencher campo Empresa");
                    combo_empresa.Focus();
                    return;
                }

            }

            if (comando == 2)
            {
                if (combo_equipamento.Text == string.Empty)
                {
                    MessageBox.Show("Preencher campo Equipamento");
                    combo_equipamento.Focus();
                    return;
                }

                if (combo_tipo_serv.Text != "Preventiva")
                {
                    MessageBox.Show("Selecione o tipo de serviço corretamente!");
                    combo_tipo_serv.Focus();
                    return;
                }

                if (combo_empresa.Text == string.Empty)
                {
                    MessageBox.Show("Preencher campo Empresa");
                    combo_empresa.Focus();
                    return;
                }

                if(text_hr_paradas.Text == "0")
                {
                    DialogResult resposta = MessageBox.Show(this, "Maquina ficou parada ?", "Fechamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resposta == DialogResult.Yes)
                    {
                        MessageBox.Show("Informe o tempo de parada em minutos!");
                        text_hr_paradas.Focus();
                        check_sim.Enabled = true;
                        return;
                    }
                    else if (resposta == DialogResult.No)
                    {
                        check_nao.Enabled = true;
                        return;
                    }
                }

                if(combo_periodicidade.Text == string.Empty )
                {
                    MessageBox.Show("Obrigatorio preenchimento da metrica de preventiva");
                    combo_periodicidade.Focus();
                    return;
                }

                if(combo_periodo_meses.Text == "0" && combo_periodo_anos.Text == "0")
                {
                    MessageBox.Show("Informar o tempo da preventiva (Mês ou Ano)");
                    return;
                }
            }
            
            if(
            combo_componente01.Text == string.Empty &&
            text_atividades01.Text == string.Empty &&
            combo_executante01.Text == string.Empty &&
            hr_inicio_ativ_01.Text == string.Empty &&
            hr_final_ativ_01.Text == string.Empty &&
            check_replicar01.Text == string.Empty &&

            combo_componente02.Text == string.Empty &&
            text_atividades02.Text == string.Empty &&
            combo_executante02.Text == string.Empty &&
            hr_inicio_ativ_02.Text == string.Empty &&
            hr_final_ativ_02.Text == string.Empty &&
            check_replicar02.Text == string.Empty &&

            combo_componente03.Text == string.Empty &&
            text_atividades03.Text == string.Empty &&
            combo_executante03.Text == string.Empty &&
            hr_inicio_ativ_03.Text == string.Empty &&
            hr_final_ativ_03.Text == string.Empty &&
            check_replicar03.Text == string.Empty &&

            combo_componente04.Text == string.Empty &&
            text_atividades04.Text == string.Empty &&
            combo_executante04.Text == string.Empty &&
            hr_inicio_ativ_04.Text == string.Empty &&
            hr_final_ativ_04.Text == string.Empty &&
            check_replicar04.Text == string.Empty &&

            combo_componente05.Text == string.Empty &&
            text_atividades05.Text == string.Empty &&
            combo_executante05.Text == string.Empty &&
            hr_inicio_ativ_05.Text == string.Empty &&
            hr_final_ativ_05.Text == string.Empty &&
            check_replicar05.Text == string.Empty &&

            combo_componente06.Text == string.Empty &&
            text_atividades06.Text == string.Empty &&
            combo_executante06.Text == string.Empty &&
            hr_inicio_ativ_06.Text == string.Empty &&
            hr_final_ativ_06.Text == string.Empty &&
            check_replicar06.Text == string.Empty &&

            combo_componente07.Text == string.Empty &&
            text_atividades07.Text == string.Empty &&
            combo_executante07.Text == string.Empty &&
            hr_inicio_ativ_07.Text == string.Empty &&
            hr_final_ativ_07.Text == string.Empty &&
            check_replicar07.Text == string.Empty &&

            combo_componente08.Text == string.Empty &&
            text_atividades08.Text == string.Empty &&
            combo_executante08.Text == string.Empty &&
            hr_inicio_ativ_08.Text == string.Empty &&
            hr_final_ativ_08.Text == string.Empty &&
            check_replicar08.Text == string.Empty &&

            combo_componente09.Text == string.Empty &&
            text_atividades09.Text == string.Empty &&
            combo_executante09.Text == string.Empty &&
            hr_inicio_ativ_09.Text == string.Empty &&
            hr_final_ativ_09.Text == string.Empty &&
            check_replicar09.Text == string.Empty &&

            combo_componente10.Text == string.Empty &&
            text_atividades10.Text == string.Empty &&
            combo_executante10.Text == string.Empty &&
            hr_inicio_ativ_10.Text == string.Empty &&
            hr_final_ativ_10.Text == string.Empty &&
            check_replicar10.Text == string.Empty &&

            combo_componente11.Text == string.Empty &&
            text_atividades11.Text == string.Empty &&
            combo_executante11.Text == string.Empty &&
            hr_inicio_ativ_11.Text == string.Empty &&
            hr_final_ativ_11.Text == string.Empty &&
            check_replicar11.Text == string.Empty &&

            combo_componente12.Text == string.Empty &&
            text_atividades12.Text == string.Empty &&
            combo_executante12.Text == string.Empty &&
            hr_inicio_ativ_12.Text == string.Empty &&
            hr_final_ativ_12.Text == string.Empty &&
            check_replicar12.Text == string.Empty)
            {
                MessageBox.Show("Informar pelo menos uma atividade antes de salvar!");
            }


        }
        private void Carregar_filtro_aba_pendente()
        {
            try
            {

                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_status_os";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    aba_os_pend_combo_status.Items.Add(myreader["nome_status"].ToString());
                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void Carregar_ordem(string ordem)
        {
            try
            {
                //string status = "Preventiva";
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_ordem_servi where num_os = " + Convert.ToDouble(ordem) + "";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    label_status_ordem.Text = myreader["status"].ToString();
                    if(label_status_ordem.Text == "Encerrada")
                    {
                        label_status_ordem.BackColor = Color.Green;
                    }
                    if (label_status_ordem.Text != "Encerrada")
                    {
                        label_status_ordem.BackColor = Color.Orange;
                    }


                    combo_empresa.Text = myreader["empresa"].ToString();
                    label_numero_os.Text = myreader["num_os"].ToString();
                    combo_equipamento.Text = myreader["equipamento"].ToString();
                    combo_tipo_serv.Text = myreader["tipo_servico"].ToString();
                    dt_solicitacao.Value = Convert.ToDateTime(myreader["data_solicitacao"]);

                    if (myreader["tipo_servico"].ToString() == "Sim")
                    {
                        check_sim.Enabled = true;
                        check_nao.Enabled = false;
                    }
                    if (myreader["tipo_servico"].ToString() == "Não")
                    {
                        check_sim.Enabled = false;
                        check_nao.Enabled = true;            
                    }

                    richText_observacao.Text = myreader["obs"].ToString();

                    text_hr_paradas.Text = myreader["horas_parada"].ToString();
                    combo_periodicidade.Text = myreader["periodicidade"].ToString();
                    combo_periodo_meses.Text = myreader["periodo_meses"].ToString();
                    combo_periodo_anos.Text = myreader["periodo_anos"].ToString();

                    if(myreader["marcador_campo"].ToString() == combo_componente01.Name)
                    {
                        combo_componente01.Text = myreader["componente"].ToString();
                        text_atividades01.Text = myreader["atividade"].ToString(); 
                        combo_executante01.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_01.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_01.Text = myreader["hora_inicio"].ToString();
                    }

                    
                    if (myreader["marcador_campo"].ToString() == combo_componente02.Name)
                    {
                        combo_componente02.Text = myreader["componente"].ToString();
                        text_atividades02.Text = myreader["atividade"].ToString();
                        combo_executante02.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_02.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_02.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente03.Name)
                    {
                        combo_componente03.Text = myreader["componente"].ToString();
                        text_atividades03.Text = myreader["atividade"].ToString();
                        combo_executante03.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_03.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_03.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente04.Name)
                    {
                        combo_componente04.Text = myreader["componente"].ToString();
                        text_atividades04.Text = myreader["atividade"].ToString();
                        combo_executante04.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_04.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_04.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente05.Name)
                    {
                        combo_componente05.Text = myreader["componente"].ToString();
                        text_atividades05.Text = myreader["atividade"].ToString();
                        combo_executante05.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_05.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_05.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente06.Name)
                    {
                        combo_componente06.Text = myreader["componente"].ToString();
                        text_atividades06.Text = myreader["atividade"].ToString();
                        combo_executante06.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_06.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_06.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente07.Name)
                    {
                        combo_componente07.Text = myreader["componente"].ToString();
                        text_atividades07.Text = myreader["atividade"].ToString();
                        combo_executante07.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_07.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_07.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente08.Name)
                    {
                        combo_componente08.Text = myreader["componente"].ToString();
                        text_atividades08.Text = myreader["atividade"].ToString();
                        combo_executante08.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_08.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_08.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente09.Name)
                    {
                        combo_componente09.Text = myreader["componente"].ToString();
                        text_atividades09.Text = myreader["atividade"].ToString();
                        combo_executante09.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_09.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_09.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente10.Name)
                    {
                        combo_componente10.Text = myreader["componente"].ToString();
                        text_atividades10.Text = myreader["atividade"].ToString();
                        combo_executante10.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_10.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_10.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente11.Name)
                    {
                        combo_componente11.Text = myreader["componente"].ToString();
                        text_atividades11.Text = myreader["atividade"].ToString();
                        combo_executante11.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_11.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_11.Text = myreader["hora_inicio"].ToString();
                    }

                    if (myreader["marcador_campo"].ToString() == combo_componente12.Name)
                    {
                        combo_componente12.Text = myreader["componente"].ToString();
                        text_atividades12.Text = myreader["atividade"].ToString();
                        combo_executante12.Text = myreader["executante"].ToString();
                        hr_inicio_ativ_12.Text = myreader["hora_inicio"].ToString();
                        hr_final_ativ_12.Text = myreader["hora_inicio"].ToString();
                    } 

                }

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void Bloc_controles()
        {
            combo_empresa.Enabled = false;
            //label_numero_os.Text
            combo_equipamento.Enabled = false;
            combo_tipo_serv.Enabled = false;
            dt_solicitacao.Enabled = false;

            check_sim.Enabled = false;
            check_nao.Enabled = false;

            text_hr_paradas.Enabled = false;
            combo_periodicidade.Enabled = false;
            combo_periodo_meses.Enabled = false;
            combo_periodo_anos.Enabled = false;

            richText_observacao.Enabled = false;

            combo_componente01.Enabled = false;
            text_atividades01.Enabled = false;
            combo_executante01.Enabled = false;
            hr_inicio_ativ_01.Enabled = false;
            hr_final_ativ_01.Enabled = false;
            check_replicar01.Enabled = false;

            combo_componente02.Enabled = false;
            text_atividades02.Enabled = false;
            combo_executante02.Enabled = false;
            hr_inicio_ativ_02.Enabled = false;
            hr_final_ativ_02.Enabled = false;
            check_replicar02.Enabled = false;

            combo_componente03.Enabled = false;
            text_atividades03.Enabled = false;
            combo_executante03.Enabled = false;
            hr_inicio_ativ_03.Enabled = false;
            hr_final_ativ_03.Enabled = false;
            check_replicar03.Enabled = false;

            combo_componente04.Enabled = false;
            text_atividades04.Enabled = false;
            combo_executante04.Enabled = false;
            hr_inicio_ativ_04.Enabled = false;
            hr_final_ativ_04.Enabled = false;
            check_replicar04.Enabled = false;

            combo_componente05.Enabled = false;
            text_atividades05.Enabled = false;
            combo_executante05.Enabled = false;
            hr_inicio_ativ_05.Enabled = false;
            hr_final_ativ_05.Enabled = false;
            check_replicar05.Enabled = false;

            combo_componente06.Enabled = false;
            text_atividades06.Enabled = false;
            combo_executante06.Enabled = false;
            hr_inicio_ativ_06.Enabled = false;
            hr_final_ativ_06.Enabled = false;
            check_replicar06.Enabled = false;

            combo_componente07.Enabled = false;
            text_atividades07.Enabled = false;
            combo_executante07.Enabled = false;
            hr_inicio_ativ_07.Enabled = false;
            hr_final_ativ_07.Enabled = false;
            check_replicar07.Enabled = false;

            combo_componente08.Enabled = false;
            text_atividades08.Enabled = false;
            combo_executante08.Enabled = false;
            hr_inicio_ativ_08.Enabled = false;
            hr_final_ativ_08.Enabled = false;
            check_replicar08.Enabled = false;

            combo_componente09.Enabled = false;
            text_atividades09.Enabled = false;
            combo_executante09.Enabled = false;
            hr_inicio_ativ_09.Enabled = false;
            hr_final_ativ_09.Enabled = false;
            check_replicar09.Enabled = false;

            combo_componente10.Enabled = false;
            text_atividades10.Enabled = false;
            combo_executante10.Enabled = false;
            hr_inicio_ativ_10.Enabled = false;
            hr_final_ativ_10.Enabled = false;
            check_replicar10.Enabled = false;

            combo_componente11.Enabled = false;
            text_atividades11.Enabled = false;
            combo_executante11.Enabled = false;
            hr_inicio_ativ_11.Enabled = false;
            hr_final_ativ_11.Enabled = false;
            check_replicar11.Enabled = false;

            combo_componente12.Enabled = false;
            text_atividades12.Enabled = false;
            combo_executante12.Enabled = false;
            hr_inicio_ativ_12.Enabled = false;
            hr_final_ativ_12.Enabled = false;
            check_replicar12.Enabled = false;

        }
        private void Desbloc_controles()
        {
            combo_empresa.Enabled = true;
            //label_numero_os.Text
            combo_equipamento.Enabled = true;
            combo_tipo_serv.Enabled = true;
            dt_solicitacao.Enabled = true;

            check_sim.Enabled = true;
            check_nao.Enabled = true;

            text_hr_paradas.Enabled = true;
            combo_periodicidade.Enabled = true;
            combo_periodo_meses.Enabled = true;
            combo_periodo_anos.Enabled = true;

            richText_observacao.Enabled = true;

            combo_componente01.Enabled = true;
            text_atividades01.Enabled = true;
            combo_executante01.Enabled = true;
            hr_inicio_ativ_01.Enabled = true;
            hr_final_ativ_01.Enabled = true;
            check_replicar01.Enabled = true;

            combo_componente02.Enabled = true;
            text_atividades02.Enabled = true;
            combo_executante02.Enabled = true;
            hr_inicio_ativ_02.Enabled = true;
            hr_final_ativ_02.Enabled = true;
            check_replicar02.Enabled = true;

            combo_componente03.Enabled = true;
            text_atividades03.Enabled = true;
            combo_executante03.Enabled = true;
            hr_inicio_ativ_03.Enabled = true;
            hr_final_ativ_03.Enabled = true;
            check_replicar03.Enabled = true;

            combo_componente04.Enabled = true;
            text_atividades04.Enabled = true;
            combo_executante04.Enabled = true;
            hr_inicio_ativ_04.Enabled = true;
            hr_final_ativ_04.Enabled = true;
            check_replicar04.Enabled = true;

            combo_componente05.Enabled = true;
            text_atividades05.Enabled = true;
            combo_executante05.Enabled = true;
            hr_inicio_ativ_05.Enabled = true;
            hr_final_ativ_05.Enabled = true;
            check_replicar05.Enabled = true;

            combo_componente06.Enabled = true;
            text_atividades06.Enabled = true;
            combo_executante06.Enabled = true;
            hr_inicio_ativ_06.Enabled = true;
            hr_final_ativ_06.Enabled = true;
            check_replicar06.Enabled = true;

            combo_componente07.Enabled = true;
            text_atividades07.Enabled = true;
            combo_executante07.Enabled = true;
            hr_inicio_ativ_07.Enabled = true;
            hr_final_ativ_07.Enabled = true;
            check_replicar07.Enabled = true;

            combo_componente08.Enabled = true;
            text_atividades08.Enabled = true;
            combo_executante08.Enabled = true;
            hr_inicio_ativ_08.Enabled = true;
            hr_final_ativ_08.Enabled = true;
            check_replicar08.Enabled = true;

            combo_componente09.Enabled = true;
            text_atividades09.Enabled = true;
            combo_executante09.Enabled = true;
            hr_inicio_ativ_09.Enabled = true;
            hr_final_ativ_09.Enabled = true;
            check_replicar09.Enabled = true;

            combo_componente10.Enabled = true;
            text_atividades10.Enabled = true;
            combo_executante10.Enabled = true;
            hr_inicio_ativ_10.Enabled = true;
            hr_final_ativ_10.Enabled = true;
            check_replicar10.Enabled = true;

            combo_componente11.Enabled = true;
            text_atividades11.Enabled = true;
            combo_executante11.Enabled = true;
            hr_inicio_ativ_11.Enabled = true;
            hr_final_ativ_11.Enabled = true;
            check_replicar11.Enabled = true;

            combo_componente12.Enabled = true;
            text_atividades12.Enabled = true;
            combo_executante12.Enabled = true;
            hr_inicio_ativ_12.Enabled = true;
            hr_final_ativ_12.Enabled = true;
            check_replicar12.Enabled = true;

        }
        private string Buscar_status(string cod_status)
        {
            string resultado = "";
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select * from db_status_os where cod_status = '" + cod_status + "'";

                OleDbConnection conexao = new OleDbConnection(conecta_string);
                OleDbCommand cmd = new OleDbCommand(comando_sql, conexao);
                OleDbDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    resultado = myreader["nome_status"].ToString();
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            return resultado;
        }
        private TimeSpan Calculo_hora(DateTime hora_inicio, DateTime hora_fim)
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
        private double Gerar_ordem_serv()
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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente01.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente02.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente03.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente04.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente05.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente06.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente07.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente08.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente09.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente10.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente11.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Emitida";

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                        "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente12.Name + "')";

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
        private void Salvar_os_preventiva(DateTime data_solicitacao, double num_os)
        {
            string empresa = combo_empresa.Text;
            // double num_os = Gerar_ordem_serv();
            string equipamento = combo_equipamento.Text;
            string tipo_servico = combo_tipo_serv.Text;
            //DateTime data_solicitacao = dt_solicitacao;

            int dia_emissao = data_solicitacao.Day;
            int mes_emissao = data_solicitacao.Month;
            int ano_emissao = data_solicitacao.Year;

            string maquina_parada = "";
            int horas_parada = 0;

            string periodicidade = combo_periodicidade.Text;
            int periodo_meses = Convert.ToInt32(combo_periodo_meses.Text);
            int periodo_anos = Convert.ToInt32(combo_periodo_anos.Text);

            string componente;
            string atividade;
            string executante;
            DateTime hora_inicio = Convert.ToDateTime("00:00:00");
            DateTime hora_final = Convert.ToDateTime("00:00:00");
            TimeSpan total_horas = TimeSpan.Zero;
            string status = Buscar_status("02");
            string obs = richText_observacao.Text;

            if (combo_componente01.Text != string.Empty && text_atividades01.Text != string.Empty)
            {
                componente = combo_componente01.Text;
                atividade = text_atividades01.Text;
                executante = combo_executante01.Text;
                hora_inicio = hr_inicio_ativ_01.Value;
                hora_final = hr_final_ativ_01.Value;
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente01.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                 "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente02.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                 "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente03.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                                    "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente04.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente05.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente06.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                 "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente07.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                    "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente08.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente09.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente10.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                 "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente11.Name + "')";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = Buscar_status("02");

                try
                {
                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    string comando_sql;

                    comando_sql = "INSERT INTO db_ordem_servi(empresa, num_os, equipamento, tipo_servico, data_solicitacao, dia_emissao, mes_emissao, ano_emissao, maquina_parada, horas_parada, periodicidade, periodo_meses, periodo_anos, componente, atividade, executante, hora_inicio, hora_final, total_horas, status, obs, marcador_campo) " +
                 "VALUES('" + empresa + "','" + num_os + "','" + equipamento + "','" + tipo_servico + "','" + data_solicitacao + "','" + dia_emissao + "','" + mes_emissao + "','" + ano_emissao + "','" + maquina_parada + "','" + horas_parada + "','" + periodicidade + "','" + periodo_meses + "','" + periodo_anos + "','" + componente + "','" + atividade + "','" + executante + "','" + hora_inicio + "','" + hora_final + "','" + total_horas + "','" + status + "','" + obs + "','" + combo_componente12.Name + "')";

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
            DateTime data_solicitacao = dt_solicitacao.Value;
            // "Semanal"
            //"Quinzenal"
            //"Mensal"
            //"Bimestral"
            //"Trimestral"
            //"Quadrimestral"
            // "Semestral"
            //"Anual"
            if (combo_periodicidade.Text == "Semanal")
            {

                //Qtde_OS = 48;
                Qtde_OS = 4;
                Prox_Prev = 7;
            }
            else if (combo_periodicidade.Text == "Quinzenal")
            {
                //Qtde_OS = 24;
                Qtde_OS = 2;
                Prox_Prev = 15;
            }
            else if (combo_periodicidade.Text == "Mensal")
            {
                //Qtde_OS = 12;
                Qtde_OS = 1;
                Prox_Prev = 30;
            }
            else if (combo_periodicidade.Text == "Trimestral")
            {
                Qtde_OS = 4;
                Prox_Prev = 90;
            }
            else if (combo_periodicidade.Text == "Quadrimestral")
            {
                Qtde_OS = 3;
                Prox_Prev = 120;
            }
            else if (combo_periodicidade.Text == "Semestral")
            {
                Qtde_OS = 2;
                Prox_Prev = 180;
            }
            else if (combo_periodicidade.Text == "Anual")
            {
                Qtde_OS = 1;
                Prox_Prev = 365;
            }

            if (Qtde_Anos == 0)
            {
                Qtde_OS = Qtde_Meses * Qtde_OS;
            }
            else
            {
                Qtde_OS = Qtde_Meses * Qtde_OS * Qtde_Anos;
            }

            for (int i = 0; i < Qtde_OS; i++)
            {
                double num_os = Gerar_ordem_serv();
                Salvar_os_preventiva(data_solicitacao, num_os);
                data_solicitacao = data_solicitacao.AddDays(Prox_Prev);
            }

            // Criar uma forma de abrir somente a qtd de meses estipulado pelo usuario

            //daqui pra frente é só salvar tudo no bando somando a data com a variavel prox_prev
            //Abrir e deixar campo OS em brando status Programada
            // Criar uma forma de visualar o que esta pendente, e da opção de exluir
            // Criar forma de ver o que esta aberto e falta finalizar;

        }
        private void Fechar_os(string num_ordem)
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
            string obs = richText_observacao.Text;

            string status;
            if (combo_componente01.Text != string.Empty && text_atividades01.Text != string.Empty)
            {
                componente = combo_componente01.Text;
                atividade = text_atividades01.Text;
                executante = combo_executante01.Text;
                hora_inicio = hr_inicio_ativ_01.Value;
                hora_final = hr_final_ativ_01.Value;
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
        private void Atualizar_os(string num_ordem)
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
            string obs = richText_observacao.Text;

            string status;
            if (combo_componente01.Text != string.Empty && text_atividades01.Text != string.Empty)
            {
                componente = combo_componente01.Text;
                atividade = text_atividades01.Text;
                executante = combo_executante01.Text;
                hora_inicio = hr_inicio_ativ_01.Value;
                hora_final = hr_final_ativ_01.Value;
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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
                total_horas = Calculo_hora(hora_inicio, hora_final);
                status = "Encerrada";

                try
                {
                    string comando_sql;

                    string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                    OleDbConnection conexao = new OleDbConnection(conecta_string);
                    conexao.Open();

                    comando_sql = "UPDATE db_ordem_servi SET " +
                        "empresa='" + empresa +
                        "', num_os='" + num_os +
                        "', equipamento='" + equipamento +
                        "', tipo_servico='" + tipo_servico +
                        "', data_solicitacao='" + data_solicitacao +
                        "', dia_emissao='" + dia_emissao +
                        "', mes_emissao='" + mes_emissao +
                        "', ano_emissao='" + ano_emissao +
                        "', maquina_parada='" + maquina_parada +
                        "', horas_parada='" + horas_parada +
                        "', periodicidade='" + periodicidade +
                        "', periodo_meses='" + periodo_meses +
                        "', periodo_anos='" + periodo_anos +
                        "', componente='" + componente +
                        "', atividade='" + atividade +
                        "', executante='" + executante +
                        "', hora_inicio='" + hora_inicio +
                        "', hora_final='" + hora_final +
                        "', total_horas='" + total_horas +
                        "', status='" + status +
                        "', obs='" + obs +
                        "' WHERE num_os=" + Convert.ToDouble(num_ordem) + "";

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


        #endregion

        #region Carregar controles

        private void carregar_ordens_progr()
        {
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
                    combo_seleciona_os.Items.Add(myreader["num_os"].ToString());
                }
                conexao.Close();

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
            //desbloc_controles();
            label_numero_os.Text = Convert.ToString(Gerar_ordem_serv());
            Salvar_os();
            MessageBox.Show("Salvo com Sucesso");

        }

        private void button_fechar_os_Click(object sender, EventArgs e)
        {
            Fechar_os(label_numero_os.Text);
            MessageBox.Show("Ordem Encerrada com sucesso!");
            carregar_ordens_progr();
            limpar_campos();
        }

        private void button_encerrar_Click(object sender, EventArgs e) { }

        private void button_salvar_os_Click(object sender, EventArgs e)
        {
            // botão Atualizar
        }

        private void button_preventiva_Click(object sender, EventArgs e)
        {
            //desbloc_controles();
            if (combo_tipo_serv.Text != "Preventiva")
            {
                MessageBox.Show("Tipo de serviço deve ser preventiva");
            }
            else
            {
                Abrir_ordem_preventiva(combo_tipo_serv.Text, Convert.ToInt32(combo_periodo_meses.Text), Convert.ToInt32(combo_periodo_anos.Text));
                MessageBox.Show("Salvo com Sucesso");
            }

        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            string empresa = combo_empresa.Text;
            string num_os = label_numero_os.Text;
            string equipamento = combo_equipamento.Text;
            string tipo_servico = combo_tipo_serv.Text;
            DateTime data_solicitacao = dt_solicitacao.Value;

            string maquina_parada = " ";

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


            // adicionar o restante dos parametros
            Form_janela_imprimir_os imprimir_os = new Form_janela_imprimir_os(num_os, equipamento, tipo_servico);
            imprimir_os.Show();

        }

        //private void button_cancelar_Click(object sender, EventArgs e) { }

        private void button_excluir_Click(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private void combo_periodo_meses_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combo_periodicidade.Text == "Trimestral" && Convert.ToInt32(combo_periodo_meses.Text) < 3)
            {
                MessageBox.Show("Quantidade de Meses não pode ser menor que 3");
                //"Trimestral Quadrimestral Semestral Anual"
            }

            if (combo_periodicidade.Text == "Quadrimestral" && Convert.ToInt32(combo_periodo_meses.Text) < 4)
            {
                MessageBox.Show("Quantidade de Meses não pode ser menor que 3");
                //"Trimestral Quadrimestral Semestral Anual"
            }

            if (combo_periodicidade.Text == "Semestral" && Convert.ToInt32(combo_periodo_meses.Text) < 6)
            {
                MessageBox.Show("Quantidade de Meses não pode ser menor que 3");
                //"Trimestral Quadrimestral Semestral Anual"
            }
        }

        private void abrirOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar_campos();
            Desbloc_controles();
        }

        private void combo_seleciona_os_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpar_campos();
            Carregar_ordem(combo_seleciona_os.Text);
        }

        private void ordensAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desbloc_controles();
        }

        #region Aba Ordens Pendentes

        public void carregar_grid(string status)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.db_manutencaoConnectionString;
                string comando_sql = "select num_os, equipamento, tipo_servico, data_solicitacao, periodicidade, componente, atividade, status, obs from db_ordem_servi";

                OleDbConnection connection = new OleDbConnection(conecta_string);
                OleDbDataAdapter myadapter = new OleDbDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("db_ordem_servi");

                myadapter.Fill(dt);

                DataView dv = dt.DefaultView;

                dv.RowFilter = string.Format("status like '%{0}%'", status);
                Grid_ordem_serv.DataSource = dv.ToTable();

                connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void aba_os_pend_combo_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_grid(aba_os_pend_combo_status.Text);
        }


        private void Grid_ordem_serv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCliente = Grid_ordem_serv.CurrentRow.Cells[0].Value.ToString();
            tab_ordem_servi.SelectedTab = tab_abrir_fechar_os;
            Carregar_ordem(idCliente);
        }

        #endregion

        private void aba_ordenAberta_button_atualizar_Click(object sender, EventArgs e)
        {
            carregar_grid(aba_os_pend_combo_status.Text);
            MessageBox.Show("Atualizado com Sucesso");
        }

        private void baixarPeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_janela_baixa_peca mov_materail = new Form_janela_baixa_peca();
            mov_materail.Show();
        }
    }
}
