
namespace App.WFApplication
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pnlMenuAtivo = new System.Windows.Forms.Panel();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.btnItens = new System.Windows.Forms.Button();
            this.btnForncedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnParametrizacoes = new System.Windows.Forms.Button();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ucClientes = new App.WFApplication.Forms.UserControls.Clientes.ucClientes();
            this.ucFornecedores = new App.WFApplication.Forms.UserControls.Fornecedores.ucFornecedores();
            this.ucItens = new App.WFApplication.Forms.UserControls.Itens.ucItens();
            this.ucOperacoes = new App.WFApplication.Forms.UserControls.Operacoes.ucOperacoes();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.pnlMenu.Controls.Add(this.lblVersao);
            this.pnlMenu.Controls.Add(this.btnSobre);
            this.pnlMenu.Controls.Add(this.pnlMenuAtivo);
            this.pnlMenu.Controls.Add(this.btnOperacoes);
            this.pnlMenu.Controls.Add(this.btnItens);
            this.pnlMenu.Controls.Add(this.btnForncedores);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 776);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(126, 745);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(71, 15);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = "Versão 9.999";
            // 
            // btnSobre
            // 
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(12, 739);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(28, 25);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "?";
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // pnlMenuAtivo
            // 
            this.pnlMenuAtivo.BackColor = System.Drawing.Color.White;
            this.pnlMenuAtivo.Location = new System.Drawing.Point(0, 120);
            this.pnlMenuAtivo.Name = "pnlMenuAtivo";
            this.pnlMenuAtivo.Size = new System.Drawing.Size(9, 56);
            this.pnlMenuAtivo.TabIndex = 3;
            this.pnlMenuAtivo.Visible = false;
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacoes.FlatAppearance.BorderSize = 0;
            this.btnOperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacoes.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOperacoes.ForeColor = System.Drawing.Color.White;
            this.btnOperacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnOperacoes.Image")));
            this.btnOperacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacoes.Location = new System.Drawing.Point(12, 296);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(188, 56);
            this.btnOperacoes.TabIndex = 3;
            this.btnOperacoes.Text = "Compra/Venda";
            this.btnOperacoes.UseVisualStyleBackColor = true;
            this.btnOperacoes.Click += new System.EventHandler(this.btnOperacoes_Click);
            // 
            // btnItens
            // 
            this.btnItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItens.FlatAppearance.BorderSize = 0;
            this.btnItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItens.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItens.ForeColor = System.Drawing.Color.White;
            this.btnItens.Image = ((System.Drawing.Image)(resources.GetObject("btnItens.Image")));
            this.btnItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItens.Location = new System.Drawing.Point(12, 237);
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(188, 56);
            this.btnItens.TabIndex = 2;
            this.btnItens.Text = "Itens";
            this.btnItens.UseVisualStyleBackColor = true;
            this.btnItens.Click += new System.EventHandler(this.btnItens_Click);
            // 
            // btnForncedores
            // 
            this.btnForncedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForncedores.FlatAppearance.BorderSize = 0;
            this.btnForncedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForncedores.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForncedores.ForeColor = System.Drawing.Color.White;
            this.btnForncedores.Image = ((System.Drawing.Image)(resources.GetObject("btnForncedores.Image")));
            this.btnForncedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForncedores.Location = new System.Drawing.Point(12, 179);
            this.btnForncedores.Name = "btnForncedores";
            this.btnForncedores.Size = new System.Drawing.Size(188, 56);
            this.btnForncedores.TabIndex = 1;
            this.btnForncedores.Text = "Fornecedores";
            this.btnForncedores.UseVisualStyleBackColor = true;
            this.btnForncedores.Click += new System.EventHandler(this.btnForncedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 120);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(188, 56);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1256, 10);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(277, 10);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(114, 103);
            this.pnlLogo.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(7, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 89);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnInstagram
            // 
            this.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btnInstagram.Image")));
            this.btnInstagram.Location = new System.Drawing.Point(1282, 16);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(36, 35);
            this.btnInstagram.TabIndex = 3;
            this.btnInstagram.UseVisualStyleBackColor = true;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // btnParametrizacoes
            // 
            this.btnParametrizacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametrizacoes.FlatAppearance.BorderSize = 0;
            this.btnParametrizacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametrizacoes.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParametrizacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnParametrizacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnParametrizacoes.Image")));
            this.btnParametrizacoes.Location = new System.Drawing.Point(1366, 16);
            this.btnParametrizacoes.Name = "btnParametrizacoes";
            this.btnParametrizacoes.Size = new System.Drawing.Size(36, 35);
            this.btnParametrizacoes.TabIndex = 4;
            this.btnParametrizacoes.UseVisualStyleBackColor = true;
            this.btnParametrizacoes.Click += new System.EventHandler(this.btnParametrizacoes_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhatsapp.FlatAppearance.BorderSize = 0;
            this.btnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhatsapp.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWhatsapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnWhatsapp.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsapp.Image")));
            this.btnWhatsapp.Location = new System.Drawing.Point(1324, 16);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(36, 35);
            this.btnWhatsapp.TabIndex = 5;
            this.btnWhatsapp.UseVisualStyleBackColor = true;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1408, 16);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 35);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ucClientes
            // 
            this.ucClientes.Location = new System.Drawing.Point(200, 119);
            this.ucClientes.Name = "ucClientes";
            this.ucClientes.Size = new System.Drawing.Size(1256, 657);
            this.ucClientes.TabIndex = 7;
            this.ucClientes.Visible = false;
            // 
            // ucFornecedores
            // 
            this.ucFornecedores.Location = new System.Drawing.Point(200, 120);
            this.ucFornecedores.Name = "ucFornecedores";
            this.ucFornecedores.Size = new System.Drawing.Size(1256, 657);
            this.ucFornecedores.TabIndex = 8;
            this.ucFornecedores.Visible = false;
            // 
            // ucItens
            // 
            this.ucItens.Location = new System.Drawing.Point(200, 120);
            this.ucItens.Name = "ucItens";
            this.ucItens.Size = new System.Drawing.Size(1256, 657);
            this.ucItens.TabIndex = 9;
            this.ucItens.Visible = false;
            // 
            // ucOperacoes
            // 
            this.ucOperacoes.Location = new System.Drawing.Point(200, 120);
            this.ucOperacoes.Name = "ucOperacoes";
            this.ucOperacoes.Size = new System.Drawing.Size(1256, 657);
            this.ucOperacoes.TabIndex = 10;
            this.ucOperacoes.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 776);
            this.Controls.Add(this.ucOperacoes);
            this.Controls.Add(this.ucItens);
            this.Controls.Add(this.ucFornecedores);
            this.Controls.Add(this.ucClientes);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnWhatsapp);
            this.Controls.Add(this.btnParametrizacoes);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnForncedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlMenuAtivo;
        private System.Windows.Forms.Button btnOperacoes;
        private System.Windows.Forms.Button btnItens;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnParametrizacoes;
        private System.Windows.Forms.Button btnWhatsapp;
        private System.Windows.Forms.Button btnFechar;
        private Forms.UserControls.Clientes.ucClientes ucClientes;
        private Forms.UserControls.Fornecedores.ucFornecedores ucFornecedores;
        private Forms.UserControls.Itens.ucItens ucItens;
        private Forms.UserControls.Operacoes.ucOperacoes ucOperacoes;
    }
}

