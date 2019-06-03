using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout;

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
