
namespace GM4
{
    partial class Form_janela_serv_terceiros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_id_serv_prestado = new System.Windows.Forms.Label();
            this.combo_identificacao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_nome = new System.Windows.Forms.ComboBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_telefone = new System.Windows.Forms.TextBox();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richText_serv_prestado = new System.Windows.Forms.RichTextBox();
            this.text_identifica = new System.Windows.Forms.TextBox();
            this.text_custo = new System.Windows.Forms.TextBox();
            this.dt_final = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_servico_terceiros = new System.Windows.Forms.TabControl();
            this.tab_serv_terceiro = new System.Windows.Forms.TabPage();
            this.tab_relatorio = new System.Windows.Forms.TabPage();
            this.Grid_relatorio_serv_terceiro = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_id_serv_terceiros = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_limpar_filtro_relatorio = new System.Windows.Forms.Button();
            this.combo_relatorio_nome = new System.Windows.Forms.ComboBox();
            this.combo_relatorio_empresa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_final_relatorio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_servico_terceiros.SuspendLayout();
            this.tab_serv_terceiro.SuspendLayout();
            this.tab_relatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_serv_terceiro)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_id_serv_prestado);
            this.groupBox1.Controls.Add(this.combo_identificacao);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.button_excluir);
            this.groupBox1.Controls.Add(this.button_atualizar);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label_id_serv_prestado
            // 
            this.label_id_serv_prestado.AutoSize = true;
            this.label_id_serv_prestado.Location = new System.Drawing.Point(351, 28);
            this.label_id_serv_prestado.Name = "label_id_serv_prestado";
            this.label_id_serv_prestado.Size = new System.Drawing.Size(13, 13);
            this.label_id_serv_prestado.TabIndex = 7;
            this.label_id_serv_prestado.Text = "0";
            // 
            // combo_identificacao
            // 
            this.combo_identificacao.FormattingEnabled = true;
            this.combo_identificacao.Location = new System.Drawing.Point(560, 25);
            this.combo_identificacao.Name = "combo_identificacao";
            this.combo_identificacao.Size = new System.Drawing.Size(181, 21);
            this.combo_identificacao.TabIndex = 6;
            this.combo_identificacao.SelectedIndexChanged += new System.EventHandler(this.combo_identificacao_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Identificação";
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(255, 19);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 30);
            this.button_sair.TabIndex = 3;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(174, 19);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 30);
            this.button_excluir.TabIndex = 2;
            this.button_excluir.Text = "Exluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(93, 19);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 30);
            this.button_atualizar.TabIndex = 1;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(12, 19);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 30);
            this.button_salvar.TabIndex = 0;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_nome);
            this.groupBox2.Controls.Add(this.text_email);
            this.groupBox2.Controls.Add(this.text_telefone);
            this.groupBox2.Controls.Add(this.combo_empresa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // combo_nome
            // 
            this.combo_nome.FormattingEnabled = true;
            this.combo_nome.Location = new System.Drawing.Point(322, 12);
            this.combo_nome.Name = "combo_nome";
            this.combo_nome.Size = new System.Drawing.Size(166, 21);
            this.combo_nome.TabIndex = 8;
            this.combo_nome.SelectedIndexChanged += new System.EventHandler(this.combo_nome_SelectedIndexChanged);
            // 
            // text_email
            // 
            this.text_email.Enabled = false;
            this.text_email.Location = new System.Drawing.Point(60, 42);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(428, 20);
            this.text_email.TabIndex = 7;
            // 
            // text_telefone
            // 
            this.text_telefone.Enabled = false;
            this.text_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_telefone.Location = new System.Drawing.Point(548, 13);
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(190, 20);
            this.text_telefone.TabIndex = 6;
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(60, 13);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(181, 21);
            this.combo_empresa.TabIndex = 4;
            this.combo_empresa.SelectedIndexChanged += new System.EventHandler(this.combo_empresa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Exe.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richText_serv_prestado);
            this.groupBox3.Controls.Add(this.text_identifica);
            this.groupBox3.Controls.Add(this.text_custo);
            this.groupBox3.Controls.Add(this.dt_final);
            this.groupBox3.Controls.Add(this.dt_inicio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 293);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhe do trabalho";
            // 
            // richText_serv_prestado
            // 
            this.richText_serv_prestado.Location = new System.Drawing.Point(22, 95);
            this.richText_serv_prestado.Name = "richText_serv_prestado";
            this.richText_serv_prestado.Size = new System.Drawing.Size(716, 192);
            this.richText_serv_prestado.TabIndex = 11;
            this.richText_serv_prestado.Text = "";
            // 
            // text_identifica
            // 
            this.text_identifica.Location = new System.Drawing.Point(588, 29);
            this.text_identifica.Name = "text_identifica";
            this.text_identifica.Size = new System.Drawing.Size(150, 20);
            this.text_identifica.TabIndex = 10;
            // 
            // text_custo
            // 
            this.text_custo.Location = new System.Drawing.Point(396, 28);
            this.text_custo.Name = "text_custo";
            this.text_custo.Size = new System.Drawing.Size(112, 20);
            this.text_custo.TabIndex = 9;
            this.text_custo.Text = "0";
            // 
            // dt_final
            // 
            this.dt_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_final.Location = new System.Drawing.Point(228, 28);
            this.dt_final.Name = "dt_final";
            this.dt_final.Size = new System.Drawing.Size(88, 20);
            this.dt_final.TabIndex = 8;
            // 
            // dt_inicio
            // 
            this.dt_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_inicio.Location = new System.Drawing.Point(66, 29);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(88, 20);
            this.dt_inicio.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Serviço Prestado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Identificação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Custo R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dt. Termino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dt. Inicio";
            // 
            // tab_servico_terceiros
            // 
            this.tab_servico_terceiros.Controls.Add(this.tab_serv_terceiro);
            this.tab_servico_terceiros.Controls.Add(this.tab_relatorio);
            this.tab_servico_terceiros.Location = new System.Drawing.Point(7, 5);
            this.tab_servico_terceiros.Name = "tab_servico_terceiros";
            this.tab_servico_terceiros.SelectedIndex = 0;
            this.tab_servico_terceiros.Size = new System.Drawing.Size(802, 485);
            this.tab_servico_terceiros.TabIndex = 6;
            this.tab_servico_terceiros.SelectedIndexChanged += new System.EventHandler(this.tab_servico_terceiros_SelectedIndexChanged);
            // 
            // tab_serv_terceiro
            // 
            this.tab_serv_terceiro.Controls.Add(this.groupBox3);
            this.tab_serv_terceiro.Controls.Add(this.groupBox1);
            this.tab_serv_terceiro.Controls.Add(this.groupBox2);
            this.tab_serv_terceiro.Location = new System.Drawing.Point(4, 22);
            this.tab_serv_terceiro.Name = "tab_serv_terceiro";
            this.tab_serv_terceiro.Padding = new System.Windows.Forms.Padding(3);
            this.tab_serv_terceiro.Size = new System.Drawing.Size(794, 459);
            this.tab_serv_terceiro.TabIndex = 0;
            this.tab_serv_terceiro.Text = "Serviço Terceiros";
            this.tab_serv_terceiro.UseVisualStyleBackColor = true;
            // 
            // tab_relatorio
            // 
            this.tab_relatorio.Controls.Add(this.Grid_relatorio_serv_terceiro);
            this.tab_relatorio.Controls.Add(this.groupBox4);
            this.tab_relatorio.Location = new System.Drawing.Point(4, 22);
            this.tab_relatorio.Name = "tab_relatorio";
            this.tab_relatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tab_relatorio.Size = new System.Drawing.Size(794, 459);
            this.tab_relatorio.TabIndex = 1;
            this.tab_relatorio.Text = "Relatorio";
            this.tab_relatorio.UseVisualStyleBackColor = true;
            // 
            // Grid_relatorio_serv_terceiro
            // 
            this.Grid_relatorio_serv_terceiro.AllowUserToAddRows = false;
            this.Grid_relatorio_serv_terceiro.AllowUserToDeleteRows = false;
            this.Grid_relatorio_serv_terceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_relatorio_serv_terceiro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_relatorio_serv_terceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_relatorio_serv_terceiro.Location = new System.Drawing.Point(6, 82);
            this.Grid_relatorio_serv_terceiro.Name = "Grid_relatorio_serv_terceiro";
            this.Grid_relatorio_serv_terceiro.ReadOnly = true;
            this.Grid_relatorio_serv_terceiro.Size = new System.Drawing.Size(782, 371);
            this.Grid_relatorio_serv_terceiro.TabIndex = 3;
            this.Grid_relatorio_serv_terceiro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_relatorio_serv_terceiro_CellClick);
            this.Grid_relatorio_serv_terceiro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_relatorio_serv_terceiro_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_id_serv_terceiros);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.button_limpar_filtro_relatorio);
            this.groupBox4.Controls.Add(this.combo_relatorio_nome);
            this.groupBox4.Controls.Add(this.combo_relatorio_empresa);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dt_final_relatorio);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(782, 70);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // label_id_serv_terceiros
            // 
            this.label_id_serv_terceiros.AutoSize = true;
            this.label_id_serv_terceiros.Location = new System.Drawing.Point(70, 46);
            this.label_id_serv_terceiros.Name = "label_id_serv_terceiros";
            this.label_id_serv_terceiros.Size = new System.Drawing.Size(13, 13);
            this.label_id_serv_terceiros.TabIndex = 13;
            this.label_id_serv_terceiros.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Dt. Final";
            // 
            // button_limpar_filtro_relatorio
            // 
            this.button_limpar_filtro_relatorio.Location = new System.Drawing.Point(673, 41);
            this.button_limpar_filtro_relatorio.Name = "button_limpar_filtro_relatorio";
            this.button_limpar_filtro_relatorio.Size = new System.Drawing.Size(103, 23);
            this.button_limpar_filtro_relatorio.TabIndex = 11;
            this.button_limpar_filtro_relatorio.Text = "Limpar Filtros";
            this.button_limpar_filtro_relatorio.UseVisualStyleBackColor = true;
            this.button_limpar_filtro_relatorio.Click += new System.EventHandler(this.button_limpar_filtro_relatorio_Click);
            // 
            // combo_relatorio_nome
            // 
            this.combo_relatorio_nome.FormattingEnabled = true;
            this.combo_relatorio_nome.Location = new System.Drawing.Point(312, 13);
            this.combo_relatorio_nome.Name = "combo_relatorio_nome";
            this.combo_relatorio_nome.Size = new System.Drawing.Size(170, 21);
            this.combo_relatorio_nome.TabIndex = 10;
            this.combo_relatorio_nome.SelectedIndexChanged += new System.EventHandler(this.combo_relatorio_nome_SelectedIndexChanged);
            // 
            // combo_relatorio_empresa
            // 
            this.combo_relatorio_empresa.FormattingEnabled = true;
            this.combo_relatorio_empresa.Location = new System.Drawing.Point(73, 13);
            this.combo_relatorio_empresa.Name = "combo_relatorio_empresa";
            this.combo_relatorio_empresa.Size = new System.Drawing.Size(168, 21);
            this.combo_relatorio_empresa.TabIndex = 9;
            this.combo_relatorio_empresa.SelectedIndexChanged += new System.EventHandler(this.combo_relatorio_empresa_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Empresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nome Exe.";
            // 
            // dt_final_relatorio
            // 
            this.dt_final_relatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_final_relatorio.Location = new System.Drawing.Point(540, 14);
            this.dt_final_relatorio.Name = "dt_final_relatorio";
            this.dt_final_relatorio.Size = new System.Drawing.Size(103, 20);
            this.dt_final_relatorio.TabIndex = 0;
            this.dt_final_relatorio.ValueChanged += new System.EventHandler(this.dt_final_relatorio_ValueChanged);
            // 
            // Form_janela_serv_terceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.tab_servico_terceiros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_serv_terceiros";
            this.Text = "Form_janela_serv_terceiros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_servico_terceiros.ResumeLayout(false);
            this.tab_serv_terceiro.ResumeLayout(false);
            this.tab_relatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_serv_terceiro)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_telefone;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.RichTextBox richText_serv_prestado;
        private System.Windows.Forms.TextBox text_identifica;
        private System.Windows.Forms.TextBox text_custo;
        private System.Windows.Forms.DateTimePicker dt_final;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.Label label_id_serv_prestado;
        private System.Windows.Forms.ComboBox combo_identificacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tab_servico_terceiros;
        private System.Windows.Forms.TabPage tab_serv_terceiro;
        private System.Windows.Forms.TabPage tab_relatorio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Grid_relatorio_serv_terceiro;
        private System.Windows.Forms.Button button_limpar_filtro_relatorio;
        private System.Windows.Forms.ComboBox combo_relatorio_nome;
        private System.Windows.Forms.ComboBox combo_relatorio_empresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_final_relatorio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_nome;
        private System.Windows.Forms.Label label_id_serv_terceiros;
    }
}