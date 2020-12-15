using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.Model;

namespace domainTest
{
    [TestClass]
    public class LejemaalUnitTest
    {
        //test til at tjekke om metoden fanger en for lang addresse
        [TestMethod]
        public void ValidateAdresse_StringToLong_Paas()
        {
            // Arrange
            Lejemaal lejemaal = new Lejemaal();
            string adresse = "StringIsToLongToPaas";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }

        //test til at tjekke om metoden fanger en for kort addresse
        [TestMethod]
        public void ValidateAdresse_StringIsToShort_Paas()
        {
            // Arrange
            Lejemaal lejemaal = new Lejemaal();
            string adresse = "h";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }

        //test til at tjekke om metoden fanger en adresse med specielle tegn
        [TestMethod]
        public void ValidateAdresse_StringContainsSpecialChars_Pass()
        {
            // Arrange
            Lejemaal lejemaal = new Lejemaal();
            string adresse = "Vimmersvej/";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }
    }
}