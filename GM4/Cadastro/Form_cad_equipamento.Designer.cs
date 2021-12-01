
namespace GM4
{
    partial class Form_cad_equipamento
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
            this.text_descri_equipamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_cad_equipamento = new System.Windows.Forms.DataGridView();
            this.text_equipamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label_id_equipamento = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_equipamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_id_equipamento);
            this.groupBox2.Controls.Add(this.text_descri_equipamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Grid_cad_equipamento);
            this.groupBox2.Controls.Add(this.text_equipamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 628);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // text_descri_equipamento
            // 
            this.text_descri_equipamento.Location = new System.Drawing.Point(15, 78);
            this.text_descri_equipamento.Name = "text_descri_equipamento";
            this.text_descri_equipamento.Size = new System.Drawing.Size(201, 20);
            this.text_descri_equipamento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição Equipamento";
            // 
            // Grid_cad_equipamento
            // 
            this.Grid_cad_equipamento.AllowUserToAddRows = false;
            this.Grid_cad_equipamento.AllowUserToDeleteRows = false;
            this.Grid_cad_equipamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_cad_equipamento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_cad_equipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_cad_equipamento.Location = new System.Drawing.Point(6, 104);
            this.Grid_cad_equipamento.Name = "Grid_cad_equipamento";
            this.Grid_cad_equipamento.ReadOnly = true;
            this.Grid_cad_equipamento.Size = new System.Drawing.Size(507, 512);
            this.Grid_cad_equipamento.TabIndex = 2;
            this.Grid_cad_equipamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_cad_equipamento_CellClick);
            // 
            // text_equipamento
            // 
            this.text_equipamento.Location = new System.Drawing.Point(15, 35);
            this.text_equipamento.Name = "text_equipamento";
            this.text_equipamento.Size = new System.Drawing.Size(201, 20);
            this.text_equipamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.button_deletar);
            this.groupBox1.Controls.Add(this.button_atualizar);
            this.groupBox1.Controls.Add(this.button_salvar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 65);
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
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(174, 19);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 30);
            this.button_deletar.TabIndex = 2;
            this.button_deletar.Text = "Exluir";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
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
            // label_id_equipamento
            // 
            this.label_id_equipamento.AutoSize = true;
            this.label_id_equipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_equipamento.Location = new System.Drawing.Point(441, 16);
            this.label_id_equipamento.Name = "label_id_equipamento";
            this.label_id_equipamento.Size = new System.Drawing.Size(23, 17);
            this.label_id_equipamento.TabIndex = 5;
            this.label_id_equipamento.Text = "---";
            // 
            // Form_cad_equipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cad_equipamento";
            this.Text = "Form_cad_equipamento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_equipamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_cad_equipamento;
        private System.Windows.Forms.TextBox text_equipamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.TextBox text_descri_equipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_id_equipamento;
    }
}