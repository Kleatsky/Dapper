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
    internal class DeleteFromDB
    {
        public static async Task DeleteCustomersAsync(NpgsqlConnection connection, int idCustomers)
        {
            var query = @"DELETE FROM public.customers WHERE id = @IdCustomers;";
            try
            {
                await connection.QueryAsync(query, new { IdCustomers = idCustomers });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task DeleteProductsAsync(NpgsqlConnection connection, int idProducts)
        {
            var query = @"DELETE FROM public.Products WHERE id = @IdProducts;";
            try
            {
                await connection.QueryAsync(query, new { IdProducts = idProducts });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task DeleteOrdersAsync(NpgsqlConnection connection, int idOrders)
        {
            var query = @"DELETE FROM public.Orders WHERE id = @IdOrders;";
            try
            {
                await connection.QueryAsync(query, new { IdOrders = idOrders });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
