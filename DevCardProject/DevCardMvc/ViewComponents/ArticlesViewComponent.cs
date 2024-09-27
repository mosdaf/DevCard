using DevCardMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMvc.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "مقاله اول", "این مقاله اول من است من می‌توانم مقالات خیلی زیادی برای شما بنویسم.", "blog-post-thumb-card-1.jpg"),
                new Article(2, "مقاله دوم", "این مقاله دوم من است.", "blog-post-thumb-card-2.jpg"),
                new Article(3, "مقاله سوم", "این مقاله سوم من است.", "blog-post-thumb-card-3.jpg"),
                new Article(4, "مقاله چهارم", "این مقاله چهارم من است.", "blog-post-thumb-card-4.jpg")

            };
            return View("_Articles",articles);
        }
    }
}
