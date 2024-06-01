internal static class StringReverseExtension
{
    public static string ReverseString(this string str)
    {
        string reversedStr = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr += str[i];
        }
        return reversedStr;
    }
}