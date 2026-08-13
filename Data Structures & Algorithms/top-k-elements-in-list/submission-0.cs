public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count the frequency of each number
        foreach (int n in nums)
        {
            if (frequencyMap.ContainsKey(n))
            {
                frequencyMap[n]++;
            }
            else
            {
                frequencyMap[n] = 1;
            }
        }

        // buckets[i] holds every number that appeared exactly i times
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach (var pair in frequencyMap)
        {
            buckets[pair.Value].Add(pair.Key);
        }

        // Walk backwards from the highest count until we've collected k
        List<int> result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            foreach (int num in buckets[i])
            {
                result.Add(num);
                if (result.Count == k) break;
            }
        }

        return result.ToArray();
    }
}
