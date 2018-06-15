namespace ShopBasketLibrary.Entities
{
    /// <summary>
    /// Represents Product information.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The netto price of the product.
        /// </summary>
        public decimal PriceNetto { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The unique number of the product`s producer.
        /// </summary>
        public int ProducerId { get; set; }
    }
}
