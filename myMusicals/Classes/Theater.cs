using myMusicals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicals.Classes
{
    public class Theater
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = "leer";

        public Theater() {
            CreateTable();
        }

        public Theater(string title)
        {
            Title = title;
        }
        public Theater(int id, string title)
            : this(title)
        {
            Id = id;
        }

        public dynamic Save()
        {
            if (Id == 0)
            {
                return Insert();
            }
            return Update();
        }

        // Tabelle erstellen
        public static void CreateTable()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Theaters (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL
                );
            ";
            cmd.ExecuteNonQuery();
        }

        // Ein Theater einfügen
        public dynamic Insert()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Theaters (Title) VALUES (@title); SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@title", Title);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Theater aktualisieren
        public dynamic Update()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Theaters SET Title = @title WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@id", Id);
            return cmd.ExecuteNonQuery();
        }

        // Theater nach Id löschen
        public static dynamic Delete(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Theaters WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        // Alle Theater abrufen
        public static List<Theater> GetAll()
        {
            var theaters = new List<Theater>();

            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Title FROM Theaters ORDER BY Title ASC;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                theaters.Add(new Theater(
                    reader.GetInt32(0),
                    reader.GetString(1)
                ));
            }

            return theaters;
        }




    }
}
