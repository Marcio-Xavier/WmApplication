namespace App.WFApplication.Forms.UserControls.Clientes
{
    partial class ucCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pnlSubMenuAtivo = new System.Windows.Forms.Panel();
            this.ucCadastro = new App.WFApplication.Forms.UserControls.Clientes.ucCadastro(_clienteService);
            this.ucConsulta = new App.WFApplication.Forms.UserControls.Clientes.ucConsulta(_clienteService);
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(3, 16);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(77, 29);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(83, 16);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(77, 29);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pnlSubMenuAtivo
            // 
            this.pnlSubMenuAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.pnlSubMenuAtivo.Location = new System.Drawing.Point(3, 0);
            this.pnlSubMenuAtivo.Name = "pnlSubMenuAtivo";
            this.pnlSubMenuAtivo.Size = new System.Drawing.Size(77, 10);
            this.pnlSubMenuAtivo.TabIndex = 3;
            // 
            // ucCadastro
            // 
            this.ucCadastro.Location = new System.Drawing.Point(0, 48);
            this.ucCadastro.Name = "ucCadastro";
            this.ucCadastro.Size = new System.Drawing.Size(1256, 609);
            this.ucCadastro.TabIndex = 4;
            // 
            // ucConsulta
            // 
            this.ucConsulta.Location = new System.Drawing.Point(0, 48);
            this.ucConsulta.Name = "ucConsulta";
            this.ucConsulta.Size = new System.Drawing.Size(1256, 609);
            this.ucConsulta.TabIndex = 5;
            this.ucConsulta.Visible = false;
            // 
            // ucCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pnlSubMenuAtivo);
            this.Name = "ucCliente";
            this.Size = new System.Drawing.Size(1256, 657);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubMenuAtivo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConsulta;
        private ucCadastro ucCadastro;
        private ucConsulta ucConsulta;
    }
}