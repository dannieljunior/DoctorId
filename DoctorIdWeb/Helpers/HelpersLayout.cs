using System;
using System.Web.Mvc;

namespace DoctorIdWeb.Helpers
{
    /// <summary>
    /// continuando minha partial de helpers (...)
    /// </summary>
    public static class Helpers
    {
        public static string NomeDoUsuarioHelper(this HtmlHelper html, string pNome, string pUrl)
        {
            return $"<a href=\"{pUrl}\"><i class=\"user icon\"></i>{pNome}</a>";
        }
    }
}