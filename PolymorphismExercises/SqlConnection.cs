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
            Console.WriteLine("Sql connection closed!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql connection opened!");
        }
    }
}
