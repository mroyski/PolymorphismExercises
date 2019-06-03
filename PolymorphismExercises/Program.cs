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
        }
    }
}
