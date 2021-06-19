using App.Repository.BaseContext.IRepository;
using App.Service.Services.Clientes.IService;
using App.Utils.Constants;
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

            SetInfoVersao();
            
            _clienteService = clienteService;
            _teste();
        }

        #region Eventos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Métodos
        private void SetInfoVersao()
        {
            lblVersao.Text = "Versão" + AppInfo.Versao;
        }
        #endregion


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