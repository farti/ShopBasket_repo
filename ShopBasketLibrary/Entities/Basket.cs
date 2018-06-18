using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBasketLibrary.Entities
{
    public class Basket
    {
        private List<BasketLine> lineCollection = new List<BasketLine>();
        private decimal Tax = 0.23M;
             
        public void AddItem(Product product, int quantity)
        {
            BasketLine line = lineCollection
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (line==null)
            {
                lineCollection.Add(new BasketLine { Product = product, Quantity = quantity });
            } else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveItem(Product product, int quantity)
        {
            BasketLine line = lineCollection
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (line.Quantity >0)

            {
                line.Quantity -= quantity;
            }
        }

        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.Id == product.Id);
        }

        public decimal ComputeTotalValueNetto()
        {
            return lineCollection.Sum(e => e.Product.PriceNetto * e.Quantity);
        }

        public decimal ComputeTax()
        {
            return decimal.Multiply(ComputeTotalValueNetto(), Tax); 
        }

        public decimal ComputeTotalValueBrutto()
        {
            return decimal.Add(ComputeTotalValueNetto(), ComputeTax()); 
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<BasketLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class BasketLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
