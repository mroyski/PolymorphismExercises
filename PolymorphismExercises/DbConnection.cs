using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string _connectionString;
        public TimeSpan Timeout;

        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
