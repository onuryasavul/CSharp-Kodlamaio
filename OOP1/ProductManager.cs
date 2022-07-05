using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.productName + " eklendi.");
        }

        public void Update(Product product, double newUnitPrice)
        {
            product.unitPrice = newUnitPrice;
            Console.WriteLine(product.productName + "ürününün fiyatı güncellendi güncellendi. Yeni fiyat: "
                + product.unitPrice);
        }





    }
}
