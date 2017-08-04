using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBeautyShop1.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Pleasse enter a product name")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]

        [Required(ErrorMessage = "Pleasse enter a description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Pleasse enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Pleasse specify a category")]
        public string Category { get; set; }
        
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}