using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Diagnostics;
using CssOptimizer;

namespace DebugApplication2
{
  /* --------------------------------RESTE A FAIRE
     * 
     * Détecter les doublons entre les différents fichiers
     * Compresser et optimiser(cssTidy) le fichier généré 
     * //csstidy.exe site.css --template=hight site.css
     * Traitement par Task
     * Créer une interface GUI
     * Générer un fichier par page et proposer un shared File by site
     --------------------------------------------*/
  class Program
  {
    const string Base_URI = @"http://localhost:1626";

    static void Main(string[] args)
    {
      //Console.WriteLine(string.Format("Start treatment url {0} at {1}", Base_URI, DateTime.Now));
      //CssOptimizer.CssOptimizer.OptimizeSite(new CssOptimizerModel { BaseUrl = Base_URI });
      //Console.WriteLine(string.Format("The end of Treatment : at {0}", DateTime.Now));
      CssOptimizer.CssOptimizer.CssTidy("pathFile");
      Console.ReadKey();
    }
  }
}
