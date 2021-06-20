using System;
using System.Windows.Forms;

namespace App.WFApplication.Forms.UserControls.Clientes
{
    public partial class ucConsulta : UserControl
    {
        public ucConsulta()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}