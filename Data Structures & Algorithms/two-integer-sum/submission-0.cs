public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        if(nums.Length == 2) return [0,1];
        Dictionary<int, int> numsDict = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++)
        {
            int resultInt = target - nums[i];
            if (numsDict.TryGetValue(resultInt, out int index))
            {
                return [index, i];
            }
            else
            {
                numsDict.Add(nums[i], i);
            }
        }
        return [0,0];
    }
}
