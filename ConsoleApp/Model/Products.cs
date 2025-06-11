using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    internal class Products
    {
        public int ID { get; set; }
        public string ?Name { get; set; }
        public string ?Description { get; set; }
        public int StockQuantity { get; set; }
        public int Price { get; set; }
    }
}
