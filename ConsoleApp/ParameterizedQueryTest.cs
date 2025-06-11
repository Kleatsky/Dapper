using ConsoleApp.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ParameterizedQueryTest
    {
        public static async Task Tests(NpgsqlConnection connection)
        {
            //Parameterized sql query to Customers
            try
            {
                try
                {
                    var customer = new Customers
                    {
                        ID = 5000,
                        FirstName = "NameAdd",
                        LastName = "LastNameAdd",
                        Age = 45
                    };

                    await InsertToDB.InsertCustomersAsync(connection, customer);

                    var customerUpdate = new Customers
                    {
                        ID = 5000,
                        FirstName = "NameAdd1",
                        LastName = "LastNameAdd1",
                        Age = 451
                    };

                    await UpdateToDB.UpdateCustomersAsync(connection, customerUpdate);

                    await DeleteFromDB.DeleteCustomersAsync(connection, customerUpdate.ID);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Parameterized sql query to Products
            try
            {
                try
                {
                    var product = new Products
                    {
                        ID = 5000,
                        Name = "NameAdd",
                        Description = "DescriptionAdd",
                        StockQuantity = 123,
                        Price = 1234
                    };

                    await InsertToDB.InsertProductsAsync(connection, product);

                    var productUpdate = new Products
                    {
                        ID = 5000,
                        Name = "NameAdd1",
                        Description = "DescriptionAdd1",
                        StockQuantity = 1231,
                        Price = 12341
                    };

                    await UpdateToDB.UpdateProductsAsync(connection, productUpdate);

                    await DeleteFromDB.DeleteProductsAsync(connection, productUpdate.ID);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Parameterized sql query to Orders
            try
            {
                var order = new Orders
                {
                    ID = 5000,
                    CustomerID = 1,
                    ProductID = 1,
                    Quantity = 1
                };

                await InsertToDB.InsertOrdersAsync(connection, order);

                var orderUpdate = new Orders
                {
                    ID = 5000,
                    CustomerID = 1,
                    ProductID = 1,
                    Quantity = 21
                };

                await UpdateToDB.UpdateOrdersAsync(connection, orderUpdate);

                await DeleteFromDB.DeleteOrdersAsync(connection, orderUpdate.ID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
