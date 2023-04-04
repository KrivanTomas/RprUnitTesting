using System;
using NUnit.Framework;
using UnitTest;

namespace UnitTestProject
{
    public class HerniPostavaTesty
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MocDloheJmeno()
        {
            Assert.Throws<Exception>(() =>
            {
                new HerniPostava("tohlejemocdlouhe");
            });
        }

        [Test]
        public void SpravneJmeno()
        {
            Assert.DoesNotThrow(() =>
            {
                new HerniPostava("kratke");
            });
        }

        [Test]
        public void PocatecniLevel()
        {
            Assert.IsTrue(new HerniPostava("Luna").level == 1);
        }

        [Test]
        public void PocatecniX()
        {
            Assert.IsTrue(new HerniPostava("Misha").X == 0);
        }

        [Test]
        public void PocatecniY()
        {
            Assert.IsTrue(new HerniPostava("Muffin").Y == 0);
        }

        [Test]
        public void ZmenaSouradnic()
        {
            HerniPostava postava = new HerniPostava("Oliver");
            double ocekavanyX = 69;
            double ocekavanyY = 420;
            postava.ZmenaPozice(ocekavanyX, ocekavanyY);
            Assert.IsTrue(postava.X == ocekavanyX && postava.Y == ocekavanyY);
        }

    }

    public class HracTesty {
        [SetUp]

        public void Setup()
        {
        }

        // Hrac.cs testy
        [Test]
        public void SpravneKlasy()
        {
            Assert.DoesNotThrow(() =>
            {
                new Hrac("Oliver", "Kouzelník", Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, Hrac.BarvaVlasu.Kastanova);
                new Hrac("Merci", "Berserker", Hrac.Oblicej.MakeUp, Hrac.Vlasy.Pleska, Hrac.BarvaVlasu.Blond);
                new Hrac("Boøek", "Inženýr", Hrac.Oblicej.Usoplesk, Hrac.Vlasy.Culik, Hrac.BarvaVlasu.Cervena);
                new Hrac("Pepa", "Cizák", Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Drdol, Hrac.BarvaVlasu.Blond);
            });
        }

        [Test]
        public void SpatnaKlasa()
        {
            Assert.Throws<Exception>(() =>
            {
                new Hrac("Oliver", "GS main", Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, Hrac.BarvaVlasu.Cervena);
            });
        }

        [Test]
        public void testXP()
        {
            Hrac hrac = new Hrac("Oliver", "Kouzelník", Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, Hrac.BarvaVlasu.Cervena);
            if (hrac.level != 1) Assert.Fail();
            hrac.PridejXP(100);
            if (hrac.level != 2) Assert.Fail();
            hrac.PridejXP(100);
            if (hrac.level != 2) Assert.Fail();
            hrac.PridejXP(100);
            if (hrac.level != 3) Assert.Fail();
            Assert.Pass();
        }
    }

    public class NPCTesty
    {
        [SetUp]

        public void Setup()
        {
        }

        [Test]
        public void TestInstance1()
        {
            NPC npc = new NPC("Sticky", NPC.Work.Nepritel, 1, true);

            if (npc.Jmeno == "Sticky" && npc.Prace == NPC.Work.Nepritel && npc.Sila == 1 && npc.Boss) Assert.Pass();
        }

        [Test]
        public void TestInstance2()
        {
            NPC npc = new NPC("Peeta", NPC.Work.Nepritel, 1, true);

            if (npc.Jmeno == "Peeta" && npc.Prace == NPC.Work.Obchodnik && npc.Sila == 0 && !npc.Boss) Assert.Pass();
        }
    }
}