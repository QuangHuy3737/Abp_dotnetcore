using System;
using Abp.Domain.Entities;

namespace HuyWebStore.Products
{
    
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}
