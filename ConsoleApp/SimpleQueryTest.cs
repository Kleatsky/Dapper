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
    internal class SimpleQueryTest
    {
        public static async Task Tests(NpgsqlConnection connection)
        {
            //Simple sql query to Customers
            try
            {
                List<Customers> customers = await SelectFromDB.SelectAllCustomersAsync(connection);
                foreach (Customers customer in customers)
                {
                    Console.WriteLine($"Id: {customer.ID} FirstName: {customer.FirstName} " +
                        $"LastName: {customer.LastName} Age: {customer.Age}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Simple sql query to Products
            try
            {
                List<Products> products = await SelectFromDB.SelectAllProductsAsync(connection);
                foreach (Products product in products)
                {
                    Console.WriteLine($"Id: {product.ID} Name: {product.Name} " +
                        $"Description: {product.Description} StockQuantity: {product.StockQuantity} " +
                        $"Price: {product.Price}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Simple sql query to Orders
            try
            {
                List<Orders> orders = await SelectFromDB.SelectAllOrdersAsync(connection);
                foreach (Orders order in orders)
                {
                    Console.WriteLine($"Id: {order.ID} CustomerID: {order.CustomerID} " +
                        $"ProductID: {order.ProductID} Quantity: {order.Quantity}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
