using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace TechPizzaWF
{
    class Acesso
    {
        static string serverName = "localhost";
        static string port = "5432";
        static string userName = "postgres";
        static string password = "postgres";
        static string dataBaseName = "TechPizza";
        public NpgsqlConnection Conexao = null;
        public string connString = null;

        public Acesso()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, dataBaseName);

        }
    }
}


