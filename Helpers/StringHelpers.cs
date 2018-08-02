using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Helpers
{
    public static class StringExtensions
    {
        public static String RemoveDiacritics(this String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        public static String UrlFriendLy(this String s)
        {
            var RemoveAccetString = s.RemoveDiacritics();
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{1,}", options);
            return regex.Replace(RemoveAccetString, "-");
        }
    }
}
