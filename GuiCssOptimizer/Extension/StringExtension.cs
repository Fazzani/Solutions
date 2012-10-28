using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
  public static class StringExtension
  {
    /// <summary>
    /// Removes the diacritics and white space
    /// </summary>
    /// <param name="s">The s.</param>
    /// <returns></returns>
    public static String RemoveDiacriticsAndWhiteSpace(this string s)
    {
      try
      {
        String normalizedString = s.Normalize(NormalizationForm.FormD);
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < normalizedString.Length; i++)
        {
          Char c = normalizedString[i];

          if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
          {
            if (c == ',' || c == '/' || c == '%' || !Char.IsLetter(c))
              continue;

            stringBuilder.Append(c);
          }
        }

        return stringBuilder.ToString().Trim().ToLowerInvariant();
      }
      catch (Exception)
      {
        return s;
      }
    }

    /// <summary>
    /// Convert Url To FileName Css
    /// </summary>
    /// <param name="inputText"></param>
    /// <returns></returns>
    public static string ConvertUrlToFileNameCss(string inputText)
    {
      return string.IsNullOrEmpty(inputText) ? string.Empty : inputText.RemoveDiacriticsAndWhiteSpace() + ".css";
    }

  }
}
