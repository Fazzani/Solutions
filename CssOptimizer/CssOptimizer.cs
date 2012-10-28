using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Collections.ObjectModel;
using System.Threading;

namespace CssOptimizer
{
  /* --------------------------------RESTE A FAIRE
     * Détecter les doublons entre les différents fichiers
     * Compresser et optimiser(cssTidy) le fichier généré 
     * //csstidy.exe site.css --template=hight site.css
     * Traitement par Task
     * Créer une interface GUI
     * Générer un fichier par page et proposer un shared File by site
     --------------------------------------------*/
  public static class CssOptimizer
  {
    public static event EventHandler OnTreatmentComplete;
    private static IDictionary<string, HtmlDocument> _listDocument;
    public static void OptimizeSite(CssOptimizerModel model, SynchronizationContext current = null)
    {
      _listDocument = new Dictionary<string, HtmlDocument>();
      foreach (Url url in model.ListUrl)
        _listDocument.Add(url.FileName, new HtmlWeb().Load(url.Path));

      foreach (var document in _listDocument)
      {
        Debug.WriteLine(string.Format("Start treatment url {0} at {1}", document.Key, DateTime.Now));
        IEnumerable<HtmlNode> htmlNodeCollection = (document.Value.DocumentNode.SelectNodes("//link").Cast<HtmlNode>()).Where(x => x.Attributes["href"] != null && x.Attributes["href"].Value.EndsWith(".css")).ToList();
        using (StreamWriter writer = File.CreateText(document.Key))
        {
          Parallel.ForEach(htmlNodeCollection, (link, state, index) =>
           {
             try
             {
               string filePath = link.Attributes["href"].Value;

               using (WebClient client = new WebClient())
               {
                 Debug.WriteLine(string.Format("     => Start a treatment of the file {0}", filePath.Split('/').Last()));

                 MAJListCssFile(model, current, filePath);

                 string content = client.DownloadString(StringHelper.GetValidUrl(model.ListUrl.FirstOrDefault(x => x.FileName.Equals(document.Key)).Path, filePath));
                 model.GlobalLength += content.Length;
                 var reglesCssCollection = Regex.Matches(content, @"(?<selector>(?:(?:[^,{]+),?)*?)(\{(?:(?<name>[^}:]+):?(?<value>[^};]+);?)*?\})");

                 if (reglesCssCollection != null)
                 {
                   string res = string.Empty;

                   foreach (Match match in reglesCssCollection.Cast<Match>())
                   {
                     string tmp = TraiterRule(document.Value, match, _listDocument);
                     if (!res.Contains(tmp))
                       res += tmp;
                   }
                   writer.WriteLine(res.Trim());
                 }
               }
               Debug.WriteLine(string.Format("     The end of Treatment of the file {0} at {1}", filePath.Split('/').Last(), DateTime.Now));
               ReportProgress(model, current, htmlNodeCollection.Count());
             }
             catch (Exception ex)
             {
               throw ex;
             }
           });
        }

        if (model.IsOrgonizeFile)
          CssTidy(document.Key, model.CompressQuality);
        model.RatioOfCompression = (model.GlobalLength / new FileInfo(document.Key).Length) * 100;
      }

      //Raise the event
      if (OnTreatmentComplete != null)
        OnTreatmentComplete(model, null);
      Debug.WriteLine(string.Format("The end of Treatment : at {0}", DateTime.Now));
    }

