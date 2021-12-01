
namespace GM4
{
    partial class CONFIG
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_status_con = new System.Windows.Forms.Label();
            this.button_salvar_endereco = new System.Windows.Forms.Button();
            this.button_buscar_local = new System.Windows.Forms.Button();
            this.text_endereco = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_ultimo_bk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_salvar_end_bk = new System.Windows.Forms.Button();
            this.button_busca_end_bk = new System.Windows.Forms.Button();
            this.text_endereco_backup_orig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_endereco_backup_dest = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço banco de dados Acess";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_status_con);
            this.groupBox1.Controls.Add(this.button_salvar_endereco);
            this.groupBox1.Controls.Add(this.button_buscar_local);
            this.groupBox1.Controls.Add(this.text_endereco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "--";
            // 
            // label_status_con
            // 
            this.label_status_con.AutoSize = true;
            this.label_status_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_con.Location = new System.Drawing.Point(361, 97);
            this.label_status_con.Name = "label_status_con";
            this.label_status_con.Size = new System.Drawing.Size(18, 17);
            this.label_status_con.TabIndex = 2;
            this.label_status_con.Text = "..";
            // 
            // button_salvar_endereco
            // 
            this.button_salvar_endereco.Location = new System.Drawing.Point(90, 97);
            this.button_salvar_endereco.Name = "button_salvar_endereco";
            this.button_salvar_endereco.Size = new System.Drawing.Size(75, 23);
            this.button_salvar_endereco.TabIndex = 3;
            this.button_salvar_endereco.Text = "Salvar local";
            this.button_salvar_endereco.UseVisualStyleBackColor = true;
            this.button_salvar_endereco.Click += new System.EventHandler(this.button_salvar_endereco_Click);
            // 
            // button_buscar_local
            // 
            this.button_buscar_local.Location = new System.Drawing.Point(9, 97);
            this.button_buscar_local.Name = "button_buscar_local";
            this.button_buscar_local.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_local.TabIndex = 2;
            this.button_buscar_local.Text = "Buscar";
            this.button_buscar_local.UseVisualStyleBackColor = true;
            this.button_buscar_local.Click += new System.EventHandler(this.button_buscar_local_Click);
            // 
            // text_endereco
            // 
            this.text_endereco.Location = new System.Drawing.Point(9, 62);
            this.text_endereco.Name = "text_endereco";
            this.text_endereco.Size = new System.Drawing.Size(644, 20);
            this.text_endereco.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_endereco_backup_dest);
            this.groupBox2.Controls.Add(this.label_ultimo_bk);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_salvar_end_bk);
            this.groupBox2.Controls.Add(this.button_busca_end_bk);
            this.groupBox2.Controls.Add(this.text_endereco_backup_orig);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "--";
            // 
            // label_ultimo_bk
            // 
            this.label_ultimo_bk.AutoSize = true;
            this.label_ultimo_bk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ultimo_bk.Location = new System.Drawing.Point(152, 140);
            this.label_ultimo_bk.Name = "label_ultimo_bk";
            this.label_ultimo_bk.Size = new System.Drawing.Size(90, 17);
            this.label_ultimo_bk.TabIndex = 5;
            this.label_ultimo_bk.Text = "01/10/2021";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ultimo Backup >>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "..";
            // 
            // button_salvar_end_bk
            // 
            this.button_salvar_end_bk.Location = new System.Drawing.Point(90, 114);
            this.button_salvar_end_bk.Name = "button_salvar_end_bk";
            this.button_salvar_end_bk.Size = new System.Drawing.Size(75, 23);
            this.button_salvar_end_bk.TabIndex = 3;
            this.button_salvar_end_bk.Text = "Salvar local";
            this.button_salvar_end_bk.UseVisualStyleBackColor = true;
            this.button_salvar_end_bk.Click += new System.EventHandler(this.button_salvar_end_bk_Click);
            // 
            // button_busca_end_bk
            // 
            this.button_busca_end_bk.Location = new System.Drawing.Point(9, 114);
            this.button_busca_end_bk.Name = "button_busca_end_bk";
            this.button_busca_end_bk.Size = new System.Drawing.Size(75, 23);
            this.button_busca_end_bk.TabIndex = 2;
            this.button_busca_end_bk.Text = "Buscar";
            this.button_busca_end_bk.UseVisualStyleBackColor = true;
            this.button_busca_end_bk.Click += new System.EventHandler(this.button_busca_end_bk_Click);
            // 
            // text_endereco_backup_orig
            // 
            this.text_endereco_backup_orig.Location = new System.Drawing.Point(9, 62);
            this.text_endereco_backup_orig.Name = "text_endereco_backup_orig";
            this.text_endereco_backup_orig.Size = new System.Drawing.Size(644, 20);
            this.text_endereco_backup_orig.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço Backup";
            // 
            // text_endereco_backup_dest
            // 
            this.text_endereco_backup_dest.Enabled = false;
            this.text_endereco_backup_dest.Location = new System.Drawing.Point(10, 88);
            this.text_endereco_backup_dest.Name = "text_endereco_backup_dest";
            this.text_endereco_backup_dest.Size = new System.Drawing.Size(644, 20);
            this.text_endereco_backup_dest.TabIndex = 6;
            // 
            // CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CONFIG";
            this.Text = "Configuração Geral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar_local;
        private System.Windows.Forms.TextBox text_endereco;
        private System.Windows.Forms.Button button_salvar_endereco;
        private System.Windows.Forms.Label label_status_con;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_salvar_end_bk;
        private System.Windows.Forms.Button button_busca_end_bk;
        private System.Windows.Forms.TextBox text_endereco_backup_orig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ultimo_bk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_endereco_backup_dest;
    }
}