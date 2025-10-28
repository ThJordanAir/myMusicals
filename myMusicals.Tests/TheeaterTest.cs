using NUnit.Framework;
using myMusicals.Classes;

namespace MyMusicals.Tests
{
    public class TheaterTests
    {
        private Theater theater;
        [SetUp]
        public void Setup()
        {
            theater = new Theater();
        }

        [Test]
        public void Initialwerte_SindRichtig()
        {
            Assert.That(theater.Title, Is.EqualTo("leer"));
        }

        [Test]
        public void insertDB()
        {
            theater = new Theater("TEST");
            int responseinsertId = theater.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
        }

        [Test]
        public void updateDB()
        {
            theater = new Theater("TEST");
            int responseinsertId = theater.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            theater.Id = responseinsertId;
            theater.Title = "Neuer Titel kommt bald";
            int responseupdate = theater.Save();
            Assert.That(responseupdate, Is.EqualTo(1));
        }

        [Test]
        public void deleteDB()
        {
            theater = new Theater("TEST");
            int responseinsertId = theater.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            theater.Id = responseinsertId;
            int responsedekete = Theater.Delete(theater.Id);
            Assert.That(responsedekete, Is.EqualTo(1));
        }


    }
}
