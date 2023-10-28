using System;
using System.Collections.Generic;

namespace DTO
{
    public class ImportDetail
    {
        public ProductInfo Product { get; set; }
        public int NumberOrder { get; set; }
        public int NumberActual { get; set; }
        public float UnitPrice { get; set; }
        public ImportDetail() { }
        public ImportDetail(ProductInfo product, int numberOrder, int numberActual)
        {
            Product = product;
            NumberOrder = numberOrder;
            NumberActual = numberActual;
        }
    }
}
