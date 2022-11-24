using ClientApp.Services.Contacts;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using YesterdayTimesApi.Entities;

namespace ClientApp.Pages
{
    public class ArticlesBase : ComponentBase
    {
        [Inject]
        public IArticleService ArticleService { get; set; }

        public IEnumerable<ArticleDetailedDTO> Articles {get;set;}

        protected override async Task OnInitializedAsync()
        {
            Articles = await ArticleService.GetArticles();
        }
    }
}
