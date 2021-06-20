using App.Service.Services.Clientes.IService;
using System;
using System.Windows.Forms;

namespace App.WFApplication.Forms.UserControls.Clientes
{
    public partial class ucConsulta : UserControl
    {
        private IClienteService _clienteService;

        public ucConsulta(IClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var clientes = await _clienteService.Get();
                grvClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}