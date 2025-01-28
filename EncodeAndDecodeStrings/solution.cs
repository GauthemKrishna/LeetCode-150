public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "";
        List<int> sizes = new List<int>();
        string res = "";
        foreach (string s in strs) {
            sizes.Add(s.Length);
        }
        foreach (int sz in sizes) {
            res += sz.ToString() + ',';
        }
        res += '#';
        foreach (string s in strs) {
            res += s;
        }
        return res;
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) {
            return new List<string>();
        }
        List<int> sizes = new List<int>();
        List<string> res = new List<string>();
        int i = 0;
        while (s[i] != '#') {
            string cur = "";
            while (s[i] != ',') {
                cur += s[i];
                i++;
            }
            sizes.Add(int.Parse(cur));
            i++;
        }
        i++;
        foreach (int sz in sizes) {
            res.Add(s.Substring(i, sz));
            i += sz;
        }
        return res;
    }
} // space o(n)

public class Solution {
    public string Encode(IList<string> strs) {
        string res = "";
        foreach (string s in strs) {
            res += s.Length + "#" + s;
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + length;
            res.Add(s.Substring(i, length));
            i = j;
        }
        return res;
    }
} // spave O(1)