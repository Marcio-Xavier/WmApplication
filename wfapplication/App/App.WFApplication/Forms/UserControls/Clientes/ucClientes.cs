using App.Service.Services.Clientes.IService;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WFApplication.Forms.UserControls.Clientes
{
    public partial class ucClientes : UserControl
    {
        public ucClientes(IClienteService clienteService)
        {
            InitializeComponent(clienteService);
            HideUserControls();
            ucCadastro.Visible = true;
            SetMenuAtivo(btnCadastro);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                SetMenuAtivo((Button)sender);
                ucCadastro.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                SetMenuAtivo((Button)sender);
                ucConsulta.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetMenuAtivo(Button button)
        {
            pnlSubMenuAtivo.Location = new Point(
                button.Location.X,
                pnlSubMenuAtivo.Location.Y
            );
        }

        private void HideUserControls()
        {
            ucCadastro.Visible =
            ucConsulta.Visible = false;
        }
    }
}