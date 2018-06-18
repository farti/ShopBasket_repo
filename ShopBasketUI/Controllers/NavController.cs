using System.Collections.Generic;
using System.Web.Mvc;
using ShopBasketLibrary.Abstract;
using System.Linq;

namespace ShopBasketUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;

        public NavController(IProductRepository repo)
        {
            repository = repo;
        }


        public PartialViewResult Menu()
        {
            return PartialView();
        }
    }
}