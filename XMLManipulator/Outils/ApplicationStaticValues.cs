using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLManipulator.Outils
{
    public class ApplicationStaticValues
    {
        public const string LastOpenedFilePath = "LastOpenedFilePath";
        public static string FileNameArgs = string.Empty;
        public static string XmlPattern = Path.Combine(Environment.CurrentDirectory, ConfigurationManager.AppSettings["FileNamePattern"]);
        public static XmlDocument XmlDocumentPattern;

    }
}
