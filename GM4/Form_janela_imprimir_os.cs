using System;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_janela_imprimir_os : Form
    {
        public Form_janela_imprimir_os(string num_os, string equipamento, string tipo_servico, string data_solicitacao)
        {
            
            InitializeComponent();
            // carregar_relatorio(num_os, equipamento, tipo_servico, data_solicitacao);//, data_solicitacao, tipo_servico);
                                
        }

        private void Form_janela_imprimir_os_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void carregar_relatorio(string num_os, string equipamento, string tipo_servico, string data_solicitacao)
        {
            // sem uso


            //this.reportViewer1.RefreshReport();
            //try
            //{
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.ReportEmbeddedResource = "GM4.Report_OS.rdlc";
            //    Microsoft.Reporting.WinForms.ReportParameter[] p = new
            //    Microsoft.Reporting.WinForms.ReportParameter[3];
                
            //    p[0] = new Microsoft.Reporting.WinForms.ReportParameter("num_ordem_servi", num_os);
            //    p[1] = new Microsoft.Reporting.WinForms.ReportParameter("equipamento", equipamento);
            //    p[2] = new Microsoft.Reporting.WinForms.ReportParameter("data_lancamento]", data_solicitacao);


            //    reportViewer1.LocalReport.SetParameters(p);
            //    reportViewer1.LocalReport.Refresh();
            //}

            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
        }
    }
}















