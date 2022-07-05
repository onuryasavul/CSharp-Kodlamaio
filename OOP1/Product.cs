using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int id { get; set; } //primary key
        public int categoryId { get; set; } //foreign key
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public int unitsInStock { get; set; }


    }
}
