using System;

namespace _02_ReflactionConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reflection ile Nesne Dönüşümü

            //DTOProducts dTOProducts = new DTOProducts()
            //{
            //    Id = 1,
            //    ProductName = "Reflection Nesne Dönüşümü"
            //};

            //Products NewProduct = ObjectConvert.Convert<DTOProducts, Products>(dTOProducts);

            //Console.WriteLine(NewProduct.ProductName);



            #endregion

            Products products = new Products()
            {
                Id = 1,
                ProductName = "Reflection Nesne Dönüşümü"
            };

            DTOProducts dtoProduct = ObjectConvert.Convert<Products, DTOProducts>(products);

            Console.WriteLine(dtoProduct.ProductName);


        }
    }
}
