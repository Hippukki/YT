using ClientApp.Services.Contacts;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using YesterdayTimesApi.Entities;

namespace ClientApp.Services
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient httpClient;
        public ArticleService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ArticleDetailedDTO>> GetArticles()
        {
            try
            {
                var articles = await this.httpClient.GetFromJsonAsync<IEnumerable<ArticleDetailedDTO>>("articles/get");
                return articles;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
