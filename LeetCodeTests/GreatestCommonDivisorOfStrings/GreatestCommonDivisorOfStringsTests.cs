namespace LeetCodeTests.GreatestCommonDivisorOfStrings;

public class GreatestCommonDivisorOfStringsTests
{
    [Theory]
    // [InlineData("ABCABC", "ABC", "ABC")]
    // [InlineData("ABABAB", "ABAB", "AB")]
    // [InlineData("LEET", "CODE", "")]
    [InlineData("ABABABAB", "ABAB", "ABAB")]
    public void Example1(string str1, string str2, string expected)
    {
        //Act
        if(str1.Length < str2.Length)
        {
            (str1, str2) = (str2, str1);
        }
        var result = str2;
        for(int i = 0; i < str1.Length; i += str2.Length)
        {
            var j = i;
            foreach (var charStr2 in str2)
            {
                if (str1.Length <= j)
                {
                    break;
                }
                if (str1[j] != charStr2)
                {
                    result = string.Empty;
                    break;
                };
                j++;
            }
        }
        //Assert

        var actual = str1.Length % str2.Length != 0 ? ReturnNotDuplicateChar(result) : result;
        Assert.Equal(expected, actual);
        
    }
    
    private string ReturnNotDuplicateChar(string str){

        int index = 0;
        foreach(var character in str){
            index++;
            if(str[..index] == str[^index..])
            {
                break;
            }
        }
        return str[..index];
    }
}