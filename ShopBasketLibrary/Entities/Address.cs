namespace ShopBasketLibrary.Entities
{
    /// <summary>
    /// Represents the address of the producer.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// The unique identifier for the address.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the street in address
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// The number of the steet in address.
        /// </summary>
        public string StreetNumber { get; set; }

        /// <summary>
        /// The postcode of the town in address.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// The name of town in address.
        /// </summary>
        public string Town { get; set; }
    }
}
