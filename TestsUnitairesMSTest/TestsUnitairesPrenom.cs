using LibrarieTestUnitaires;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitairesMSTest
{
    [TestClass]
    public class TestsUnitairesPrenom
    {
        [TestMethod]
        public void Prenom_Vide()
        {
            Prenom unPrenom = new Prenom("");

            Assert.ThrowsException<System.Exception>(() => unPrenom.HelloPrenom());
        }

        [TestMethod]
        public void Prenom_Plus_De_30()
        {
            Prenom unPrenom = new Prenom("sssssssssssssssssssssssssssssssssssssssssssssssss");

            Assert.ThrowsException<System.Exception>(() => unPrenom.HelloPrenom());
        }

        [TestMethod]
        public void Prenom_Bon()
        {
            Prenom unPrenom = new Prenom("Raphaël");

            string actuel = unPrenom.HelloPrenom();

            Assert.AreEqual("Hello Raphaël", actuel);
        }
    }
}
