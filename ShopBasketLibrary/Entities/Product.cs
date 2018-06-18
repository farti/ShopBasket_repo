using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of product.
        /// </summary>
        [Required(ErrorMessage = "Proszę podać nazwę produktu.")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        /// <summary>
        /// The netto price of the product.
        /// </summary>
        [Display(Name = "Cena")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [DataType(DataType.Currency)]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Proszę podać dodatnią cenę.")]
        public decimal PriceNetto { get; set; }

        /// <summary>
        /// The description of the product.
        /// </summary>
        [DataType(DataType.MultilineText), Display(Name = "Opis")]
        [Required(ErrorMessage = "Proszę podać opis.")]
        public string Description { get; set; }

        /// <summary>
        /// The unique number of the product`s producer.
        /// </summary>
        [Required(ErrorMessage = "Proszę wybrać producenta.")]
        [Display(Name = "Producent")]
        public int ProducerId { get; set; }

        public virtual Producer Producer { get; set; }
        

    }
}
