using App.Domain.Models.Clientes;
using App.Service.Services.Clientes.IService;
using App.Service.Services.Clientes.Service;
using App.Utils.Helpers;
using System;
using System.Windows.Forms;

namespace App.WFApplication.Forms.UserControls.Clientes
{
    public partial class ucCadastro : UserControl
    {
        private IClienteService _clienteService;

        public ucCadastro()
        {
            InitializeComponent();
        }

        #region Eventos
        private void ucCadastro_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text.OnlyNumbers()
                };

                var clienteId = await _clienteService.Insert(cliente);

                MessageBox.Show($"Cliente #{clienteId} inserido com suecesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos
        private void LimparCampos()
        {
            txtNome.Text =
            txtCpf.Text = string.Empty;
        }
        #endregion
    }
}