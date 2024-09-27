using DevCardMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMvc.ViewComponents
{
    public class MyShopsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var shops = new List<MyShops>()
            {
                new MyShops(1, "فروشگاه شماره ۱", "این اطلاعات فروشگاه من است", "blog-post-thumb-card-1.jpg"),
                new MyShops(2, "فروشگاه شماره 2", "این اطلاعات فروشگاه من است", "blog-post-thumb-card-2.jpg"),
                new MyShops(3, "3", "این اطلاعات فروشگاه من است", "blog-post-thumb-card-3.jpg"),
                new MyShops(4, "فروشگاه شماره 4", "این اطلاعات فروشگاه من است", "blog-post-thumb-card-4.jpg"),
            };
            return View("_MyShops", shops);
        }
    }
}
