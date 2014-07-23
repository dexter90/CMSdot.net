using System;

namespace Definitions.SQL
{
    public class MenuSQL
    {
        /// <summary>
        /// select id, namePosition, link, childId, description, idLanguage from Portfolio.dbo.Menu
        /// </summary>
        /// <param name="idLanguage">Unikalny identyfikator języka</param>
        /// <returns>Sql</returns>
        public static string GetMenuByIdLanguage(int idLanguage)
        {
            return String.Format("select id, namePosition, link, childId, description, idLanguage from Portfolio.dbo.Categories c where c.idLanguage = {0}", idLanguage);
        }
    }
}
