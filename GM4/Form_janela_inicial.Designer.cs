
namespace GM4
{
    partial class Form_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel_esquerda = new System.Windows.Forms.Panel();
            this.button_configuração = new System.Windows.Forms.Button();
            this.button_cad_pecas = new System.Windows.Forms.Button();
            this.button_serv_terceiros = new System.Windows.Forms.Button();
            this.button_colaboradores = new System.Windows.Forms.Button();
            this.button_prestadores = new System.Windows.Forms.Button();
            this.button_cad_equipamento = new System.Windows.Forms.Button();
            this.button_cad_ativ_preventiva = new System.Windows.Forms.Button();
            this.button_cad_componentes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ordem_serv = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_conexao_db = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatus_versao = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_titulo_janela = new System.Windows.Forms.Label();
            this.panel_esquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_central.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel_esquerda
            // 
            this.panel_esquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_esquerda.Controls.Add(this.button_configuração);
            this.panel_esquerda.Controls.Add(this.button_cad_pecas);
            this.panel_esquerda.Controls.Add(this.button_serv_terceiros);
            this.panel_esquerda.Controls.Add(this.button_colaboradores);
            this.panel_esquerda.Controls.Add(this.button_prestadores);
            this.panel_esquerda.Controls.Add(this.button_cad_equipamento);
            this.panel_esquerda.Controls.Add(this.button_cad_ativ_preventiva);
            this.panel_esquerda.Controls.Add(this.button_cad_componentes);
            this.panel_esquerda.Controls.Add(this.pictureBox1);
            this.panel_esquerda.Controls.Add(this.button_ordem_serv);
            this.panel_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_esquerda.Location = new System.Drawing.Point(0, 24);
            this.panel_esquerda.Name = "panel_esquerda";
            this.panel_esquerda.Size = new System.Drawing.Size(190, 750);
            this.panel_esquerda.TabIndex = 1;
            // 
            // button_configuração
            // 
            this.button_configuração.Location = new System.Drawing.Point(4, 475);
            this.button_configuração.Name = "button_configuração";
            this.button_configuração.Size = new System.Drawing.Size(179, 33);
            this.button_configuração.TabIndex = 10;
            this.button_configuração.Text = "Configuração";
            this.button_configuração.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_configuração.UseVisualStyleBackColor = true;
            this.button_configuração.Click += new System.EventHandler(this.button_configuração_Click);
            // 
            // button_cad_pecas
            // 
            this.button_cad_pecas.Location = new System.Drawing.Point(4, 436);
            this.button_cad_pecas.Name = "button_cad_pecas";
            this.button_cad_pecas.Size = new System.Drawing.Size(179, 33);
            this.button_cad_pecas.TabIndex = 9;
            this.button_cad_pecas.Text = "Cadastro Peças";
            this.button_cad_pecas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_pecas.UseVisualStyleBackColor = true;
            this.button_cad_pecas.Click += new System.EventHandler(this.button_cad_pecas_Click);
            // 
            // button_serv_terceiros
            // 
            this.button_serv_terceiros.Location = new System.Drawing.Point(3, 397);
            this.button_serv_terceiros.Name = "button_serv_terceiros";
            this.button_serv_terceiros.Size = new System.Drawing.Size(179, 33);
            this.button_serv_terceiros.TabIndex = 8;
            this.button_serv_terceiros.Text = "Serviço Terceiros";
            this.button_serv_terceiros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_serv_terceiros.UseVisualStyleBackColor = true;
            this.button_serv_terceiros.Click += new System.EventHandler(this.button_serv_terceiros_Click);
            // 
            // button_colaboradores
            // 
            this.button_colaboradores.Location = new System.Drawing.Point(3, 358);
            this.button_colaboradores.Name = "button_colaboradores";
            this.button_colaboradores.Size = new System.Drawing.Size(179, 33);
            this.button_colaboradores.TabIndex = 7;
            this.button_colaboradores.Text = "Cadastro Executantes";
            this.button_colaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_colaboradores.UseVisualStyleBackColor = true;
            this.button_colaboradores.Click += new System.EventHandler(this.button_colaboradores_Click);
            // 
            // button_prestadores
            // 
            this.button_prestadores.Location = new System.Drawing.Point(4, 319);
            this.button_prestadores.Name = "button_prestadores";
            this.button_prestadores.Size = new System.Drawing.Size(179, 33);
            this.button_prestadores.TabIndex = 6;
            this.button_prestadores.Text = "Cadastro Prestadores";
            this.button_prestadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_prestadores.UseVisualStyleBackColor = true;
            this.button_prestadores.Click += new System.EventHandler(this.button_prestadores_Click);
            // 
            // button_cad_equipamento
            // 
            this.button_cad_equipamento.Location = new System.Drawing.Point(4, 280);
            this.button_cad_equipamento.Name = "button_cad_equipamento";
            this.button_cad_equipamento.Size = new System.Drawing.Size(179, 33);
            this.button_cad_equipamento.TabIndex = 5;
            this.button_cad_equipamento.Text = "Cadastro Equipamentos";
            this.button_cad_equipamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_equipamento.UseVisualStyleBackColor = true;
            this.button_cad_equipamento.Click += new System.EventHandler(this.button_cad_equipamento_Click);
            // 
            // button_cad_ativ_preventiva
            // 
            this.button_cad_ativ_preventiva.Location = new System.Drawing.Point(3, 241);
            this.button_cad_ativ_preventiva.Name = "button_cad_ativ_preventiva";
            this.button_cad_ativ_preventiva.Size = new System.Drawing.Size(179, 33);
            this.button_cad_ativ_preventiva.TabIndex = 4;
            this.button_cad_ativ_preventiva.Text = "Cadastro Atividade Preventivas";
            this.button_cad_ativ_preventiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_ativ_preventiva.UseVisualStyleBackColor = true;
            this.button_cad_ativ_preventiva.Click += new System.EventHandler(this.button_cad_ativ_preventiva_Click);
            // 
            // button_cad_componentes
            // 
            this.button_cad_componentes.Location = new System.Drawing.Point(3, 202);
            this.button_cad_componentes.Name = "button_cad_componentes";
            this.button_cad_componentes.Size = new System.Drawing.Size(179, 33);
            this.button_cad_componentes.TabIndex = 3;
            this.button_cad_componentes.Text = "Cadastro Componentes";
            this.button_cad_componentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cad_componentes.UseVisualStyleBackColor = true;
            this.button_cad_componentes.Click += new System.EventHandler(this.button_cad_componentes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_ordem_serv
            // 
            this.button_ordem_serv.Location = new System.Drawing.Point(3, 163);
            this.button_ordem_serv.Name = "button_ordem_serv";
            this.button_ordem_serv.Size = new System.Drawing.Size(179, 33);
            this.button_ordem_serv.TabIndex = 1;
            this.button_ordem_serv.Text = "Abrir / Fechar OS";
            this.button_ordem_serv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ordem_serv.UseVisualStyleBackColor = true;
            this.button_ordem_serv.Click += new System.EventHandler(this.button_ordem_serv_Click);
            // 
            // panel_central
            // 
            this.panel_central.AutoSize = true;
            this.panel_central.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_central.Controls.Add(this.statusStrip1);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(190, 24);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1036, 750);
            this.panel_central.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_conexao_db,
            this.StripStatus_versao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel_conexao_db
            // 
            this.StatusLabel_conexao_db.Name = "StatusLabel_conexao_db";
            this.StatusLabel_conexao_db.Size = new System.Drawing.Size(16, 17);
            this.StatusLabel_conexao_db.Text = "...";
            // 
            // StripStatus_versao
            // 
            this.StripStatus_versao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StripStatus_versao.Name = "StripStatus_versao";
            this.StripStatus_versao.Size = new System.Drawing.Size(41, 17);
            this.StripStatus_versao.Text = "Versão";
            this.StripStatus_versao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_titulo_janela
            // 
            this.label_titulo_janela.AutoSize = true;
            this.label_titulo_janela.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo_janela.Location = new System.Drawing.Point(527, -1);
            this.label_titulo_janela.Name = "label_titulo_janela";
            this.label_titulo_janela.Size = new System.Drawing.Size(58, 22);
            this.label_titulo_janela.TabIndex = 4;
            this.label_titulo_janela.Text = "label1";
            // 
            // Form_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 774);
            this.Controls.Add(this.label_titulo_janela);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_esquerda);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de manutenção GM4";
            this.panel_esquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_esquerda;
        private System.Windows.Forms.Button button_ordem_serv;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cad_ativ_preventiva;
        private System.Windows.Forms.Button button_cad_componentes;
        private System.Windows.Forms.Button button_cad_equipamento;
        private System.Windows.Forms.Button button_prestadores;
        private System.Windows.Forms.Button button_colaboradores;
        private System.Windows.Forms.Button button_serv_terceiros;
        private System.Windows.Forms.Button button_cad_pecas;
        private System.Windows.Forms.Button button_configuração;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_conexao_db;
        private System.Windows.Forms.ToolStripStatusLabel StripStatus_versao;
        private System.Windows.Forms.Label label_titulo_janela;
    }
}

