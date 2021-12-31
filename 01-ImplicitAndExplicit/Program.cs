using System;

namespace _01_ImplicitAndExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products()
            {
                Id = 1,
                ProductName = "Deneme",
                Price = 150
            };

            //3. Parti kütüphane kullanmak istemezsek detay DTOProducts nesnesine




            #region Explicit / Bilinçli sınıf dönüşümü

            DTOProducts dTOProducts = (DTOProducts)products;
            dTOProducts.ProductName = "Deneme Implicit";
            //Console.WriteLine(dTOProducts.ProductName);
            #endregion


            DTOProducts dTOProducts1 = new DTOProducts()
            {
                Id = 2,
                ProductName = "DTO'dan geri dönüşüm"
            };

            Products products1 = (Products)dTOProducts1;

            Console.WriteLine($"{products1.Id} {products1.ProductName}");


            #region  Implicit / Bilinçsiz sınıf donüşümü

            //Products products1 = new Products();

            //products1 = dTOProducts;

            //Console.WriteLine(products1.ProductName);


            #endregion

        }
    }
}
