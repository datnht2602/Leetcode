namespace LeetCodeTests.FindNumberNotContains5;

public class NumberProcessor
{
    public List<int> FindNumbersNotEndingInFive(int start, int end)
    {
        if (start > end)
        {
            (start, end) = (end, start);
        }
        List<int> result = [];
        for (int i = start; i <= end; i++)
        {
            // Check if the number ends with 5.
            if (i % 10 != 5 && i % 10 != -5)
            {
                result.Add(i);
            }
        }

        return result;
    }
}