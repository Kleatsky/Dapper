using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    internal class CustomerOrderDTO
    {
        public int CustomerID { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public int ProductID { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }
    }
}
