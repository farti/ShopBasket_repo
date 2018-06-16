using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using ShopBasketUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace ShopBasketUI.Controllers
{
    public class BasketController : Controller
    {
        private IProductRepository repository;

        public BasketController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(Basket basket, string returnUrl)
        {
            return View(new BasketIndexViewModel
            {
                Basket = basket,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToBasket(Basket basket, int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);

            if (product != null)
            {
                basket.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromBasket(Basket basket, int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);
            if (product != null)
            {
                basket.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

    }
}