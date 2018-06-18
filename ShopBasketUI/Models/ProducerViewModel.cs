using ShopBasketLibrary.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ShopBasketUI.Models
{
    public class ProducerViewModel
    {
        public SelectList list { get; set; }
        public int selectedItem { get; set; }
    }
}