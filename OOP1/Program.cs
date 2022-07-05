using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 01;
            product1.categoryId = 1;
            product1.productName = "Masa";
            product1.unitPrice = 250;
            product1.unitsInStock = 1000;
            

            ProductManager newProductManager = new ProductManager();
            newProductManager.Add(product1);
            newProductManager.Update(product1, 300);



        }
    }
}
