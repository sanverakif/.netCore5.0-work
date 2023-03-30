using Microsoft.AspNetCore.Mvc;
using OrnekProje.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Product>()
            {

                new Product{ID = 1,ProductName = "tv",Quantity= 10},
                new Product{ID = 2,ProductName = "pc",Quantity= 20},
                new Product{ID = 3,ProductName = "tel",Quantity= 30},
                new Product{ID = 4,ProductName = "note",Quantity= 40}
             };
            //model bazlı çalışır. gönderilen modelin türünü viewa hangi türde olduğunu bildirmeliyiz.
            //return View(products);

            //viewa gönderilen datayı dinamik şekilde tanımlanan değişkenle göndeririz
            //ViewBag.products = products;
            //actionda olan datayı viewa taşır
            //ViewData ["urunler"] = products;
            //tempdata actionlar arası veri taşıma kontrolu sağlar
            TempData ["akif"] = 10;
            return RedirectToAction("Index2","Product");
        }
        public IActionResult Index2()
        {
            var isim = TempData ["akif"];
            return View();
        }
        //ViewResult: view dosyasını render etmemizi sağlar
        //public ViewResult GetProducts()
        //{
        //    ViewResult view = View();
        //    return view;
        //}

        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //}
        // clienta gelen isteğe göre json döndürmek istersek kullanırız
        public JsonResult GetProducts()
        {
            JsonResult result = Json(new Product()
            {
                ID = 1,
                ProductName = "tv",
                Quantity = 5
            });
            return result;
        }
        //metinsel değer döndürürüz
        public ContentResult ContentResult()
        {
            ContentResult c = Content("akif emre");

            return c;
        }
        //Result türlerinin base classıdır. Action türlerini karşılar.
        public IActionResult ActionRes()
        {
            if (5 > 2) {
                return Json(new Product()
                {
                    ID = 2,
                    ProductName = "pc",
                    Quantity = 6
                });
            }
            else if (5 < 2) {
                return View();
            }
            int a = 10;
        }
    }
}
