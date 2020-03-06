using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ppedv.Finex.Model;
using ppedv.Finex.Model.Contracts;
using System.Linq;

namespace ppedv.Finex.Logic.Tests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void Core_GetMedikamentWithMostLagerbestand_empty_database_result_null()
        {
            var mock = new Mock<IRepository>();

            var core = new Core(mock.Object);

            var result = core.GetMedikamentWithMostLagerbestand();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Core_GetMedikamentWithMostLagerbestand_2_medis_in_2_lagern()
        {
            var med1 = new Medikament() { Name = "M1" };
            med1.Lager.Add(new Lager() { Bestand = 12 });

            var med2 = new Medikament() { Name = "M2" };
            med2.Lager.Add(new Lager() { Bestand = 6 });
            med2.Lager.Add(new Lager() { Bestand = 8 });

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.Query<Medikament>()).Returns(new[] { med1, med2 }.AsQueryable());

            var core = new Core(mock.Object);

            var result = core.GetMedikamentWithMostLagerbestand();

            Assert.AreEqual(med2, result);
        }

        [TestMethod]
        public void Core_GetMedikamentWithMostLagerbestand_2_medis_same_amount_sort_by_name()
        {
            var med1 = new Medikament() { Name = "BBB" };
            med1.Lager.Add(new Lager() { Bestand = 12 });

            var med2 = new Medikament() { Name = "AAA" };
            med2.Lager.Add(new Lager() { Bestand = 6 });
            med2.Lager.Add(new Lager() { Bestand = 6 });

            var mock = new Mock<IRepository>();
            mock.Setup(x => x.Query<Medikament>()).Returns(new[] { med1, med2 }.AsQueryable());

            var core = new Core(mock.Object);

            var result = core.GetMedikamentWithMostLagerbestand();

            Assert.AreEqual(med2, result);
        }
    }
}
