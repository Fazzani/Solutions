using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CssOptimizer
{
  /// <summary>
  /// CssOptimizer Model
  /// </summary>
  public class CssOptimizerModel : NotifyProperyChangedBase
  {
    private string _pathGeneratedSharedFile = @"commun.css";
    private bool _isGenerateCommunFile = false;
    private bool _isCompressFile = false;
    private bool _isOrgonizeFile = false;
    private bool _isDeleteComment = false;
    private int _progessBarEtat = 0;
    private long _globalLength = 0;
    private long _ratioOfCompression = 0;

    private CssTidyOptimizeQuality _compressQuality = CssTidyOptimizeQuality.highest;

    //private string _baseUrl = "http://localhost:1626";
    private ObservableCollection<Url> _listUrl;
    private ObservableCollection<FileInformation> _listCssFiles = new ObservableCollection<FileInformation>();

    ///// <summary>
    ///// Path of Generated File
    ///// </summary>
    //public string PathGeneratedFile
    //{
    //  get { return _pathGeneratedFile; }
    //  set
    //  {
    //    if (this.CheckPropertyChanged<string>("PathGeneratedFile", ref _pathGeneratedFile, ref value))
    //      this.FirePropertyChanged("PathGeneratedFile");
    //  }
    //}

    /// <summary>
    /// Is Generate Commun File
    /// </summary>
    public bool IsGenerateCommunFile
    {
      get { return _isGenerateCommunFile; }
      set
      {
        if (this.CheckPropertyChanged<bool>("IsGenerateCommunFile", ref _isGenerateCommunFile, ref value))
          this.FirePropertyChanged("IsGenerateCommunFile");
      }
    }

    /// <summary>
    /// Compresser le fichier généré
    /// </summary>
    public bool IsCompressFile
    {
      get { return _isCompressFile; }
      set
      {
        if (this.CheckPropertyChanged<bool>("IsCompressFile", ref _isCompressFile, ref value))
          this.FirePropertyChanged("IsCompressFile");
      }
    }

    /// <summary>
    /// organiser le fichiers généré via CssTidy
    /// </summary>
    public bool IsOrgonizeFile
    {
      get { return _isOrgonizeFile; }
      set
      {
        if (this.CheckPropertyChanged<bool>("IsOrgonizeFile", ref _isOrgonizeFile, ref value))
          this.FirePropertyChanged("IsOrgonizeFile");
      }
    }

    /// <summary>
    /// Supprimer les commentaires
    /// </summary>
    public bool IsDeleteComment
    {
      get { return _isDeleteComment; }
      set
      {
        if (this.CheckPropertyChanged<bool>("IsDeleteComment", ref _isDeleteComment, ref value))
          this.FirePropertyChanged("IsDeleteComment");
      }
    }


    /// <summary>
    /// List des fichiers à traiter
    /// </summary>
    public ObservableCollection<FileInformation> ListCssFiles
    {
      get { return _listCssFiles; }
      set
      {
        if (this.CheckPropertyChanged<ObservableCollection<FileInformation>>("ListCssFiles", ref _listCssFiles, ref value))
          this.FirePropertyChanged("ListCssFiles");
      }
    }

    /// <summary>
    /// List des fichiers à traiter
    /// </summary>
    public CssTidyOptimizeQuality CompressQuality
    {
      get { return _compressQuality; }
      set
      {
        if (this.CheckPropertyChanged<CssTidyOptimizeQuality>("CompressQuality", ref _compressQuality, ref value))
          this.FirePropertyChanged("CompressQuality");
      }
    }

    public IEnumerable<CssTidyOptimizeQuality> CssTidyOptimizeQualityEnum
    {
      get
      {
        return Enum.GetValues(typeof(CssTidyOptimizeQuality)).Cast<CssTidyOptimizeQuality>();
      }
    }


    /// <summary>
    /// Is Generate Commun File
    /// </summary>
    public int ProgessBarEtat
    {
      get { return _progessBarEtat; }
      set
      {
        if (this.CheckPropertyChanged<int>("ProgessBarEtat", ref _progessBarEtat, ref value))
          this.FirePropertyChanged("ProgessBarEtat");
      }
    }

    /// <summary>
    /// Global Length of old's Files
    /// </summary>
    public long GlobalLength
    {
      get { return _globalLength; }
      set
      {
        if (this.CheckPropertyChanged<long>("GlobalLength", ref _globalLength, ref value))
          this.FirePropertyChanged("GlobalLength");
      }
    }

    /// <summary>
    /// Is Generate Commun File
    /// </summary>
    public long RatioOfCompression
    {
      get { return _ratioOfCompression; }
      set
      {
        if (this.CheckPropertyChanged<long>("RatioOfCompression", ref _ratioOfCompression, ref value))
          this.FirePropertyChanged("RatioOfCompression");
      }
    }

    /// <summary>
    /// Liste des Url's à traiter
    /// </summary>
    public ObservableCollection<Url> ListUrl
    {
      get { return _listUrl; }
      set
      {
        if (this.CheckPropertyChanged<ObservableCollection<Url>>("ListUrl", ref _listUrl, ref value))
          this.FirePropertyChanged("ListUrl");
      }
    }

    public string PathGeneratedSharedFile
    {
      get { return _pathGeneratedSharedFile; }
      set
      {
        if (this.CheckPropertyChanged<string>("PathGeneratedSharedFile", ref _pathGeneratedSharedFile, ref value))
          this.FirePropertyChanged("PathGeneratedSharedFile");
      }
    }

  }

  /// <summary>
  /// CssTidy Optimize Quality
  /// </summary>
  public enum CssTidyOptimizeQuality
  {
    low,
    hight,
    highest
  }

  public class Url : NotifyProperyChangedBase
  {
    public Url(string path, string fileName)
    {
      _path = path;
      _fileName = fileName;
    }

    string _path;

    public string Path
    {
      get { return _path; }
      set
      {
        if (this.CheckPropertyChanged<string>("Path", ref _path, ref value))
          this.FirePropertyChanged("Path");
      }
    }

    string _fileName;

    public string FileName
    {
      get { return _fileName; }
      set
      {
        if (this.CheckPropertyChanged<string>("FileName", ref _fileName, ref value))
          this.FirePropertyChanged("FileName");
      }
    }
  }
}
