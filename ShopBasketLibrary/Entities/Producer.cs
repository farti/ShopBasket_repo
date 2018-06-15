namespace ShopBasketLibrary.Entities
{
    /// <summary>
    /// Represents producer of the product.
    /// </summary>
    public class Producer
    {
        /// <summary>
        /// The unique identifier for the producer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of producer ( comapny`s name )
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The unique number of producer`s address
        /// </summary>
        public int addressId { get; set; }
    }
}
