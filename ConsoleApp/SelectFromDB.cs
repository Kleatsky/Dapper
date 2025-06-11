using ConsoleApp.Model;
using Npgsql.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace ConsoleApp
{
    internal class SelectFromDB
    {
        public static async Task<List<Customers>> SelectAllCustomersAsync(NpgsqlConnection connection)
        {
            var query = "SELECT * FROM Customers";
            try
            {
                var customers = await connection.QueryAsync<Customers>(query);
                return customers.ToList<Customers>();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static async Task<List<Products>> SelectAllProductsAsync(NpgsqlConnection connection)
        {
            var query = "SELECT * FROM Products";
            try
            {
                var products = await connection.QueryAsync<Products>(query);
                return products.ToList<Products>();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static async Task<List<Orders>> SelectAllOrdersAsync(NpgsqlConnection connection)
        {
            var query = "SELECT * FROM Orders";
            try
            {
                var orders = await connection.QueryAsync<Orders>(query);
                return orders.ToList<Orders>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
