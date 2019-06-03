using System;

namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Timeout = new TimeSpan(0, 1, 45);
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"{_connectionString} : Oracle connection closed!");
            Console.WriteLine(DateTime.Now);
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"{_connectionString} : Oracle connection opened!");
            Console.WriteLine(DateTime.Now);
        }
    }
}
