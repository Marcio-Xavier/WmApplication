using App.Service.Services.Comprador.IService;
using App.Service.Services.Comprador.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
