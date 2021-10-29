
namespace GM4
{
    partial class Form_janela_baixa_peca
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroPeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_janela_baixa_peca = new System.Windows.Forms.TabControl();
            this.tab_baixa_pecas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rich_observacao = new System.Windows.Forms.RichTextBox();
            this.combo_ordem_serv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_unidade_medida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_qtd_usada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_tipo_movimento = new System.Windows.Forms.ComboBox();
            this.dt_baixa = new System.Windows.Forms.DateTimePicker();
            this.combo_material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_id_peca = new System.Windows.Forms.Label();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.tab_relatorio_peca = new System.Windows.Forms.TabPage();
            this.Grid_relatorio_baixa_peca = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_limpar_filtro = new System.Windows.Forms.Button();
            this.label_id_baixa_peca = new System.Windows.Forms.Label();
            this.combo_relatorio_ordem_serv = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_relatorio_tipo_mov = new System.Windows.Forms.ComboBox();
            this.combo_relatorio_ano = new System.Windows.Forms.ComboBox();
            this.combo_relatorio_mes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_relatorio_data = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tab_janela_baixa_peca.SuspendLayout();
            this.tab_baixa_pecas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_relatorio_peca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_baixa_peca)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroPeçasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroPeçasToolStripMenuItem
            // 
            this.cadastroPeçasToolStripMenuItem.Name = "cadastroPeçasToolStripMenuItem";
            this.cadastroPeçasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.cadastroPeçasToolStripMenuItem.Text = "Cadastro Peças";
            // 
            // tab_janela_baixa_peca
            // 
            this.tab_janela_baixa_peca.Controls.Add(this.tab_baixa_pecas);
            this.tab_janela_baixa_peca.Controls.Add(this.tab_relatorio_peca);
            this.tab_janela_baixa_peca.Location = new System.Drawing.Point(12, 27);
            this.tab_janela_baixa_peca.Name = "tab_janela_baixa_peca";
            this.tab_janela_baixa_peca.SelectedIndex = 0;
            this.tab_janela_baixa_peca.Size = new System.Drawing.Size(843, 497);
            this.tab_janela_baixa_peca.TabIndex = 1;
            // 
            // tab_baixa_pecas
            // 
            this.tab_baixa_pecas.Controls.Add(this.groupBox3);
            this.tab_baixa_pecas.Controls.Add(this.groupBox1);
            this.tab_baixa_pecas.Location = new System.Drawing.Point(4, 22);
            this.tab_baixa_pecas.Name = "tab_baixa_pecas";
            this.tab_baixa_pecas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_baixa_pecas.Size = new System.Drawing.Size(835, 471);
            this.tab_baixa_pecas.TabIndex = 0;
            this.tab_baixa_pecas.Text = "Movimentação de Material";
            this.tab_baixa_pecas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_empresa);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rich_observacao);
            this.groupBox3.Controls.Add(this.combo_ordem_serv);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.combo_unidade_medida);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.text_qtd_usada);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.combo_tipo_movimento);
            this.groupBox3.Controls.Add(this.dt_baixa);
            this.groupBox3.Controls.Add(this.combo_material);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 400);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimentação";
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(559, 35);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(140, 21);
            this.combo_empresa.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(487, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Observações\r\ngerais:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rich_observacao
            // 
            this.rich_observacao.Location = new System.Drawing.Point(149, 208);
            this.rich_observacao.Name = "rich_observacao";
            this.rich_observacao.Size = new System.Drawing.Size(650, 186);
            this.rich_observacao.TabIndex = 12;
            this.rich_observacao.Text = "";
            // 
            // combo_ordem_serv
            // 
            this.combo_ordem_serv.FormattingEnabled = true;
            this.combo_ordem_serv.Location = new System.Drawing.Point(151, 171);
            this.combo_ordem_serv.Name = "combo_ordem_serv";
            this.combo_ordem_serv.Size = new System.Drawing.Size(200, 21);
            this.combo_ordem_serv.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ordem Serviço:";
            // 
            // combo_unidade_medida
            // 
            this.combo_unidade_medida.FormattingEnabled = true;
            this.combo_unidade_medida.Location = new System.Drawing.Point(151, 141);
            this.combo_unidade_medida.Name = "combo_unidade_medida";
            this.combo_unidade_medida.Size = new System.Drawing.Size(200, 21);
            this.combo_unidade_medida.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd Usada:";
            // 
            // text_qtd_usada
            // 
            this.text_qtd_usada.Location = new System.Drawing.Point(151, 115);
            this.text_qtd_usada.Name = "text_qtd_usada";
            this.text_qtd_usada.Size = new System.Drawing.Size(100, 20);
            this.text_qtd_usada.TabIndex = 6;
            this.text_qtd_usada.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Movimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de baixa:";
            // 
            // combo_tipo_movimento
            // 
            this.combo_tipo_movimento.FormattingEnabled = true;
            this.combo_tipo_movimento.Location = new System.Drawing.Point(151, 88);
            this.combo_tipo_movimento.Name = "combo_tipo_movimento";
            this.combo_tipo_movimento.Size = new System.Drawing.Size(200, 21);
            this.combo_tipo_movimento.TabIndex = 3;
            this.combo_tipo_movimento.Text = "Saida";
            // 
            // dt_baixa
            // 
            this.dt_baixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_baixa.Location = new System.Drawing.Point(151, 62);
            this.dt_baixa.Name = "dt_baixa";
            this.dt_baixa.Size = new System.Drawing.Size(100, 20);
            this.dt_baixa.TabIndex = 2;
            // 
            // combo_material
            // 
            this.combo_material.FormattingEnabled = true;
            this.combo_material.Location = new System.Drawing.Point(151, 35);
            this.combo_material.Name = "combo_material";
            this.combo_material.Size = new System.Drawing.Size(330, 21);
            this.combo_material.TabIndex = 1;
            this.combo_material.SelectedIndexChanged += new System.EventHandler(this.combo_material_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.label_id_peca);
            this.groupBox1.Controls.Add(this.button_excluir);
            this.groupBox1.Controls.Add(this.button_atualizar);
            this.groupBox1.Controls.Add(this.button_confirmar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
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
            // label_id_peca
            // 
            this.label_id_peca.AutoSize = true;
            this.label_id_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_peca.Location = new System.Drawing.Point(364, 26);
            this.label_id_peca.Name = "label_id_peca";
            this.label_id_peca.Size = new System.Drawing.Size(16, 17);
            this.label_id_peca.TabIndex = 3;
            this.label_id_peca.Text = "0";
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
            // button_confirmar
            // 
            this.button_confirmar.Location = new System.Drawing.Point(12, 19);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(75, 30);
            this.button_confirmar.TabIndex = 0;
            this.button_confirmar.Text = "Confirmar";
            this.button_confirmar.UseVisualStyleBackColor = true;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // tab_relatorio_peca
            // 
            this.tab_relatorio_peca.Controls.Add(this.Grid_relatorio_baixa_peca);
            this.tab_relatorio_peca.Controls.Add(this.groupBox2);
            this.tab_relatorio_peca.Location = new System.Drawing.Point(4, 22);
            this.tab_relatorio_peca.Name = "tab_relatorio_peca";
            this.tab_relatorio_peca.Padding = new System.Windows.Forms.Padding(3);
            this.tab_relatorio_peca.Size = new System.Drawing.Size(835, 471);
            this.tab_relatorio_peca.TabIndex = 1;
            this.tab_relatorio_peca.Text = "Relatorio Peças";
            this.tab_relatorio_peca.UseVisualStyleBackColor = true;
            // 
            // Grid_relatorio_baixa_peca
            // 
            this.Grid_relatorio_baixa_peca.AllowUserToAddRows = false;
            this.Grid_relatorio_baixa_peca.AllowUserToDeleteRows = false;
            this.Grid_relatorio_baixa_peca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_relatorio_baixa_peca.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_relatorio_baixa_peca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_relatorio_baixa_peca.Location = new System.Drawing.Point(6, 99);
            this.Grid_relatorio_baixa_peca.Name = "Grid_relatorio_baixa_peca";
            this.Grid_relatorio_baixa_peca.ReadOnly = true;
            this.Grid_relatorio_baixa_peca.Size = new System.Drawing.Size(823, 366);
            this.Grid_relatorio_baixa_peca.TabIndex = 4;
            this.Grid_relatorio_baixa_peca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_relatorio_baixa_peca_CellClick);
            this.Grid_relatorio_baixa_peca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_relatorio_baixa_peca_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_limpar_filtro);
            this.groupBox2.Controls.Add(this.label_id_baixa_peca);
            this.groupBox2.Controls.Add(this.combo_relatorio_ordem_serv);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.combo_relatorio_tipo_mov);
            this.groupBox2.Controls.Add(this.combo_relatorio_ano);
            this.groupBox2.Controls.Add(this.combo_relatorio_mes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dt_relatorio_data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button_limpar_filtro
            // 
            this.button_limpar_filtro.Location = new System.Drawing.Point(704, 57);
            this.button_limpar_filtro.Name = "button_limpar_filtro";
            this.button_limpar_filtro.Size = new System.Drawing.Size(75, 23);
            this.button_limpar_filtro.TabIndex = 16;
            this.button_limpar_filtro.Text = "Limpar Filtro";
            this.button_limpar_filtro.UseVisualStyleBackColor = true;
            this.button_limpar_filtro.Click += new System.EventHandler(this.button_limpar_filtro_Click);
            // 
            // label_id_baixa_peca
            // 
            this.label_id_baixa_peca.AutoSize = true;
            this.label_id_baixa_peca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_baixa_peca.Location = new System.Drawing.Point(701, 20);
            this.label_id_baixa_peca.Name = "label_id_baixa_peca";
            this.label_id_baixa_peca.Size = new System.Drawing.Size(16, 17);
            this.label_id_baixa_peca.TabIndex = 15;
            this.label_id_baixa_peca.Text = "0";
            // 
            // combo_relatorio_ordem_serv
            // 
            this.combo_relatorio_ordem_serv.FormattingEnabled = true;
            this.combo_relatorio_ordem_serv.Location = new System.Drawing.Point(544, 56);
            this.combo_relatorio_ordem_serv.Name = "combo_relatorio_ordem_serv";
            this.combo_relatorio_ordem_serv.Size = new System.Drawing.Size(101, 21);
            this.combo_relatorio_ordem_serv.TabIndex = 14;
            this.combo_relatorio_ordem_serv.SelectedIndexChanged += new System.EventHandler(this.combo_relatorio_ordem_serv_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ordem Serviço:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tipo de Movimento:";
            // 
            // combo_relatorio_tipo_mov
            // 
            this.combo_relatorio_tipo_mov.FormattingEnabled = true;
            this.combo_relatorio_tipo_mov.Location = new System.Drawing.Point(152, 55);
            this.combo_relatorio_tipo_mov.Name = "combo_relatorio_tipo_mov";
            this.combo_relatorio_tipo_mov.Size = new System.Drawing.Size(267, 21);
            this.combo_relatorio_tipo_mov.TabIndex = 11;
            this.combo_relatorio_tipo_mov.Text = "Saida";
            // 
            // combo_relatorio_ano
            // 
            this.combo_relatorio_ano.FormattingEnabled = true;
            this.combo_relatorio_ano.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_relatorio_ano.Location = new System.Drawing.Point(546, 16);
            this.combo_relatorio_ano.Name = "combo_relatorio_ano";
            this.combo_relatorio_ano.Size = new System.Drawing.Size(99, 21);
            this.combo_relatorio_ano.TabIndex = 10;
            this.combo_relatorio_ano.SelectedIndexChanged += new System.EventHandler(this.combo_relatorio_ano_SelectedIndexChanged);
            // 
            // combo_relatorio_mes
            // 
            this.combo_relatorio_mes.FormattingEnabled = true;
            this.combo_relatorio_mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_relatorio_mes.Location = new System.Drawing.Point(320, 16);
            this.combo_relatorio_mes.Name = "combo_relatorio_mes";
            this.combo_relatorio_mes.Size = new System.Drawing.Size(99, 21);
            this.combo_relatorio_mes.TabIndex = 9;
            this.combo_relatorio_mes.SelectedIndexChanged += new System.EventHandler(this.combo_relatorio_mes_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ano Baixa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mês Baixa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data de baixa:";
            // 
            // dt_relatorio_data
            // 
            this.dt_relatorio_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_relatorio_data.Location = new System.Drawing.Point(121, 16);
            this.dt_relatorio_data.Name = "dt_relatorio_data";
            this.dt_relatorio_data.Size = new System.Drawing.Size(99, 20);
            this.dt_relatorio_data.TabIndex = 5;
            this.dt_relatorio_data.ValueChanged += new System.EventHandler(this.dt_relatorio_data_ValueChanged);
            // 
            // Form_janela_baixa_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 536);
            this.Controls.Add(this.tab_janela_baixa_peca);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_janela_baixa_peca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_janela_baixa_peca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_janela_baixa_peca.ResumeLayout(false);
            this.tab_baixa_pecas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_relatorio_peca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_relatorio_baixa_peca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroPeçasToolStripMenuItem;
        private System.Windows.Forms.TabControl tab_janela_baixa_peca;
        private System.Windows.Forms.TabPage tab_baixa_pecas;
        private System.Windows.Forms.TabPage tab_relatorio_peca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_id_peca;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_relatorio_baixa_peca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_unidade_medida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_qtd_usada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_tipo_movimento;
        private System.Windows.Forms.DateTimePicker dt_baixa;
        private System.Windows.Forms.ComboBox combo_material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rich_observacao;
        private System.Windows.Forms.ComboBox combo_ordem_serv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_relatorio_tipo_mov;
        private System.Windows.Forms.ComboBox combo_relatorio_ano;
        private System.Windows.Forms.ComboBox combo_relatorio_mes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_relatorio_data;
        private System.Windows.Forms.ComboBox combo_relatorio_ordem_serv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_id_baixa_peca;
        private System.Windows.Forms.Button button_limpar_filtro;
    }
}