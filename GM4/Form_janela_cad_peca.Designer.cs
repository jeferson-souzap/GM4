
namespace GM4
{
    partial class Form_janela_cad_peca
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTex_observacao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_cad_pecas = new System.Windows.Forms.DataGridView();
            this.text_peca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_id_peca = new System.Windows.Forms.Label();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.db_categorias_componenteTableAdapter1 = new GM4.db_manutencaoDataSetTableAdapters.db_categorias_componenteTableAdapter();
            this.combo_local_aplicacao = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_pecas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_local_aplicacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTex_observacao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Grid_cad_pecas);
            this.groupBox2.Controls.Add(this.text_peca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 563);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Observação:";
            // 
            // richTex_observacao
            // 
            this.richTex_observacao.Location = new System.Drawing.Point(6, 96);
            this.richTex_observacao.Name = "richTex_observacao";
            this.richTex_observacao.Size = new System.Drawing.Size(433, 77);
            this.richTex_observacao.TabIndex = 6;
            this.richTex_observacao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local Aplicação:";
            // 
            // Grid_cad_pecas
            // 
            this.Grid_cad_pecas.AllowUserToAddRows = false;
            this.Grid_cad_pecas.AllowUserToDeleteRows = false;
            this.Grid_cad_pecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_cad_pecas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_cad_pecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_cad_pecas.Location = new System.Drawing.Point(6, 179);
            this.Grid_cad_pecas.Name = "Grid_cad_pecas";
            this.Grid_cad_pecas.ReadOnly = true;
            this.Grid_cad_pecas.Size = new System.Drawing.Size(661, 378);
            this.Grid_cad_pecas.TabIndex = 2;
            this.Grid_cad_pecas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_cad_pecas_CellClick);
            this.Grid_cad_pecas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_cad_pecas_CellDoubleClick);
            // 
            // text_peca
            // 
            this.text_peca.Location = new System.Drawing.Point(129, 19);
            this.text_peca.Name = "text_peca";
            this.text_peca.Size = new System.Drawing.Size(310, 20);
            this.text_peca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peça:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.label_id_peca);
            this.groupBox1.Controls.Add(this.button_excluir);
            this.groupBox1.Controls.Add(this.button_atualizar);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 65);
            this.groupBox1.TabIndex = 2;
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
            // db_categorias_componenteTableAdapter1
            // 
            this.db_categorias_componenteTableAdapter1.ClearBeforeFill = true;
            // 
            // combo_local_aplicacao
            // 
            this.combo_local_aplicacao.FormattingEnabled = true;
            this.combo_local_aplicacao.Location = new System.Drawing.Point(129, 46);
            this.combo_local_aplicacao.Name = "combo_local_aplicacao";
            this.combo_local_aplicacao.Size = new System.Drawing.Size(310, 21);
            this.combo_local_aplicacao.TabIndex = 8;
            // 
            // Form_janela_cad_peca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_cad_peca";
            this.Text = "Form_janela_cad_peca";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_pecas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_cad_pecas;
        private System.Windows.Forms.TextBox text_peca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private db_manutencaoDataSetTableAdapters.db_categorias_componenteTableAdapter db_categorias_componenteTableAdapter1;
        private System.Windows.Forms.Label label_id_peca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTex_observacao;
        private System.Windows.Forms.ComboBox combo_local_aplicacao;
    }
}