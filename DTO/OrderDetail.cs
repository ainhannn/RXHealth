using System;
using System.Collections.Generic;

namespace DTO
{
    public class OrderDetail
    {
        public ProductInfo Product { get; set; }
        public int Number { get; set; }
        public OrderDetail(ProductInfo product, int number)
        {
            Product = product;
            Number = number;
        }
    }
}
