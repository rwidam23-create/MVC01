using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    public class ProductsController1 : Controller
    {
        #region  Actions   
        //public string Test()
        // {
        //     return $"Hello From Test";
        // }
        //public IActionResult Test()
        //{
        //ContentResult result= new ContentResult();
        //result.ContentType = "text/html";
        //result.Content = "Hello from Test</br>BYE";
        //result.StatusCode = 200;
        //return result;
        //    if (true)
        //        return Content(content: "Hello from Test</br>BYE", contentType: "text/html");
        //    else
        //        return NotFound();
        //}
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public ActionResult GetProducts()
        //{
        //    var products = new List<Product>()
        //    {
        //        new Product { Id = 1,Name="Mobile" },
        //        new Product { Id = 2,Name="Tablet" },
        //    };
        //    return Json(products);
        //}
        //[NonAction]

        //public ActionResult Test()
        //{
        //    return View();
        //}
        //public IActionResult GetProdyctById(int id)
        //{
        //    if (id < 0)
        //        return BadRequest();
        //    else if (id == 0)
        //        return RedirectToAction(nameof(GetProducts));
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Json(new Product { Id = 1, Name = "Laptop" });

        //}
        //[HttpGet]
        //public IActionResult RedirectAction()
        //{
        //    return Redirect("https://www.youtube.com/watch?v=2SHYMTSdyq4");
        //}
        #endregion
        #region Routing
        //[HttpGet("Test01")]
        //public IActionResult TestRouting()
        //{
        //    return Json($"Hello from TestRouting");
        //}
        //[HttpGet("TestRouting/Test/{id:int}")]
        //public  IActionResult TestRouting(int id)
        //{
        //    return Json($"Hello wit id:{id}");
        //}
        //public IActionResult TestRouting(int id ,string name)
        //{
        //    return Json($"Hello from TestRouting Id->{id},name->{name}");
        //}
        //[HttpGet("json")]
        //public IActionResult jsonAction()
        //{
        //    return Json($"Hello from json action");
        //}
        //[HttpGet("GetProductByCode /{code:int}")]
        //public IActionResult GetProductByCode(int code)
        //{
        //    return Json (new Product() { Id= code ,Name="Mobile "});
        //}

        #endregion
        #region Model Binding
        //simple Data
        //[HttpGet]
        //public IActionResult GetById([FromQuery]int id,[FromQuery (Name ="id02")]int anotherId)
        //{
        //    return Json(new {id=id, anotherId=anotherId});
        //}
        //Complix Data
        //[HttpGet]
        //public IActionResult Search(ProductFilter filter)
        //{
        //    return Content("Research completed");
        //}
        //collection
        //[HttpGet]
        //public IActionResult Getbyids(int[] ids)
        //{
        //    return Json(new { ids });
        //}
        #endregion
    }
}
