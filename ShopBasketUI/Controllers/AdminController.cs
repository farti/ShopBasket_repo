using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using System.Linq;
using System.Web.Mvc;

namespace ShopBasketUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Edit(int Id)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format($"Zapisno {product.Name}");
                return RedirectToAction("Index");
            }
            else
            {
                //błąd w wartościach danych
                return View(product);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Product());
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Product deletedProduct = repository.DeleteProduct(Id);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format($"Usunięto {deletedProduct.Name}");
            }
            return RedirectToAction("Index");
        }

    }
}