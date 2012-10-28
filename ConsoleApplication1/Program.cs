using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Lbp.Domain.Framework;

namespace ConsoleApplication1
{
  class Program
  {
    public static void Main()
    {
      // Read a purchase order.
      DeserializeObject("GlobalConfiguration.xml");
    }
    private static void DeserializeObject(string filename)
    {
      Console.WriteLine("Reading with TextReader");
      // Create an instance of the XmlSerializer specifying type.
      XmlSerializer serializer = new XmlSerializer(typeof(GlobalConfiguration));

      // Create a TextReader to read the file. 
      FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
      fs.Flush();
      XmlTextReader reader = new XmlTextReader(fs);
      // Use the Deserialize method to restore the object's state.
      GlobalConfiguration i = (GlobalConfiguration)serializer.Deserialize(reader);
     i.Categorie.FirstOrDefault().Categorie
      // Write out the properties of the object.
      Console.Write(i.Title);
      Console.ReadKey();
    }
  }
}
