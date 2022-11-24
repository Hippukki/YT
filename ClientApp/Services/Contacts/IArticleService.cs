using System.Collections.Generic;
using System.Threading.Tasks;
using YesterdayTimesApi.Entities;

namespace ClientApp.Services.Contacts
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleDetailedDTO>> GetArticles();
    }
}
