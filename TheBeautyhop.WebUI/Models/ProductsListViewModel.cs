using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBeautyShop1.Domain.Entities;

namespace TheBeautyShop1.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}