using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
  public static class StringHelper
  {
  /// <summary>
    /// génére une Url Valide
    /// </summary>
    /// <param name="urls"></param>
    /// <returns></returns>
    public static string GetValidUrl(params string[] urls)
    {
      string validUrl = string.Empty;
      foreach (var url in urls)
      {
        validUrl += url.StartsWith("/") ? url.Remove(0, 1) : url;
        if (!validUrl.EndsWith("/"))
          validUrl += "/";
      }
      return validUrl;
    }
  }
}
