
namespace GM4
{
    partial class Form_cad_componentes
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
            this.Grid_cad_componentes = new System.Windows.Forms.DataGridView();
            this.textBox_componente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label_id_componente = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_componentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_id_componente);
            this.groupBox2.Controls.Add(this.Grid_cad_componentes);
            this.groupBox2.Controls.Add(this.textBox_componente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 628);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // Grid_cad_componentes
            // 
            this.Grid_cad_componentes.AllowUserToAddRows = false;
            this.Grid_cad_componentes.AllowUserToDeleteRows = false;
            this.Grid_cad_componentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_cad_componentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_cad_componentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_cad_componentes.Location = new System.Drawing.Point(6, 50);
            this.Grid_cad_componentes.Name = "Grid_cad_componentes";
            this.Grid_cad_componentes.ReadOnly = true;
            this.Grid_cad_componentes.Size = new System.Drawing.Size(501, 566);
            this.Grid_cad_componentes.TabIndex = 2;
            this.Grid_cad_componentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_cad_componentes_CellClick);
            // 
            // textBox_componente
            // 
            this.textBox_componente.Location = new System.Drawing.Point(106, 15);
            this.textBox_componente.Name = "textBox_componente";
            this.textBox_componente.Size = new System.Drawing.Size(224, 20);
            this.textBox_componente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Componente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sair);
            this.groupBox1.Controls.Add(this.button_excluir);
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
            // label_id_componente
            // 
            this.label_id_componente.AutoSize = true;
            this.label_id_componente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_componente.Location = new System.Drawing.Point(350, 16);
            this.label_id_componente.Name = "label_id_componente";
            this.label_id_componente.Size = new System.Drawing.Size(18, 17);
            this.label_id_componente.TabIndex = 3;
            this.label_id_componente.Text = "--";
            // 
            // Form_cad_componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cad_componentes";
            this.Text = "Form_cad_componentes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_componentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_cad_componentes;
        private System.Windows.Forms.TextBox textBox_componente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Label label_id_componente;
    }
}