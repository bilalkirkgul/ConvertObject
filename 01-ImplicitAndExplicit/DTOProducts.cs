using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ImplicitAndExplicit
{
    class DTOProducts
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public decimal Discount { get; set; }
        public string Descriptions { get; set; }


        #region Implicit / Bilinçsiz sınıf donüşümü

        public static implicit operator Products(DTOProducts dto)
        {
            return new Products
            {
                Id = dto.Id,
                ProductName = dto.ProductName,
                Price = dto.Price,
                Stock = dto.Stock
            };
        }


        #endregion


        #region Explicit / Bilinçli sınıf dönüşümü

        public static explicit operator DTOProducts(Products products)
        {
            return new DTOProducts()
            {

                Id = products.Id,
                ProductName = products.ProductName,
                Price = products.Price,
                Stock = products.Stock,
                Descriptions = products.Descriptions


            };
        }


        #endregion
    }
}
