public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> ResultDictS = new Dictionary<char, int>();
        Dictionary<char, int> ResultDictT = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if(ResultDictS.ContainsKey(c))
                ResultDictS[c] ++;
            else
                ResultDictS.Add(c, 1);
        }

        foreach(char c in t)
        {
            if(ResultDictT.ContainsKey(c))
                ResultDictT[c] ++;
            else
                ResultDictT.Add(c, 1);
        }
        return AreSame(ResultDictS, ResultDictT);
    }

    static bool AreSame<TKey, TValue>(Dictionary<TKey, TValue> a, Dictionary<TKey, TValue> b)
    {
        if (a.Count != b.Count) return false;

        foreach (var kv in a)
        {
            if (!b.TryGetValue(kv.Key, out var value)) return false;   // key missing
            if (!EqualityComparer<TValue>.Default.Equals(kv.Value, value)) return false; // value differs
        }
        return true;
    }
}
