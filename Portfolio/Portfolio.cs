using System;
using System.Collections.Generic;
using Portfolio.Interfaces;
using ModelsWCF.Domain;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data.Sql;
using AccessWCF;
using Definitions.ConnectionStrings;
using Definitions.SQL;

namespace Portfolio
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Portfolio: IPortfolio
    {
        private SqlConnection DbConnection = null;

        IList<ModelsWCF.Domain.Menu> IPortfolio.GetMenu(int idLanguage)
        {
            SqlCommand cmd = null;
            SqlDataReader sdr = null;
            IList<Menu> menuList = new List<Menu>();
            try
            {
                DbConnection = new SqlConnection(ConnStrings.DevEnvironment());
                Database.Open(DbConnection);
                cmd = new SqlCommand(MenuSQL.GetMenuByIdLanguage(idLanguage), DbConnection);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                    menuList.Add(new Menu { id = sdr.GetInt32(0), namePosition = sdr.GetString(1), link = "", childId = 0, descirpion = "" });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Database.CommandClose(cmd);
                Database.DataReaderClose(sdr);
                Database.Close(DbConnection);
            }
            return menuList;
        }

        IList<Language> IPortfolio.GetLanguageList()
        {
            SqlCommand cmd = null;
            SqlDataReader sdr = null;
            IList<Language> Languages = null;
            try
            {
                DbConnection = new SqlConnection(ConnStrings.DevEnvironment());
                Database.Open(DbConnection);
                cmd = new SqlCommand(LanguageSQL.SelectAll(), DbConnection);
                sdr = cmd.ExecuteReader();
                Languages = new List<Language>();
                while (sdr.Read())
                    Languages.Add(new Language { id = sdr.GetInt32(0), language = sdr.GetString(1), image = sdr.GetString(2), isActive = sdr.GetInt32(3) });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Database.DataReaderClose(sdr);
                Database.CommandClose(cmd);
                Database.Close(DbConnection);
            }
            return Languages;
        }

        IList<Article> IPortfolio.GetArticlesByCategory(string nameCategory)
        {
            SqlCommand cmd = null;
            SqlDataReader sdr = null;
            IList<Article> articleList = new List<Article>();
            try
            {
                DbConnection = new SqlConnection(ConnStrings.DevEnvironment());
                Database.Open(DbConnection);
                cmd = new SqlCommand(ArticleSQL.GetRegisterByName(nameCategory), DbConnection);
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                    articleList.Add(new Article { id = sdr.GetInt32(0), title = sdr.GetString(1), shortDescription = sdr.GetString(2), dateModify = sdr.GetDateTime(3), content = sdr.GetString(4), user = sdr.GetString(5), idArticleType=sdr.GetInt32(6) });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Database.CommandClose(cmd);
                Database.DataReaderClose(sdr);
                Database.Close(DbConnection);
            }
            return articleList;
        }

        IList<Article> IPortfolio.GetArticlesByIdCategory(int idCategory)
        {
            return new List<Article>();
        }
    }
}
