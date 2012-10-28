using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CssOptimizer
{
  public class AnalyseSite
  {
    public static void Analyse(string url, string pattern = "*.css", int profondeur = 3)
    {
      HtmlDocument document = new HtmlWeb().Load(url);
      IEnumerable<HtmlNode> htmlNodeCollection = (document.DocumentNode.SelectNodes("//a").Cast<HtmlNode>()).Where(x => x.Attributes["href"] != null).ToList();
    }
  }
}
