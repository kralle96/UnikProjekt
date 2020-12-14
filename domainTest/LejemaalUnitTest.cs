using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using domain.Model;

namespace domainTest
{
    [TestClass]
    public class LejemaalUnitTest
    {
        Lejemaal lejemaal = new Lejemaal();

        [TestMethod]
        public void ValidateAdresse_StringToLong_Paas()
        {
            // Arrange
            string adresse = "StringIsToLongToPaas";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ValidateAdresse_StringIsToShort_Paas()
        {
            // Arrange
            string adresse = "h";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ValidateAdresse_StringContainsSpecialChars_Pass()
        {
            // Arrange
            string adresse = "Vimmersvej/";

            // Act
            bool test = lejemaal.ValidateAdresse(adresse);

            // Assert
            Assert.IsFalse(test);
        }
    }
}