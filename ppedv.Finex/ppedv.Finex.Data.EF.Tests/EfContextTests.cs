using System;
using AutoFixture;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ppedv.Finex.Model;

namespace ppedv.Finex.Data.EF.Tests
{
    [TestClass]
    public class EfContextTests
    {
        [TestMethod]
        public void EfContext_can_create_database()
        {
            using (var con = new EfContext())
            {
                if (con.Database.Exists())
                    con.Database.Delete();

                Assert.IsFalse(con.Database.Exists());
                con.Database.Create();
                Assert.IsTrue(con.Database.Exists());
            }
        }

        [TestMethod]
        public void EfContext_can_CRUD_Medikament()
        {
            var med = new Medikament() { Name = "MedOne", Nummer = $"99999-00_{Guid.NewGuid()}", Packungsgröße = 12, Preis = 13.33m };
            var newNum = $"2222-22_{Guid.NewGuid()}";

            //CREATE
            using (var con = new EfContext())
            {
                con.Medikamente.Add(med);
                con.SaveChanges();
            }

            //READ + UPDATE
            using (var con = new EfContext())
            {
                var loaded = con.Medikamente.Find(med.Id);
                Assert.AreEqual(med.Nummer, loaded.Nummer);

                loaded.Nummer = newNum;
                con.SaveChanges();
            }

            //check UPDATE + DELETE
            using (var con = new EfContext())
            {
                var loaded = con.Medikamente.Find(med.Id);
                Assert.AreEqual(newNum, loaded.Nummer);

                con.Medikamente.Remove(loaded);
                con.SaveChanges();
            }

            //check DELETE
            using (var con = new EfContext())
            {
                var loaded = con.Medikamente.Find(med.Id);
                Assert.IsNull(loaded);
            }
        }



        [TestMethod]
        public void EfContext_CR_Medikament_AutoFix_FluentAssertions()
        {
            var fix = new Fixture();
            fix.Behaviors.Add(new OmitOnRecursionBehavior());
            var med = fix.Build<Medikament>().Create();

            using (var con = new EfContext())
            {
                con.Medikamente.Add(med);
                con.SaveChanges();
            }

            using (var con = new EfContext())
            {
                var loaded = con.Medikamente.Find(med.Id);

                loaded.Should().NotBeNull();
                loaded.Packungsgröße.Should().BeGreaterThan(0);
                
                med.Should().BeEquivalentTo(loaded, x => x.IgnoringCyclicReferences());
         
            }

        }

    }
}
