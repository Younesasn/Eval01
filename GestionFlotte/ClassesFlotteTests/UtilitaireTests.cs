using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            // TODO
            Utilitaire U1 = new Utilitaire(60, 50, 200, "AB-200-EX", "Essence", 5);
            int expected = 10;
            Assert.AreEqual(expected, U1.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // Le véhicule a été entretenu il y a moins d'un an
            Utilitaire U1 = new Utilitaire(60, 50, 200, "AB-200-EX", "Essence", 5);
            U1.AjouterEntretien(new Entretien(new DateTime(2022, 01, 01), 14000, "RAS"));
            Assert.AreEqual(true, U1.PrevoirEntretien());

            // Le véhicule a été entretenu il y a plus d'un an
            Utilitaire U2 = new Utilitaire(60, 50, 200, "AB-200-EX", "Essence", 5);
            U2.AjouterEntretien(new Entretien(new DateTime(2021, 01, 01), 14000, "Prévoir entretien !"));
            Assert.AreEqual(false, U2.PrevoirEntretien());
        }
    }
}