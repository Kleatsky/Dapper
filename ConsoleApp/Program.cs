using ConsoleApp.Model;
using Dapper;
using Npgsql;

namespace ConsoleApp
{
    internal class Program
    {
        private static string _dbFilePathPassword = @"db.password";//файл с токеном
        private static string? _dbpassword;
        static async Task Main(string[] args)
        {
            //Добавление конфигурации БД
            if (File.Exists(_dbFilePathPassword))
            {
                try
                {
                    var lines = File.ReadAllLines(_dbFilePathPassword);
                    _dbpassword = lines[0];
                }
                catch (Exception e)
                {
                    Console.WriteLine("В дериктории проекта должен быть файл db.password, " +
                        "в котором хранится пороль к базе данных." + e.Message);
                    return;
                }
            }
            else
            {
                Console.WriteLine("В дериктории проекта должен быть файл Tdb.password, " +
                        "в котором хранится пороль к базе данных.");
                return;
            }

            string connectionString = $"Host=localhost;Username=postgres;Password={_dbpassword};Database=Shop;Port=5432";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                //Siple sql query
                await SimpleQueryTest.Tests(connection);

                
                //Parameterized sql query
                await ParameterizedQueryTest.Tests(connection);


                //Join sql query
                await JoinQuery.JoinAsync(connection);
            }
            Console.WriteLine("Program complite.");
        }
    }
}
