using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracle = new OracleConnection("12345");
            var sql = new SqlConnection("67890");

            oracle.OpenConnection();
            oracle.CloseConnection();

            sql.OpenConnection();
            sql.CloseConnection();

            Console.WriteLine();

            var commandOracle = new DbCommand(oracle, "Execute Oracle Command.");
            commandOracle.Execute();

            var commandSql = new DbCommand(sql, "Execute Sql Command.");
            commandSql.Execute();
        }
    }
}
