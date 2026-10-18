public class Solution {
    public int expand(int start,int end,string s){
        int ln=s.Length;
        while(start>=0 && end<ln && s[start]==s[end]){
            start--;
            end++;
        }
        return end-start-1;
    }
    public string LongestPalindrome(string s) {
        int ln=s.Length;
        string ans="";
        for(int i=0;i<ln;i++){
            int odd=expand(i,i,s);
            int even=expand(i,i+1,s);
             if (ans.Length < odd) {
                ans = s.Substring(i - (odd - 1) / 2, odd); 
            }
            if (ans.Length < even) {
                ans = s.Substring(i - (even - 2) / 2, even); 
            }
        }
        return ans;
    }
}