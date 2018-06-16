using ShopBasketLibrary.Entities;
using ShopBasketUI.Infrastructure.Binders;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopBasketUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(Basket), new BasketModelBinder());
        }
    }
}
