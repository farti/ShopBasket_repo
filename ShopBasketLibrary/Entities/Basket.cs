namespace ShopBasketLibrary.Entities
{
    /// <summary>
    /// Represents what is in the basket.
    /// </summary>
    public class Basket
    {
        /// <summary>
        /// The unique identifier for the basket.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique number of product in basket
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// The quantity of product in basket
        /// </summary>
        public int Quantity { get; set; }
    }
}
