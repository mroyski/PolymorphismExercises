using System;

namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection closed!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection opened!");
        }
    }
}
