using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM4
{
    public partial class Form_inicial : Form
    {
        public Form_inicial()
        {
            InitializeComponent();
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
    }
}
