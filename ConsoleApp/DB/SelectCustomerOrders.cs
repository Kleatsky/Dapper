using ConsoleApp.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.DB
{
    internal class SelectCustomerOrders
    {
        public static async Task<List<CustomerOrderDTO>> GetCustomerOrderDTO(NpgsqlConnection connection, int age, int productId)
        {
            var query = @"SELECT 
                            o.CustomerID AS ""CustomerID"",
                            c.FirstName AS ""FirstName"",
                            c.LastName AS ""LastName"",
                            o.ProductID AS ""ProductID"",
                            o.Quantity AS ""ProductQuantity"",
                            p.Price AS ""ProductPrice""
                        FROM customers AS c
                        JOIN orders AS o ON c.id = o.customerid
                        JOIN products AS p ON p.id = o.productid
                        WHERE c.age > @Age AND o.productid = @ProductId";
            try
            {
                var customerOrders = await connection.QueryAsync<CustomerOrderDTO>(query, new { Age = age, ProductId = productId });
                return customerOrders.ToList<CustomerOrderDTO>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
