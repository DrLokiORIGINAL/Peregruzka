using Microsoft.VisualStudio.TestTools.UnitTesting;
using Peregruzka;
namespace TestPer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Distxy()
        {
            // Arrange
            int x = 2;
            int y = 2;
            int z = 2;
            int t = 2;
            int expected = 8;
          Decart Decart = new Decart(x,y,z,t);

            // Act
            Decart.distance(x, y);

            // Assert
            double actual = Decart.distance(x, y);
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Distxyz()
        {
            // Arrange
            int x = 2;
            int y = 2;
            int z = 2;
            int t = 2;
            int expected = 12;
            Decart Decart = new Decart(x, y, z, t);

            // Act
            Decart.distance(x, y,z);

            // Assert
            double actual = Decart.distance(x, y,z);
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Distxyzt()
        {
            // Arrange
            int x = 2;
            int y = 2;
            int z = 2;
            int t = 2;
            int expected = 16;
            Decart Decart = new Decart(x, y, z, t);

            // Act
            Decart.distance(x, y, z, t);

            // Assert
            double actual = Decart.distance(x, y, z, t);
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
