using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBeautyShop1.Domain.Abstract;

namespace TheBeautyShop1.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;
        
        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SeletedCategory = category;

            IEnumerable<string> categories = repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}