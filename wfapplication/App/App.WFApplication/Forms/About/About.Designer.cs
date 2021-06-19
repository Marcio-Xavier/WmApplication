
namespace App.WFApplication.Forms.About
{
    public partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picLogoAbout = new System.Windows.Forms.PictureBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.lblNomeLoja = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.picLogoAbout, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblDescricao, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblVersao, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblDireitos, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblNomeLoja, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAnotacoes, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnFechar, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(733, 324);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // picLogoAbout
            // 
            this.picLogoAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogoAbout.Image = ((System.Drawing.Image)(resources.GetObject("picLogoAbout.Image")));
            this.picLogoAbout.Location = new System.Drawing.Point(4, 3);
            this.picLogoAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLogoAbout.Name = "picLogoAbout";
            this.tableLayoutPanel.SetRowSpan(this.picLogoAbout, 6);
            this.picLogoAbout.Size = new System.Drawing.Size(233, 296);
            this.picLogoAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoAbout.TabIndex = 12;
            this.picLogoAbout.TabStop = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricao.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(248, 0);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(481, 20);
            this.lblDescricao.TabIndex = 19;
            this.lblDescricao.Text = "Sistema de gerenciamento de compras e vendas da Wm Modas";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersao
            // 
            this.lblVersao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersao.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersao.Location = new System.Drawing.Point(248, 30);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.lblVersao.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(481, 20);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDireitos
            // 
            this.lblDireitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDireitos.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireitos.Location = new System.Drawing.Point(248, 60);
            this.lblDireitos.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.lblDireitos.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(481, 20);
            this.lblDireitos.TabIndex = 21;
            this.lblDireitos.Text = "Todos direitos reservados";
            this.lblDireitos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeLoja
            // 
            this.lblNomeLoja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeLoja.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeLoja.Location = new System.Drawing.Point(248, 90);
            this.lblNomeLoja.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.lblNomeLoja.MaximumSize = new System.Drawing.Size(0, 20);
            this.lblNomeLoja.Name = "lblNomeLoja";
            this.lblNomeLoja.Size = new System.Drawing.Size(481, 20);
            this.lblNomeLoja.TabIndex = 22;
            this.lblNomeLoja.Text = "Wm Moda Masculina";
            this.lblNomeLoja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.BackColor = System.Drawing.Color.White;
            this.txtAnotacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnotacoes.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnotacoes.Location = new System.Drawing.Point(248, 123);
            this.txtAnotacoes.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.ReadOnly = true;
            this.txtAnotacoes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnotacoes.Size = new System.Drawing.Size(481, 146);
            this.txtAnotacoes.TabIndex = 23;
            this.txtAnotacoes.TabStop = false;
            this.txtAnotacoes.Text = "Anotações recomendadas";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Bahnschrift", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnFechar.Location = new System.Drawing.Point(635, 305);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(95, 16);
            this.btnFechar.TabIndex = 25;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 344);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox picLogoAbout;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblNomeLoja;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.Button btnFechar;
    }
}
