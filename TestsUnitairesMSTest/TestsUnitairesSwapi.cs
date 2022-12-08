using LibrarieTestUnitaires;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestsUnitairesMSTest
{
    [TestClass]
    public class TestsUnitairesSwapi
    {
        [TestMethod]
        public void Nombre_de_Film()
        {
            Swapi unSwapi = new Swapi();
            unSwapi.AvoirFilmsAvecLuke();

            Assert.AreEqual(4, unSwapi.Films.Count);
        }

        [TestMethod]
        public void Nom_des_Film()
        {
            Swapi unSwapi = new Swapi();
            unSwapi.AvoirFilmsAvecLuke();
            List<string> actuel = new List<string>();
            actuel.Add("A New Hope");
            actuel.Add("The Empire Strikes Back");
            actuel.Add("Return of the Jedi");
            actuel.Add("Revenge of the Sith");

            CollectionAssert.AreEqual(unSwapi.Films, actuel);
        }
    }
}
