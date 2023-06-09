﻿namespace Znode.Engine.WebStore.ViewModels
{
    public class EcommercePurchasedProductsViewModel
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
