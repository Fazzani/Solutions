using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class DIMENSION_NODE
  {

    private DIMENSION_NODEDVAL_ID dVAL_IDField;

    private string sYNField;

    private DIMENSION_NODEMAGASIN[] mAGASINSField;

    private string tXTWELCOMEBYCATField;

    private DIMENSION_NODEDIMENSION_NODE[] dIMENSION_NODE1Field;

    /// <remarks/>
    public DIMENSION_NODEDVAL_ID DVAL_ID
    {
      get
      {
        return this.dVAL_IDField;
      }
      set
      {
        this.dVAL_IDField = value;
      }
    }

    /// <remarks/>
    public string SYN
    {
      get
      {
        return this.sYNField;
      }
      set
      {
        this.sYNField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MAGASIN", IsNullable = false)]
    public DIMENSION_NODEMAGASIN[] MAGASINS
    {
      get
      {
        return this.mAGASINSField;
      }
      set
      {
        this.mAGASINSField = value;
      }
    }

    /// <remarks/>
    public string TXTWELCOMEBYCAT
    {
      get
      {
        return this.tXTWELCOMEBYCATField;
      }
      set
      {
        this.tXTWELCOMEBYCATField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DIMENSION_NODE")]
    public DIMENSION_NODEDIMENSION_NODE[] DIMENSION_NODE1
    {
      get
      {
        return this.dIMENSION_NODE1Field;
      }
      set
      {
        this.dIMENSION_NODE1Field = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDVAL_ID
  {

    private uint idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEMAGASIN
  {

    private string tITLEField;

    private string uRL_LOGO_OFFField;

    private string uRL_LOGO_ONField;

    private byte pOSITIONField;

    private string lINKField;

    /// <remarks/>
    public string TITLE
    {
      get
      {
        return this.tITLEField;
      }
      set
      {
        this.tITLEField = value;
      }
    }

    /// <remarks/>
    public string URL_LOGO_OFF
    {
      get
      {
        return this.uRL_LOGO_OFFField;
      }
      set
      {
        this.uRL_LOGO_OFFField = value;
      }
    }

    /// <remarks/>
    public string URL_LOGO_ON
    {
      get
      {
        return this.uRL_LOGO_ONField;
      }
      set
      {
        this.uRL_LOGO_ONField = value;
      }
    }

    /// <remarks/>
    public byte POSITION
    {
      get
      {
        return this.pOSITIONField;
      }
      set
      {
        this.pOSITIONField = value;
      }
    }

    /// <remarks/>
    public string LINK
    {
      get
      {
        return this.lINKField;
      }
      set
      {
        this.lINKField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODE
  {

    private object[] itemsField;

    private ItemsChoiceType2[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AFFICHAGE", typeof(DIMENSION_NODEDIMENSION_NODEAFFICHAGE))]
    [System.Xml.Serialization.XmlElementAttribute("BonPlan", typeof(DIMENSION_NODEDIMENSION_NODEBonPlan))]
    [System.Xml.Serialization.XmlElementAttribute("DIMENSION_NODE", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODE))]
    [System.Xml.Serialization.XmlElementAttribute("DVAL_ID", typeof(DIMENSION_NODEDIMENSION_NODEDVAL_ID))]
    [System.Xml.Serialization.XmlElementAttribute("FIRSTMENULINK", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("MAGASINS", typeof(DIMENSION_NODEDIMENSION_NODEMAGASINS))]
    [System.Xml.Serialization.XmlElementAttribute("MENUCSSCLASS", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("MENUPOSITION", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("POSITION", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("PROMOLISTCSS", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PROMOLISTDISPLAYORDER", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("PROMOLISTNBPROMOS", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("SYN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TITLEPAGE", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TOPMARQUES", typeof(DIMENSION_NODEDIMENSION_NODETOPMARQUES))]
    [System.Xml.Serialization.XmlElementAttribute("TOPRECHERCHE", typeof(DIMENSION_NODEDIMENSION_NODETOPRECHERCHE))]
    [System.Xml.Serialization.XmlElementAttribute("TXTWELCOMEBYCAT", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("XITI", typeof(DIMENSION_NODEDIMENSION_NODEXITI))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType2[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEAFFICHAGE
  {

    private bool bONPLANField;

    private bool hOMEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool BONPLAN
    {
      get
      {
        return this.bONPLANField;
      }
      set
      {
        this.bONPLANField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool HOME
    {
      get
      {
        return this.hOMEField;
      }
      set
      {
        this.hOMEField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEBonPlan
  {

    private bool displayField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool display
    {
      get
      {
        return this.displayField;
      }
      set
      {
        this.displayField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODE
  {

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DIMENSION_NODE", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODE))]
    [System.Xml.Serialization.XmlElementAttribute("DVAL_ID", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDVAL_ID))]
    [System.Xml.Serialization.XmlElementAttribute("SYN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TITLEPAGE", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("XITI", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEXITI))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODE
  {

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DVAL_ID", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDVAL_ID))]
    [System.Xml.Serialization.XmlElementAttribute("SYN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TITLEPAGE", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("XITI", typeof(DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODEXITI))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDVAL_ID
  {

    private uint idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDIMENSION_NODEXITI
  {

    private string niveau2Field;

    private byte resIdField;

    private byte shpIdField;

    private byte classIdField;

    private byte premIdField;

    private byte comparIdField;

    private byte expDetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Niveau2
    {
      get
      {
        return this.niveau2Field;
      }
      set
      {
        this.niveau2Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ResId
    {
      get
      {
        return this.resIdField;
      }
      set
      {
        this.resIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ShpId
    {
      get
      {
        return this.shpIdField;
      }
      set
      {
        this.shpIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ClassId
    {
      get
      {
        return this.classIdField;
      }
      set
      {
        this.classIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte PremId
    {
      get
      {
        return this.premIdField;
      }
      set
      {
        this.premIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ComparId
    {
      get
      {
        return this.comparIdField;
      }
      set
      {
        this.comparIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ExpDet
    {
      get
      {
        return this.expDetField;
      }
      set
      {
        this.expDetField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType
  {

    /// <remarks/>
    DVAL_ID,

    /// <remarks/>
    SYN,

    /// <remarks/>
    TITLEPAGE,

    /// <remarks/>
    XITI,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEDVAL_ID
  {

    private uint idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDIMENSION_NODEXITI
  {

    private string niveau2Field;

    private byte resIdField;

    private string shpIdField;

    private byte classIdField;

    private byte premIdField;

    private byte comparIdField;

    private bool comparIdFieldSpecified;

    private byte expDetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Niveau2
    {
      get
      {
        return this.niveau2Field;
      }
      set
      {
        this.niveau2Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ResId
    {
      get
      {
        return this.resIdField;
      }
      set
      {
        this.resIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ShpId
    {
      get
      {
        return this.shpIdField;
      }
      set
      {
        this.shpIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ClassId
    {
      get
      {
        return this.classIdField;
      }
      set
      {
        this.classIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte PremId
    {
      get
      {
        return this.premIdField;
      }
      set
      {
        this.premIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ComparId
    {
      get
      {
        return this.comparIdField;
      }
      set
      {
        this.comparIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ComparIdSpecified
    {
      get
      {
        return this.comparIdFieldSpecified;
      }
      set
      {
        this.comparIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ExpDet
    {
      get
      {
        return this.expDetField;
      }
      set
      {
        this.expDetField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType1
  {

    /// <remarks/>
    DIMENSION_NODE,

    /// <remarks/>
    DVAL_ID,

    /// <remarks/>
    SYN,

    /// <remarks/>
    TITLEPAGE,

    /// <remarks/>
    XITI,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEDVAL_ID
  {

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEMAGASINS
  {

    private DIMENSION_NODEDIMENSION_NODEMAGASINSMAGASIN[] mAGASINField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MAGASIN")]
    public DIMENSION_NODEDIMENSION_NODEMAGASINSMAGASIN[] MAGASIN
    {
      get
      {
        return this.mAGASINField;
      }
      set
      {
        this.mAGASINField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEMAGASINSMAGASIN
  {

    private string tITLEField;

    private string uRL_LOGO_OFFField;

    private string uRL_LOGO_ONField;

    private byte pOSITIONField;

    private string lINKField;

    /// <remarks/>
    public string TITLE
    {
      get
      {
        return this.tITLEField;
      }
      set
      {
        this.tITLEField = value;
      }
    }

    /// <remarks/>
    public string URL_LOGO_OFF
    {
      get
      {
        return this.uRL_LOGO_OFFField;
      }
      set
      {
        this.uRL_LOGO_OFFField = value;
      }
    }

    /// <remarks/>
    public string URL_LOGO_ON
    {
      get
      {
        return this.uRL_LOGO_ONField;
      }
      set
      {
        this.uRL_LOGO_ONField = value;
      }
    }

    /// <remarks/>
    public byte POSITION
    {
      get
      {
        return this.pOSITIONField;
      }
      set
      {
        this.pOSITIONField = value;
      }
    }

    /// <remarks/>
    public string LINK
    {
      get
      {
        return this.lINKField;
      }
      set
      {
        this.lINKField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODETOPMARQUES
  {

    private DIMENSION_NODEDIMENSION_NODETOPMARQUESMARQUE[] mARQUEField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MARQUE")]
    public DIMENSION_NODEDIMENSION_NODETOPMARQUESMARQUE[] MARQUE
    {
      get
      {
        return this.mARQUEField;
      }
      set
      {
        this.mARQUEField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODETOPMARQUESMARQUE
  {

    private byte positionField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Position
    {
      get
      {
        return this.positionField;
      }
      set
      {
        this.positionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODETOPRECHERCHE
  {

    private DIMENSION_NODEDIMENSION_NODETOPRECHERCHEELEMENT[] eLEMENTField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ELEMENT")]
    public DIMENSION_NODEDIMENSION_NODETOPRECHERCHEELEMENT[] ELEMENT
    {
      get
      {
        return this.eLEMENTField;
      }
      set
      {
        this.eLEMENTField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODETOPRECHERCHEELEMENT
  {

    private byte pOSITIONField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte POSITION
    {
      get
      {
        return this.pOSITIONField;
      }
      set
      {
        this.pOSITIONField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class DIMENSION_NODEDIMENSION_NODEXITI
  {

    private string niveau2Field;

    private byte resIdField;

    private bool resIdFieldSpecified;

    private byte shpIdField;

    private bool shpIdFieldSpecified;

    private byte classIdField;

    private bool classIdFieldSpecified;

    private byte premIdField;

    private bool premIdFieldSpecified;

    private byte comparIdField;

    private bool comparIdFieldSpecified;

    private byte expDetField;

    private bool expDetFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Niveau2
    {
      get
      {
        return this.niveau2Field;
      }
      set
      {
        this.niveau2Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ResId
    {
      get
      {
        return this.resIdField;
      }
      set
      {
        this.resIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ResIdSpecified
    {
      get
      {
        return this.resIdFieldSpecified;
      }
      set
      {
        this.resIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ShpId
    {
      get
      {
        return this.shpIdField;
      }
      set
      {
        this.shpIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ShpIdSpecified
    {
      get
      {
        return this.shpIdFieldSpecified;
      }
      set
      {
        this.shpIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ClassId
    {
      get
      {
        return this.classIdField;
      }
      set
      {
        this.classIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ClassIdSpecified
    {
      get
      {
        return this.classIdFieldSpecified;
      }
      set
      {
        this.classIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte PremId
    {
      get
      {
        return this.premIdField;
      }
      set
      {
        this.premIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PremIdSpecified
    {
      get
      {
        return this.premIdFieldSpecified;
      }
      set
      {
        this.premIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ComparId
    {
      get
      {
        return this.comparIdField;
      }
      set
      {
        this.comparIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ComparIdSpecified
    {
      get
      {
        return this.comparIdFieldSpecified;
      }
      set
      {
        this.comparIdFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ExpDet
    {
      get
      {
        return this.expDetField;
      }
      set
      {
        this.expDetField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExpDetSpecified
    {
      get
      {
        return this.expDetFieldSpecified;
      }
      set
      {
        this.expDetFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType2
  {

    /// <remarks/>
    AFFICHAGE,

    /// <remarks/>
    BonPlan,

    /// <remarks/>
    DIMENSION_NODE,

    /// <remarks/>
    DVAL_ID,

    /// <remarks/>
    FIRSTMENULINK,

    /// <remarks/>
    MAGASINS,

    /// <remarks/>
    MENUCSSCLASS,

    /// <remarks/>
    MENUPOSITION,

    /// <remarks/>
    POSITION,

    /// <remarks/>
    PROMOLISTCSS,

    /// <remarks/>
    PROMOLISTDISPLAYORDER,

    /// <remarks/>
    PROMOLISTNBPROMOS,

    /// <remarks/>
    SYN,

    /// <remarks/>
    TITLEPAGE,

    /// <remarks/>
    TOPMARQUES,

    /// <remarks/>
    TOPRECHERCHE,

    /// <remarks/>
    TXTWELCOMEBYCAT,

    /// <remarks/>
    XITI,
  }

}
