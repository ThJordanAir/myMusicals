using NUnit.Framework;
using myMusicals.Classes;

namespace MyMusicals.Tests
{
    public class MusicalTests
    {
        private Musical musical;
        [SetUp]
        public void Setup()
        {
            musical = new Musical();
        }

        [Test]
        public void Initialwerte_SindRichtig()
        {
            Assert.That(musical.Title, Is.EqualTo("leer"));
        }

        [Test]
        public void insertDB()
        {
            musical = new Musical("TEST", 1, 19.95);
            int responseinsertId = musical.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
        }

        [Test]
        public void updateDB()
        {
            musical = new Musical("TEST", 1, 19.95);
            int responseinsertId = musical.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            musical.Id = responseinsertId;
            musical.Title = "Neuer Titel kommt bald";
            int responseupdate = musical.Save();
            Assert.That(responseupdate, Is.EqualTo(1));
        }

        [Test]
        public void updateDBAnzahl()
        {
            musical = new Musical("TEST", 1, 19.95);
            int responseinsertId = musical.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            musical.Id = responseinsertId;
            musical.Title = "Neuer Titel kommt bald";
            musical.TheaterId = 2;
            musical.Price = 39.99;
            int responseupdate = musical.Save();
            Assert.That(responseupdate, Is.EqualTo(1));
        }

        [Test]
        public void deleteDB()
        {
            musical = new Musical("TEST", 1, 19.95);
            int responseinsertId = musical.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            musical.Id = responseinsertId;
            int responsedekete = Musical.Delete(musical.Id);
            Assert.That(responsedekete, Is.EqualTo(1));
        }

    }
}