    /// <summary>
    /// Traiter Rule
    /// </summary>
    /// <param name="document"></param>
    /// <param name="writer"></param>
    /// <param name="match"></param>
    private static string TraiterRule(HtmlDocument document, Match match, IDictionary<string, HtmlDocument> listDocument)
    {
      string allUsedRules = string.Empty;
      foreach (string rule in match.Groups[2].Value.Split(','))
      {
        try
        {
          string optimRule = rule
            .Replace(":hover", string.Empty)
            .Replace(":focus", string.Empty)
            .Replace(":before", string.Empty)
            .Replace(":after", string.Empty)
            .Replace(":link", string.Empty)
            .Replace(":visited", string.Empty)
            .Replace(":active", string.Empty)
            .TrimStart()
            .TrimEnd();

          lock (document)
          {
            if (document.DocumentNode.QuerySelector(optimRule) != null)
            {
              if (!string.IsNullOrEmpty(allUsedRules))
                allUsedRules += ",";
              if (!allUsedRules.Contains(match.Groups[2].Value.Trim()))
                allUsedRules += Environment.NewLine + match.Groups[2].Value.Trim();
            }
          }
        }
        catch (Exception ex)
        {
#if DEBUG
          // Debug.WriteLine(ex.Message);
#endif
          return match.Value.Trim();
        }
      }

      //Write to File
      if (!string.IsNullOrEmpty(allUsedRules))
        return allUsedRules + match.Groups[1].Value;
      return allUsedRules;
    }

    /// <summary>
    /// Faire Progresser le ProgressBar
    /// </summary>
    /// <param name="currentIndex"></param>
    /// <param name="maxRecords"></param>
    private static void ReportProgress(CssOptimizerModel model, SynchronizationContext current, int maxRecords)
    {
      if (current != null)
        current.Send((x) =>
        {
          model.ProgessBarEtat += Convert.ToInt32((1 / (decimal)maxRecords) * 100);
        }, null);
    }

    /// <summary>
    /// MAJ List Css File
    /// </summary>heni82
    /// <param name="model"></param>
    /// <param name="current">SynchronizationContext</param>
    /// <param name="filePath"></param>
    private static void MAJListCssFile(CssOptimizerModel model, SynchronizationContext current, string filePath)
    {
      if (current != null)
        current.Send((x) =>
        {
          if (model.ListCssFiles == null)
            model.ListCssFiles = new ObservableCollection<FileInformation>();

          model.ListCssFiles.Add(new FileInformation { Name = filePath.Split('/').Last() });
        }, null);
      else
      {
        if (model.ListCssFiles == null)
          model.ListCssFiles = new ObservableCollection<FileInformation>();

        model.ListCssFiles.Add(new FileInformation { Name = filePath.Split('/').Last() });
      }
    }

    /// <summary>
    /// CssTidy
    /// </summary>
    /// <param name="pathFile"></param>
    public static void CssTidy(string pathFile, CssTidyOptimizeQuality cssTidyCompressionQuality = CssTidyOptimizeQuality.highest)
    {
      Process.Start(new ProcessStartInfo("csstidy.exe", string.Format("{0} --template={1} {0}", pathFile, Enum.GetName(typeof(CssTidyOptimizeQuality), cssTidyCompressionQuality)))).Start();
    }

    /// <summary>
    /// Générer Shared File
    /// </summary>
    /// <param name="model"></param>
    /// <param name="current"></param>
    public static void GenererSharedFile(CssOptimizerModel model, SynchronizationContext current = null)
    {
      if (_listDocument == null)
        throw new ArgumentNullException("_listDocument");

      //using (StreamWriter writer = File.CreateText(model.PathGeneratedSharedFile))
      //  foreach (var doc in _listDocument)
      //  {
      //    StreamReader streamCss = new StreamReader(doc.Value);
      //    var reglesCssCollection = Regex.Matches(streamCss.ReadToEnd(), @"(?<selector>(?:(?:[^,{]+),?)*?)(\{(?:(?<name>[^}:]+):?(?<value>[^};]+);?)*?\})");
      //    if (reglesCssCollection != null)
      //      foreach (Match match in reglesCssCollection.Cast<Match>())
      //      {
      //        string allUsedRules = string.Empty;
      //        foreach (string rule in match.Groups[2].Value.Split(','))
      //        {
      //          //il faut chercher l'occurence dans au moins un des autres fichiers
      //          writer.WriteLine(match.Value);

      //        }
      //      }
      //  }
    }
  }
}
