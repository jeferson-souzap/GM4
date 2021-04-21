
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ordem_serv = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_esquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_esquerda.Controls.Add(this.button2);
            this.panel_esquerda.Controls.Add(this.button1);
            this.panel_esquerda.Controls.Add(this.pictureBox1);
            this.panel_esquerda.Controls.Add(this.button_ordem_serv);
            this.panel_esquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_esquerda.Location = new System.Drawing.Point(0, 24);
            this.panel_esquerda.Name = "panel_esquerda";
            this.panel_esquerda.Size = new System.Drawing.Size(190, 691);
            this.panel_esquerda.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_ordem_serv
            // 
            this.button_ordem_serv.Location = new System.Drawing.Point(3, 137);
            this.button_ordem_serv.Name = "button_ordem_serv";
            this.button_ordem_serv.Size = new System.Drawing.Size(179, 33);
            this.button_ordem_serv.TabIndex = 1;
            this.button_ordem_serv.Text = "Abrir / Fechar OS";
            this.button_ordem_serv.UseVisualStyleBackColor = true;
            this.button_ordem_serv.Click += new System.EventHandler(this.button_ordem_serv_Click);
            // 
            // panel_central
            // 
            this.panel_central.AutoSize = true;
            this.panel_central.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(190, 24);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1036, 691);
            this.panel_central.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastro Itens";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cadastro Atividades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 715);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_esquerda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_esquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel_esquerda;
        private System.Windows.Forms.Button button_ordem_serv;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

