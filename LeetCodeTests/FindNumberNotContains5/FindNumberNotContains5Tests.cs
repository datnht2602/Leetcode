namespace LeetCodeTests.FindNumberNotContains5;

public class FindNumberNotContains5Tests
{
    [Fact]
        public void FindNumbersNotEndingInFive_StandardRange_ReturnsCorrectNumbers()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16 };

            // Act
            var actual = processor.FindNumbersNotEndingInFive(1, 16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumbersNotEndingInFive_RangeWithNoFives_ReturnsAllNumbers()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int> { 11, 12, 13, 14 };

            // Act
            var actual = processor.FindNumbersNotEndingInFive(11, 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumbersNotEndingInFive_SingleNumberRange_ReturnsNumberIfNotFive()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int> { 10 };

            // Act
            var actual = processor.FindNumbersNotEndingInFive(10, 10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumbersNotEndingInFive_SingleNumberIsFive_ReturnsEmptyList()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int>();

            // Act
            var actual = processor.FindNumbersNotEndingInFive(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumbersNotEndingInFive_ReversedRange_ReturnsCorrectNumbers()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            // Act
            var actual = processor.FindNumbersNotEndingInFive(10, 1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumbersNotEndingInFive_NegativeNumbers_ReturnsCorrectNumbers()
        {
            // Arrange
            var processor = new NumberProcessor();
            var expected = new List<int> { -10, -9, -8, -7, -6 };

            // Act
            var actual = processor.FindNumbersNotEndingInFive(-11, -5);

            // Assert
            Assert.Equal(expected, actual);
        }
}