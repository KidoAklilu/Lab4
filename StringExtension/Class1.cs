namespace StringExtensions
{
    public static class StringHelper
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}
