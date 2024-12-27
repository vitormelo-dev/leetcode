public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashset = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hashset.Contains(num))
            {
                return true;
            } 
            else
            {
                hashset.Add(num);
            }
        }

        return false;
    }
}