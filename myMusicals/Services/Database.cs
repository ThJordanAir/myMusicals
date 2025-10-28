using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myMusicals.Services
{
    internal static class Database
    {
        private const string DbEgalPath = "data.db";
        private const string ConnectionString = "Data Source=data.db;";

        public static void Initialize()
        {
            SQLitePCL.Batteries.Init(); 
            
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "PRAGMA journal_mode=WAL;";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "PRAGMA busy_timeout=5000;";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }

        /*
                public static void CreateDbFile()
                {
                    if (!File.Exists(DbPath))
                    {
                        File.Create(DbPath).Close();
                        System.Diagnostics.Debug.WriteLine("SQLite DB erstellt!");
                    }
                }
        */

    }
}
