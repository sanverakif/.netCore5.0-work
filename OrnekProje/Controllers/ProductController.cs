using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekProje.Model;
using OrnekProje.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Controllers
{
    public class Models
    {
        public string txtValue1 { get; set; }
        public string txtValue2 { get; set; }
        public string txtValue3 { get; set; }
    }
    public class RouteData
    {
        public int A { get; set; }
        public string B { get; set; }
        public string Id { get; set; }
    }
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class ProductController : Controller
    {
        public IActionResult CreateTuple()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult CreateTuple([Bind(Prefix = "Item1")] Product product, [Bind(Prefix = "Item2")] User user)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AjaxGetData(AjaxData ajaxData)
        {
            return View();
        }
        public IActionResult AjaxGD()
        {
            return View();
        }
        public IActionResult HeaderRes()
        {
            var headers = Request.Headers;
            return View();
        }
        [HttpPost]
        //public IActionResult QueryStr(string a, string b, string id)
        public IActionResult QueryStr()
        {
            //var res = Request.QueryString;
            //var ak = Request.Query ["a"].ToString();
            //var ba = Request.Query ["b"].ToString();

            var val = Request.RouteValues;
            return View();
        }
        public IActionResult GetProducts()
        {
            return View();
        }
        [HttpPost]
        //1.gönderilen istek sonucunda gelen dataların hepsi actionlarda bulunan parametrelerden yakalanır.(string txtName, string txtQuantity)
        //2.inputlerin nameleri ile postu karşılıcak olan actionda kullanmış parametrelerin tanımlanan classın propertyleri otomatik bağlanır. 
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            var product = new Product()
            {
                ProductName = "akif",
                Quantity = 15
            };
            return View(product);
        }
        public IActionResult CreateProduct2()
        {
            return View();
        }
        [HttpPost]
        // public IActionResult VeriAl(IFormCollection datas): form içindeki inputların name değerleri yakalanır. 
        public IActionResult VeriAl(IFormCollection datas)
        {
            var value1 = datas ["txtValue3"];
            return View();
        }
        public IActionResult TagHelpers()
        {
            return View();
        }
        //public IActionResult GetPro()
        //{
        //    //Product pr = new Product()
        //    //{
        //    //    ID = 1,
        //    //    ProductName = "a product",
        //    //    Quantity = 15
        //    //};

        //    //User us = new User()
        //    //{
        //    //    ID = 1,
        //    //    Name = "akif",
        //    //    LastName = "şanver"
        //    //};
        //    ////UserProduct up = new UserProduct()
        //    ////{
        //    ////    Product = pr,
        //    ////    User = us
        //    ////};
        //    //////ilgili viewa gönderdik
        //    ////return View(up);

        //    //var product = (pr, us);
        //    //return View(product);
        //}
        //public IActionResult Index()
        //{
        //    var products = new List<Product>()
        //    {

        //        new Product{ID = 1,ProductName = "tv",Quantity= 10},
        //        new Product{ID = 2,ProductName = "pc",Quantity= 20},
        //        new Product{ID = 3,ProductName = "tel",Quantity= 30},
        //        new Product{ID = 4,ProductName = "note",Quantity= 40}
        //     };
        //    //model bazlı çalışır. gönderilen modelin türünü viewa hangi türde olduğunu bildirmeliyiz.
        //    //ViewBag.products = products;
        //    //return View();

        //    //viewa gönderilen datayı dinamik şekilde tanımlanan değişkenle göndeririz
        //    //ViewBag.products = products;
        //    //actionda olan datayı viewa taşır
        //    //ViewData ["urunler"] = products;
        //    //tempdata actionlar arası veri taşıma kontrolu sağlar
        //    TempData ["akif"] = 10;
        //    return RedirectToAction("Index2", "Product");
        //}
        public IActionResult Index2()
        {
            var isim = TempData ["akif"];
            return View();
        }
        //ViewResult: view dosyasını render etmemizi sağlar..
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
        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product()
        //    {
        //        ID = 1,
        //        ProductName = "tv",
        //        Quantity = 5
        //    });
        //    return result;
        //}
        //metinsel değer döndürürüz
        public ContentResult ContentResult()
        {
            ContentResult c = Content("akif emre");

            return c;
        }
        //Result türlerinin base classıdır. Action türlerini karşılar.
        //public IActionResult ActionRes()
        //{
        //    if (5 > 2) {
        //        return Json(new Product()
        //        {
        //            ID = 2,
        //            ProductName = "pc",
        //            Quantity = 6
        //        });
        //    }
        //    else if (5 < 2) {
        //        return View();
        //    }
        //    int a = 10;
        //}
    }
}
