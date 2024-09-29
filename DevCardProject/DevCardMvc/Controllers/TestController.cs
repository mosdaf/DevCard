using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace DevCardMvc.Controllers
{
    public class TestController : Controller
    {
        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/me.jpeg");
        //    const string fileName = "TestFile.jpeg";
        //    return File(fileByte, MediaTypeNames.Image.Jpeg, fileName);
        //}


        public JsonResult Index()
        {
            return Json(new {
                Id = 12,
                Name = "Mostafa",
                Job = "Programmer" });
        }
    }
}
