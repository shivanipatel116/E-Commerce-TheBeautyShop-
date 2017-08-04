using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBeautyShop1.Domain.Entities;

namespace TheBeautyShop1.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}