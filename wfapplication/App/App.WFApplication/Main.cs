using App.Service.Services.Comprador.IService;
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

        private void _teste()
        {
            try
            {
                var teste = _clienteService.Get();
            }
            catch (Exception)
            {
                Close();
            }
        }
    }
}