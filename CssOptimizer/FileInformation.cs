using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CssOptimizer
{
  public class FileInformation : NotifyProperyChangedBase
  {
    private string _name;
    private int _avancementPercent;
    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get { return _name; }
      set
      {
        if (this.CheckPropertyChanged<string>("Name", ref _name, ref value))
          this.FirePropertyChanged("Name");
      }
    }
    /// <summary>
    /// 
    /// </summary>
    public int AvancementPercent
    {
      get { return _avancementPercent; }
      set
      {
        if (this.CheckPropertyChanged<int>("AvancementPercent", ref _avancementPercent, ref value))
          this.FirePropertyChanged("AvancementPercent");
      }
    }
  }
}
