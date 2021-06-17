using App.Service.Services.Comprador.IService;
using System.Windows.Forms;

namespace App.WFApplication
{
    public partial class Main : Form
    {
        private IClienteService _clienteService;

        public Main(IClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();

            _teste();
        }

        private void _teste()
        {
            var teste = _clienteService.Get();
        }
    }
}