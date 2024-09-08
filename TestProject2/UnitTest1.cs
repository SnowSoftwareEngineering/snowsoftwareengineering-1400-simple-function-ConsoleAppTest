using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = ConsoleApp1.Program.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
