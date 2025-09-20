namespace LeetCodeTests.ReverseVowelsOfAString;

public class ReverseVowelsOfAStringTests
{
    [Theory]
    [InlineData("IceCream")]
    public void ReverseVowels(string s) {
        List<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        int left = 0;
        int right = s.Length - 1;
        foreach (var c in s)
        {
        }
        
        //Assert.Equal("AceCreIm" ,result);
    }
}