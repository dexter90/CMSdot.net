using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Definitions.SQL
{
    public class LanguageSQL
    {
        /// <summary>
        /// Select id, language, image isActive from Portfolio.dbo.Language
        /// </summary>
        /// <returns>Sql</returns>
        public static string SelectAll()
        {
            return String.Format("select id, language, image, isActive from Portfolio.dbo.Language");
        }

        public static string GetLanguageById(int idLanguage)
        {
            return String.Format("select * from Portfolio.dbo.Language l where l.id = {0}", idLanguage);
        }

        public static string GetLanguageByLanguage(string language)
        {
            return String.Format("select * from Portfolio.dbo.Language l where l.language = {0}", language);
        }
    }
}
