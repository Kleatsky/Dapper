using ConsoleApp.Model;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    internal class InsertToDB
    {
        public static async Task InsertCustomersAsync(NpgsqlConnection connection, Customers customer)
        {
            var query = @"INSERT INTO public.customers(id, firstname, lastname, age) 
                        VALUES (@Id, @FirstName, @LastName, @Age);";
            try
            {
                await connection.ExecuteAsync(query, customer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task InsertProductsAsync(NpgsqlConnection connection, Products product)
        {
            var query = @"INSERT INTO public.products(id, name, description, stockquantity, price)
                          VALUES(@ID, @Name, @Description, @StockQuantity, @Price);";
            try
            {
                await connection.ExecuteAsync(query, product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task InsertOrdersAsync(NpgsqlConnection connection, Orders order)
        {
            var query = @"INSERT INTO public.orders(id, customerid, productid, quantity)
                          VALUES(@ID, @CustomerID, @ProductID, @Quantity);";
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
