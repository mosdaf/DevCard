using Microsoft.AspNetCore.Mvc;
using SevCard.Models;

namespace SevCard.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "blog-post-thumb-card-1.jpg", "مقاله اول", "این مقاله اول ما است."),
                new Article(2, "blog-post-thumb-card-2.jpg", "مقاله دوم", "این مقاله دوم ما است."),
                new Article(3, "blog-post-thumb-card-3.jpg", "مقاله سوم", "این مقاله سوم ما است.")
            };
            return View("_Articles", articles);
        }
    }
}
