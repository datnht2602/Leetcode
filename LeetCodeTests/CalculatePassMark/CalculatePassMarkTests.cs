namespace LeetCodeTests.CalculatePassMark;

public class CalculatePassMarkTests
{
    
    [Fact]
    public void PassMark()
    {
        //Arrange
        string s = "PPAP";
        //Act
        int result = CalculateScore(s);
        //Assert
        Assert.Equal(3, result);
    }
    
    /// <summary>
    /// Calculates the attendance score based on the given string.
    /// </summary>
    /// <param name="attendance">A string representing attendance ('P' for present, 'A' for absent).</param>
    /// <returns>The calculated attendance score.</returns>
    static int CalculateScore(string attendance)
    {
        int score = 0;
        int consecutivePresent = 0;
        int consecutiveAbsent = 0;

        for (int i = 0; i < attendance.Length; i++)
        {
            char status = attendance[i];

            if (status == 'P')
            {
                score += 1;
                consecutivePresent++;
                consecutiveAbsent = 0; // Reset consecutive absent counter

                if (consecutivePresent > 1)
                {
                    score += 1; // Add extra point for consecutive present days
                }
            }
            else if (status == 'A')
            {
                score -= 1;
                consecutiveAbsent++;
                consecutivePresent = 0; // Reset consecutive present counter

                if (consecutiveAbsent > 1)
                {
                    score -= 1; // Deduct extra point for consecutive absent days
                }
            }
        }
        return score;
    }
}