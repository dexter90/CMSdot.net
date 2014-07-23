using System;
using System.Collections.Generic;
using System.ServiceModel;
using ModelsWCF.Domain;

namespace Portfolio.Interfaces
{
    [ServiceContract]
    public interface IPortfolio
    {
        [OperationContract]
        IList<Menu> GetMenu(int idLanguage);
        [OperationContract]
        IList<Language> GetLanguageList();
        [OperationContract]
        IList<Article> GetArticlesByCategory(string nameCategory);
        [OperationContract]
        IList<Article> GetArticlesByIdCategory(int idCategory);

    }
}
