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

        public ViewResult Index(string returnUrl)
        {
            return View(new BasketIndexViewModel
            {
                Basket = GetBasket(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToBasket(int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);

            if (product != null)
            {
                GetBasket().AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromBasket(int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);
            if (product != null)
            {
                GetBasket().RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Basket GetBasket()
        {
            Basket basket = (Basket)Session["Basket"];
            if (basket == null)
            {
                basket = new Basket();
                Session["Basket"] = basket;
            }
            return basket;
        }
    }
}