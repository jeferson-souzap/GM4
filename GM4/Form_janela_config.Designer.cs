﻿
namespace GM4
{
    partial class Form_janela_config
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
            this.text_endereco = new System.Windows.Forms.TextBox();
            this.button_buscar_local = new System.Windows.Forms.Button();
            this.button_salvar_endereco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // text_endereco
            // 
            this.text_endereco.Location = new System.Drawing.Point(9, 62);
            this.text_endereco.Name = "text_endereco";
            this.text_endereco.Size = new System.Drawing.Size(644, 20);
            this.text_endereco.TabIndex = 1;
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
            // Form_janela_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 157);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_janela_config";
            this.Text = "Configuração Geral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_buscar_local;
        private System.Windows.Forms.TextBox text_endereco;
        private System.Windows.Forms.Button button_salvar_endereco;
    }
}