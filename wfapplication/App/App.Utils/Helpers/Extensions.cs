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
    }
}