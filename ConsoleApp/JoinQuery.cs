using ConsoleApp.DB;
using ConsoleApp.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class JoinQuery
    {
        public static async Task JoinAsync(NpgsqlConnection connection)
        {
            int productId = 1;
            int age = 30;
            try
            {
                List<CustomerOrderDTO> customerOrders = await SelectCustomerOrders.GetCustomerOrderDTO(connection, age, productId);
                foreach (CustomerOrderDTO customerOrder in customerOrders)
                {
                    Console.WriteLine($"CustomerID: {customerOrder.CustomerID} FirstName: {customerOrder.FirstName} " +
                        $"LastName: {customerOrder.LastName} ProductID: {customerOrder.ProductID} " +
                        $"ProductQuantity: {customerOrder.ProductQuantity} ProductPrice: {customerOrder.ProductPrice}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
