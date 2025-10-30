using myMusicals.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicals.Classes
{
    public class Guest
    {
        // Zuschauer
        public int Id { get; set; } = 0;
        public string Name{ get; set; } = "leer";
        public string Phone { get; set; } = "leer";
        public string EMail{ get; set; } = "leer";

        public Guest()
        {
            CreateTable();
        }

        public Guest(string name)
        {
            Name = name;
        }
        public Guest(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            EMail = email;
        }

        public Guest(int id, string name, string phone, string email)
            : this(name, phone, email)
        {
            Id = id;
        }
        public static void CreateTable()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Guests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    EMail TEXT NOT NULL
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

        // Einen Gast einfügen
        public dynamic Insert()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Guests (Name, Phone, EMail) VALUES (@name, @phone, @email); SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@email", EMail);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Gast aktualisieren
        public dynamic Update()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Guests SET Name = @name, Phone = @phone, EMail = @email WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@email", EMail);
            cmd.Parameters.AddWithValue("@id", Id);
            return cmd.ExecuteNonQuery();
        }

        // Gast nach Id löschen
        public static dynamic Delete(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Guests WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        // ein Gast abrufen
        public static Guest Get(int ID)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Phone, EMail FROM Guests WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", ID);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Guest readGuest = new Guest(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
                return readGuest;
            }
            return null;
        }

        // Alle Gäste abrufen
        public static List<Guest> GetAll()
        {
            var guests= new List<Guest>();

            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Phone, EMail FROM Guests ORDER BY Title ASC;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                guests.Add(new Guest(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                ));
            }

            return guests;
        }

    }
}
