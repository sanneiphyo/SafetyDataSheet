using System.Text.RegularExpressions;

namespace SDS.Helper
{
    public class Functions
    {
        public static string RemoveHtmlTags(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Regular expression to match HTML tags
            return Regex.Replace(input, "<[^>]*>", string.Empty, RegexOptions.IgnoreCase);
        }
    }
}