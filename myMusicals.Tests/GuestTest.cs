using NUnit.Framework;
using myMusicals.Classes;

namespace MyMusicals.Tests
{
    public class GuestTests
    {
        private Guest guest;
        [SetUp]
        public void Setup()
        {
            guest = new Guest();
        }

        [Test]
        public void Initialwerte_SindRichtig()
        {
            Assert.That(guest.Name, Is.EqualTo("leer"));
        }

        [Test]
        public void insertDB()
        {
            guest = new Guest("TEST");
            int responseinsertId = guest.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
        }

        //[Test]
        //public void insertDBAnzahl()
        //{
        //    guest = new Guest("TEST") { Phone = "xxx", EMail = "fhfhhf"};
        //    int responseinsertId = guest.Save();
        //    Assert.That(responseinsertId, Is.GreaterThan(0));
        //}

        [Test]
        public void updateDB()
        {
            guest = new Guest("TEST");
            int responseinsertId = guest.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            guest.Id = responseinsertId;
            guest.Phone = "xxxx";
            guest.EMail = "yyyy";
            int responseupdate = guest.Save();
            Assert.That(responseupdate, Is.EqualTo(1));
        }

        [Test]
        public void updateDBAnzahl()
        {
            guest = new Guest("TEST");
            int responseinsertId = guest.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            guest.Id = responseinsertId;
            guest.Name = "Neuer NAME";
            guest.Phone = "xxxx";
            guest.EMail = "yyyy";
            int responseupdate = guest.Save();
            Assert.That(responseupdate, Is.EqualTo(1));
        }

        [Test]
        public void deleteDB()
        {
            guest = new Guest("TEST");
            int responseinsertId = guest.Save();
            Assert.That(responseinsertId, Is.GreaterThan(0));
            guest.Id = responseinsertId;
            int responsedekete = Guest.Delete(guest.Id);
            Assert.That(responsedekete, Is.EqualTo(1));
        }


    }
}
