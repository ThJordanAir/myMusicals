using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicals.Classes
{
    internal class Musical
    {
        // Musical
        public int Id { get; set; }
        public string Title { get; set; }
        public int TheaterId { get; set; }
        public double Price{ get; set; }

        // public Musical() { }

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
        /*
        self.vorstellungen = [] # Liste von Vorstellungen
        */
    }
}
