
namespace GM4
{
    partial class Form_janela_cad_prestadores
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
            this.button_sair = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_id_prestadores = new System.Windows.Forms.Label();
            this.text_telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_cad_prestadores = new System.Windows.Forms.DataGridView();
            this.text_empresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_prestadores)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(800, 65);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_cargo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.text_email);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.text_nome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_id_prestadores);
            this.groupBox2.Controls.Add(this.text_telefone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Grid_cad_prestadores);
            this.groupBox2.Controls.Add(this.text_empresa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 385);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
            // 
            // label_id_prestadores
            // 
            this.label_id_prestadores.AutoSize = true;
            this.label_id_prestadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_prestadores.Location = new System.Drawing.Point(765, 16);
            this.label_id_prestadores.Name = "label_id_prestadores";
            this.label_id_prestadores.Size = new System.Drawing.Size(23, 17);
            this.label_id_prestadores.TabIndex = 5;
            this.label_id_prestadores.Text = "---";
            // 
            // text_telefone
            // 
            this.text_telefone.Location = new System.Drawing.Point(15, 78);
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(201, 20);
            this.text_telefone.TabIndex = 4;
            this.text_telefone.Leave += new System.EventHandler(this.text_telefone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // Grid_cad_prestadores
            // 
            this.Grid_cad_prestadores.AllowUserToAddRows = false;
            this.Grid_cad_prestadores.AllowUserToDeleteRows = false;
            this.Grid_cad_prestadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_cad_prestadores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_cad_prestadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_cad_prestadores.Location = new System.Drawing.Point(6, 104);
            this.Grid_cad_prestadores.Name = "Grid_cad_prestadores";
            this.Grid_cad_prestadores.ReadOnly = true;
            this.Grid_cad_prestadores.Size = new System.Drawing.Size(782, 269);
            this.Grid_cad_prestadores.TabIndex = 2;
            this.Grid_cad_prestadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_cad_prestadores_CellClick);
            // 
            // text_empresa
            // 
            this.text_empresa.Location = new System.Drawing.Point(15, 35);
            this.text_empresa.Name = "text_empresa";
            this.text_empresa.Size = new System.Drawing.Size(201, 20);
            this.text_empresa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(226, 35);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(201, 20);
            this.text_nome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(226, 78);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(416, 20);
            this.text_email.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-Mail";
            // 
            // text_cargo
            // 
            this.text_cargo.Location = new System.Drawing.Point(441, 35);
            this.text_cargo.Name = "text_cargo";
            this.text_cargo.Size = new System.Drawing.Size(201, 20);
            this.text_cargo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cargo";
            // 
            // Form_janela_cad_prestadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_cad_prestadores";
            this.Text = "Form_janela_cad_prestadores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_cad_prestadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_id_prestadores;
        private System.Windows.Forms.TextBox text_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_cad_prestadores;
        private System.Windows.Forms.TextBox text_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_cargo;
        private System.Windows.Forms.Label label5;
    }
}