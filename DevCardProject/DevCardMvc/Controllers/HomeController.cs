﻿using DevCardMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCardMvc.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact();
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
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید.";
                return View(formContact);
            }

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