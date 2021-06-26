using App.Domain.Enums;
using App.Domain.Models.Clientes;
using App.Service.Services.Clientes.IService;
using App.Utils.Helpers;
using System;
using System.Windows.Forms;

namespace App.WFApplication.Forms.UserControls.Clientes
{
    public partial class ucCadastro : UserControl
    {
        private IClienteService _clienteService;

        public ucCadastro(IClienteService clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }

        #region Eventos
        private void ucCadastro_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        //private void btnAdicionarContato_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ValidarContato(txtDescricaoContato.Text);
        //        grvContatos.Rows.Add(cbxContatoTipo.DisplayMember, txtDescricaoContato.Text);
        //    }
        //    catch (FormatException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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
                    StatusRegistroId = (int)StatusRegistro.Ativo,
                    Cpf = txtCpf.Text.OnlyNumbers()
                };

                var clienteId = await _clienteService.Insert(cliente);

                MessageBox.Show($"Cliente {cliente.Nome} inserido com suecesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos
        private async void SetDefault()
        {
            LimparCampos();
        }

        //private void ValidarContato(string valor)
        //{
        //    if (valor.Trim() == string.Empty)
        //    {
        //        throw new ArgumentException("Campo 'Valor' deve estar preenchido");
        //    }
        //    switch (cbxContatoTipo.ValueMember.ToUInt32())
        //    {
        //        case (int)Domain.Enums.ContatoTipo.Celular:
        //            valor.ValidarTelefoneCelular();
        //            break;
        //        case (int)Domain.Enums.ContatoTipo.Email:
        //            valor.ValidarEmail();
        //            break;
        //        case (int)Domain.Enums.ContatoTipo.Instagram:
        //            valor.ValidarUsuarioInstagramTwitter();
        //            break;
        //        case (int)Domain.Enums.ContatoTipo.Twitter:
        //            valor.ValidarUsuarioInstagramTwitter();
        //            break;
        //        case (int)Domain.Enums.ContatoTipo.Telefone:
        //            valor.ValidarTelefoneCelular();
        //            break;
        //        case (int)Domain.Enums.ContatoTipo.Site:
        //            valor.ValidarUrl();
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void LimparCampos()
        {
            txtNome.Text =
            txtCpf.Text = string.Empty;
        }
        #endregion
    }
}