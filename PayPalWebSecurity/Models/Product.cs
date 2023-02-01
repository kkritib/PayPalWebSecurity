﻿using System.ComponentModel.DataAnnotations;

namespace PayPalWebSecurity.Models
{
    public class Product
    { 
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public string Image { get; set; }

    }
}
