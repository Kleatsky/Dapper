using ConsoleApp.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DB
{
    internal class UpdateToDB
    {
        public static async Task UpdateCustomersAsync(NpgsqlConnection connection, Customers customer)
        {
            var query = @"UPDATE public.customers 
                            SET firstname = @FirstName,
                            lastname = @LastName,
                            age = @Age
                         WHERE id = @Id;";
            try
            {
                await connection.ExecuteAsync(query, customer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task UpdateProductsAsync(NpgsqlConnection connection, Products product)
        {
            var query = @"UPDATE public.products
                            SET name = @Name,
                            description = @Description,
                            stockquantity = @StockQuantity,
                            price = @Price
                        WHERE id = @ID;";
            try
            {
                await connection.ExecuteAsync(query, product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task UpdateOrdersAsync(NpgsqlConnection connection, Orders order)
        {
            var query = @"UPDATE public.orders
                            SET customerid = @CustomerID,
                            productid = @ProductID,
                            quantity = @Quantity
                        WHERE id = @ID;";
            try
            {
                await connection.ExecuteAsync(query, order);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
