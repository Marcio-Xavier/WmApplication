using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace App.Utils.Helpers
{
    public static class Extensions
    {
        /// <summary>
        /// Mantém numa string somente números
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string OnlyNumbers(this string valor)
        {
            return Regex.Replace(valor, @"[^\d]", "");
        }

        /// <summary>
        /// Converte uma string em UInt32
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static uint ToUInt32(this string valor)
        {
            return UInt32.Parse(valor);
        }

        /// <summary>
        /// Valida se uma string está num formato de número de celular ou telefone válido
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static void ValidarTelefoneCelular(this string valor)
        {
            var formato = new Regex(@"^(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])(?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");

            if (!formato.IsMatch(valor.OnlyNumbers()))
            {
                throw new FormatException("Número de telefone/celular inválido");
            }
        }

        /// <summary>
        /// Valida se uma string está num formato de endereço de e-mail válido
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static void ValidarEmail(this string valor)
        {
            var email = new MailAddress(valor);

            if (email.Address != valor)
            {
                throw new FormatException("Endereço de e-mail inválido");
            }
        }

        /// <summary>
        /// Valida se uma string está num formato de usuário de Instagram/Twitter válido
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static void ValidarUsuarioInstagramTwitter(this string valor)
        {
            var formato = new Regex(@"^[a-zA-Z0-9_][a-zA-Z0-9_.]*");

            if (!formato.IsMatch(valor))
            {
                throw new FormatException("Usuário do Instagram/Twitter inválido");
            }
        }

        /// <summary>
        /// Valida se uma string está num formato de endereço eletrônico válido
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static void ValidarUrl(this string valor)
        {
            Uri uriResult;

            if (!(Uri.TryCreate(valor, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp))
            {
                throw new FormatException("Endereço eletrônico inválido");
            }
        }
    }
}