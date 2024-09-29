using Microsoft.AspNetCore.Mvc;
using SevCard.Models;


namespace SevCard.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "project-1.jpg", "پروژه اول", "این اولین پروژه من است", "Google"),
                new Project(2, "project-2.jpg", "پروژه دوم", "این دومین پروژه من است", "Apple"),
                new Project(3, "project-3.jpg", "پروژه سوم", "این سومین پروژه من است", "Amazon"),
                new Project(4, "project-4.jpg", "پروژه چهارم", "این چهارمین پروژه من است", "Ebay")
            };
            return View("_Projects",projects);
        }
    }
}
