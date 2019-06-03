using System;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        public string DbInstruction { get; set; }
        public DbConnection _dbConnection {get; set;}

        public DbCommand(DbConnection dbConnection, string dbInstruction)
        {
            _dbConnection = dbConnection;
            DbInstruction = dbInstruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(DbInstruction);
            _dbConnection.CloseConnection();
        }
    }
}
