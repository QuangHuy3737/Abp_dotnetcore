using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace HuyWebStore.Products
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public ProductDto()
        {
        }
    }
}
