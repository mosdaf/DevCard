﻿using DevCardMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCardMvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1,"نقره‌ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services,"Id","Name")
            };
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact formContact)
        {
            formContact.Services = new SelectList(_services, "Id", "Name");
            
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید.";
                return View(formContact);
            }
            formContact = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "نظر شما با موفقیت ثبت شد.";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}