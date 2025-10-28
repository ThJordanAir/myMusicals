using myMusicals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicals.Classes
{
    public class Musical
    {
        // Musical
        public int Id { get; set; } = 0;
        public string Title { get; set; } = "leer";
        public int TheaterId { get; set; } = 0;
        public double Price { get; set; } = 0.0;

        // public Musical() { }
        /*
        self.vorstellungen = [] # Liste von Vorstellungen
        */
        public Musical()
        {
            CreateTable();
        }

        public Musical( string title, int theaterid, double price ) {
            Title = title;
            TheaterId = theaterid;
            Price = price;
        }

        public Musical (int id, string title, int theaterid, double price )
            : this(title, theaterid, price)
        {
            Id = id;
        }
        public static void CreateTable()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Musicals (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    TheaterId INTEGER,
                    Price REAL
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
            cmd.CommandText = "INSERT INTO Musicals (Title, TheaterId, Price) VALUES (@title , @theaterid, @price); SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@theaterid", TheaterId);
            cmd.Parameters.AddWithValue("@price", Price);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Theater aktualisieren
        public dynamic Update()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Musicals SET Title = @title, TheaterId = @theaterid, Price = @price WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@title", Title);
            cmd.Parameters.AddWithValue("@theaterid", TheaterId);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@id", Id);
            return cmd.ExecuteNonQuery();
        }

        // Theater nach Id löschen
        public static dynamic Delete(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Musicals WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        // ein Theater abrufen
        public static Musical Get(int ID)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Title, TheaterId, Price FROM Musicals WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", ID);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Musical readMusical = new Musical(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetDouble(3)
                );
                return readMusical;
            }
            return null;
        }

        // Alle Theater abrufen
        public static List<Musical> GetAll(int theaterId)
        {
            var musicals = new List<Musical>();

            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Title, TheaterId, Price FROM Musicals WHERE TheaterId = @theaterId ORDER BY Title ASC;";
            cmd.Parameters.AddWithValue("@theaterId", theaterId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                musicals.Add(new Musical(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetDouble(3)
                ));
            }

            return musicals;
        }


    }
}
