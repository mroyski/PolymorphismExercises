using System;

namespace PolymorphismExercises
{
    public class SqlConnection : DbConnection
    {
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
