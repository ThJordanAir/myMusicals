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
        public int Rows { get; set; } = 10;
        public int Seats { get; set; } = 25;

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
        public Theater(int id, string title, int rows, int seats)
        {
            Id = id;
            Title = title;
            Rows = rows;
            Seats = seats;
        }
        public static void CreateTable()
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Theaters (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Rows INTEGER,
                    Seats INTEGER
                );
            ";
            cmd.ExecuteNonQuery();
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

        // Ein Theater einfügen
        public dynamic Insert()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Theaters (Title, Rows, Seats) VALUES (@title , @rows, @seats); SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@rows", Rows);
            cmd.Parameters.AddWithValue("@seats", Seats);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Theater aktualisieren
        public dynamic Update()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Theaters SET Title = @title, Rows = @rows, Seats = @seats WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@rows", Rows);
            cmd.Parameters.AddWithValue("@seats", Seats);
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

        // ein Theater abrufen
        public static Theater Get( int ID )
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Title, Rows, Seats FROM Theaters WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", ID);

            using var reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                Theater readTheater = new Theater(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3)
                );
                return readTheater;
            }
            return null;
        }

        // Alle Theater abrufen
        public static List<Theater> GetAll()
        {
            var theaters = new List<Theater>();

            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Title, Rows, Seats FROM Theaters ORDER BY Title ASC;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                theaters.Add(new Theater(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3)
                ));
            }
            return theaters;
        }
    }
}
