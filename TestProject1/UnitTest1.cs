namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = ConsoleApp1.Program.Add(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
