using DevCardMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMvc.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"پروژه تاکسی","انواع درخواست‌ها برای ساخت انواع کلاینت‌ها","project-1.jpg","Snapp"),
                new Project(1,"پروژه خر","انواع درخواست‌ها برای ساخت انواع کلاینت‌ها","project-2.jpg","گوگل"),
                new Project(1,"پروژه غذا","انواع درخواست‌ها برای ساخت انواع کلاینت‌ها","project-3.jpg","دارکوب"),
                new Project(1,"پروژه ما","انواع درخواست‌ها برای ساخت انواع کلاینت‌ها","project-4.jpg","سگ"),

            };
            return View("_Projects",projects);
        }
    }
}
