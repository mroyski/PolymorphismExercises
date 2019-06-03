using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string _connectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
