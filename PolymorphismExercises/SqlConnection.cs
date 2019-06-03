using System;

namespace PolymorphismExercises
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Timeout = new TimeSpan(0, 2, 32);
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"{_connectionString} : Sql connection closed!");
            Console.WriteLine(DateTime.Now);
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"{_connectionString} : Sql connection opened!");
            Console.WriteLine(DateTime.Now);
        }
    }
}
