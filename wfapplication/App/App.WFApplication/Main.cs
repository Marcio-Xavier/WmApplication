using App.Service.Services.Clientes.IService;
using System;
using System.Windows.Forms;

namespace App.WFApplication
{
    public partial class Main : Form
    {
        private IClienteService _clienteService;

        public Main(IClienteService clienteService)
        {
            InitializeComponent();

            _clienteService = clienteService;
            _teste();
        }

        private async void _teste()
        {
            try
            {
                var teste = await _clienteService.Get();
            }
            catch (Exception)
            {
                Close();
            }
        }
    }
}