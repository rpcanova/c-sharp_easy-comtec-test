public class Solution {
    public bool DetectCapitalUse(string word) {
        return word.All(char.IsUpper) || word.All(char.IsLower) ||
        (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower));
    }
}