using System;
using System.Collections.Generic;
using System.Text;

public static class StringExtension
{
    public static bool IsPalindrome(this string str)
    {
        if (str == null || str == "")
        {
            return false;
        }
        StringBuilder sb = new StringBuilder("");
        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }
        string result = sb.ToString().ToUpper();
        bool flag = true;
        for (int i = 0; i < result.Length / 2; i++)
        {
            if (result[i] != result[result.Length - 1 - i])
            {
                flag = false; break;
            }
        }
        return flag;
    }
}