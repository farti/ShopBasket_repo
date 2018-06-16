using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopBasketLibrary.Entities;
using ShopBasketLibrary.Abstract;

namespace ShopBasketUI.Controllers
{
    public class BasketController : Controller
    {
        private IProductRepository repository;

        public BasketController(IProductRepository repo)
        {
            repository = repo;
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