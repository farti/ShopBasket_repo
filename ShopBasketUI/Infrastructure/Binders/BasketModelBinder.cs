using ShopBasketLibrary.Entities;
using System.Web.Mvc;

namespace ShopBasketUI.Infrastructure.Binders
{
    public class BasketModelBinder : IModelBinder
    {
        private const string sessionKey = "Basket";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // pobranie obiektu Basket z sesjii
            Basket basket = null;
            if (controllerContext.HttpContext.Session != null)
            {
                basket = (Basket)controllerContext.HttpContext.Session[sessionKey];
            }

            // utworzenie obiektu Basket, jeżeli nie było go w danych sesjii
            if (basket == null)
            {
                basket = new Basket();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = basket;
                }
            }
            // zwracamy basket
            return basket;
        }
    }
}