namespace LeetCodeTests.ReverseVowelsOfAString;

public class ReverseVowelsOfAStringTests
{
    [Theory]
    [InlineData("IceCreAm", "AceCreIm")]
    [InlineData("leetcode", "leotcede")]
    public void ReverseVowels(string s, string expectedResult)
    {
        List<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        int left = 0;
        int right = s.Length - 1;
        var listChars = s.ToCharArray();
        while (left < right)
        {
            if (!vowels.Contains(listChars[left]))
            {
                left++;
                continue;
            }
            if (!vowels.Contains(listChars[right]))
            {
                right--;
                continue;
            }
            char temp = listChars[left];
            listChars[left] = listChars[right];
            listChars[right] = temp;
            left++;
            right--;
        }
        Assert.Equal(expectedResult, new string(listChars));
    }
}