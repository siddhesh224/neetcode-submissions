public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            var count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!groups.TryGetValue(key, out var bucket)) {
                bucket = new List<string>();
                groups[key] = bucket;
            }
            bucket.Add(s);
        }

        return groups.Values.ToList();
    }
}
