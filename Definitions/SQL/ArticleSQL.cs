using System;

namespace Definitions.SQL
{
    public class ArticleSQL
    {
        /// <summary>
        /// select id, title, shortDescription, dateModify, content, user from Portfolio.dbo.Registers
        /// </summary>
        /// <param name="nameCategory">Nazwa kategorii</param>
        /// <returns>SQL</returns>
        public static string GetRegisterByName(string nameCategory)
        {
            return String.Format("select r.id, r.title, r.shortDescription, r.dateModify, r.content, r.[user], r.idTypeArticle from Portfolio.dbo.Articles r INNER JOIN Categories_Articles ca ON ca.idArticle = r.id INNER JOIN Categories c ON c.id = ca.idCategory where c.namePosition = '{0}'", nameCategory);
        }
    }
}
