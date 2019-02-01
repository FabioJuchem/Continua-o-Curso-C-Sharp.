using System;
using System.Collections.Generic;
using System.Text;
using FixacaoEnumComp01.Entities;
using FixacaoEnumComp01.Entities.Enums;

namespace FixacaoEnumComp01.Entities
{
    class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
