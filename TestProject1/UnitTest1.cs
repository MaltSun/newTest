using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var calculator = new CalculatorMethod();

            // Act
            int result = calculator.Add(3, 5);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ShouldReturnNegativeSum_WhenAddingNegativeNumbers()
        {
            // Arrange
            var calculator = new CalculatorMethod();

            // Act
            int result = calculator.Add(-3, -5);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_ShouldReturnZero_WhenAddingZero()
        {
            // Arrange
            var calculator = new CalculatorMethod();

            // Act
            int result = calculator.Add(0, 5);

            // Assert
            Assert.Equal(5, result);
        }
    }
}