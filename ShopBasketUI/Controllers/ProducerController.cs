using ShopBasketLibrary.Abstract;
using ShopBasketLibrary.Entities;
using ShopBasketUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ShopBasketUI.Controllers
{
    public class ProducerController : Controller
    {
        private IProducerRepository repository;

        public ProducerController(IProducerRepository producerRepository)
        {
            this.repository = producerRepository;
        }

        public ViewResult List()
        {
            return View(repository.Producers);
        }

        public ActionResult ProducerList()
        {
            List<Producer> pList = repository.Producers.ToList();
            var model = new ProducerViewModel();
            model.list = new SelectList(pList, "Id", "Name");
            return View(model);

        }

    }
}