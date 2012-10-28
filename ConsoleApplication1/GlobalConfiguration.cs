
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class GlobalConfiguration
{

  private GlobalConfigurationMagasin[] magasinsField;

  private string txtWelcomeByCatField;

  private GlobalConfigurationCategorie[] categorieField;

  private uint dVAL_IDField;

  private string titleField;

  /// <remarks/>
  [System.Xml.Serialization.XmlArrayItemAttribute("Magasin", IsNullable = false)]
  public GlobalConfigurationMagasin[] Magasins
  {
    get
    {
      return this.magasinsField;
    }
    set
    {
      this.magasinsField = value;
    }
  }

  /// <remarks/>
  public string TxtWelcomeByCat
  {
    get
    {
      return this.txtWelcomeByCatField;
    }
    set
    {
      this.txtWelcomeByCatField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlElementAttribute("Categorie")]
  public GlobalConfigurationCategorie[] Categorie
  {
    get
    {
      return this.categorieField;
    }
    set
    {
      this.categorieField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public uint DVAL_ID
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
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string Title
  {
    get
    {
      return this.titleField;
    }
    set
    {
      this.titleField = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationMagasin
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
public partial class GlobalConfigurationCategorie
{

  private GlobalConfigurationCategorieMenu menuField;

  private GlobalConfigurationCategorieHome homeField;

  private GlobalConfigurationCategorieBonsPlans bonsPlansField;

  private string txtWelcomeByCatField;

  private GlobalConfigurationCategorieXITI xITIField;

  private GlobalConfigurationCategorieELEMENT[] tOPRECHERCHEField;

  private GlobalConfigurationCategorieMARQUE[] tOPMARQUESField;

  private GlobalConfigurationCategorieMagasin[] magasinsField;

  private GlobalConfigurationCategorieCategorie[] categorieField;

  private string titleField;

  private uint dVAL_IDField;

  /// <remarks/>
  public GlobalConfigurationCategorieMenu Menu
  {
    get
    {
      return this.menuField;
    }
    set
    {
      this.menuField = value;
    }
  }

  /// <remarks/>
  public GlobalConfigurationCategorieHome Home
  {
    get
    {
      return this.homeField;
    }
    set
    {
      this.homeField = value;
    }
  }

  /// <remarks/>
  public GlobalConfigurationCategorieBonsPlans BonsPlans
  {
    get
    {
      return this.bonsPlansField;
    }
    set
    {
      this.bonsPlansField = value;
    }
  }

  /// <remarks/>
  public string TxtWelcomeByCat
  {
    get
    {
      return this.txtWelcomeByCatField;
    }
    set
    {
      this.txtWelcomeByCatField = value;
    }
  }

  /// <remarks/>
  public GlobalConfigurationCategorieXITI XITI
  {
    get
    {
      return this.xITIField;
    }
    set
    {
      this.xITIField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlArrayItemAttribute("ELEMENT", IsNullable = false)]
  public GlobalConfigurationCategorieELEMENT[] TOPRECHERCHE
  {
    get
    {
      return this.tOPRECHERCHEField;
    }
    set
    {
      this.tOPRECHERCHEField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlArrayItemAttribute("MARQUE", IsNullable = false)]
  public GlobalConfigurationCategorieMARQUE[] TOPMARQUES
  {
    get
    {
      return this.tOPMARQUESField;
    }
    set
    {
      this.tOPMARQUESField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlArrayItemAttribute("Magasin", IsNullable = false)]
  public GlobalConfigurationCategorieMagasin[] Magasins
  {
    get
    {
      return this.magasinsField;
    }
    set
    {
      this.magasinsField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlElementAttribute("Categorie")]
  public GlobalConfigurationCategorieCategorie[] Categorie
  {
    get
    {
      return this.categorieField;
    }
    set
    {
      this.categorieField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string Title
  {
    get
    {
      return this.titleField;
    }
    set
    {
      this.titleField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public uint DVAL_ID
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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieMenu
{

  private byte positionField;

  private string mENUCSSCLASSField;

  private string mENUPOSITIONField;

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
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string MENUCSSCLASS
  {
    get
    {
      return this.mENUCSSCLASSField;
    }
    set
    {
      this.mENUCSSCLASSField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string MENUPOSITION
  {
    get
    {
      return this.mENUPOSITIONField;
    }
    set
    {
      this.mENUPOSITIONField = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieHome
{

  private string pROMOLISTCSSField;

  private byte pROMOLISTNBPROMOSField;

  private byte pROMOLISTDISPLAYORDERField;

  private bool visibleField;

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string PROMOLISTCSS
  {
    get
    {
      return this.pROMOLISTCSSField;
    }
    set
    {
      this.pROMOLISTCSSField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public byte PROMOLISTNBPROMOS
  {
    get
    {
      return this.pROMOLISTNBPROMOSField;
    }
    set
    {
      this.pROMOLISTNBPROMOSField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public byte PROMOLISTDISPLAYORDER
  {
    get
    {
      return this.pROMOLISTDISPLAYORDERField;
    }
    set
    {
      this.pROMOLISTDISPLAYORDERField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public bool visible
  {
    get
    {
      return this.visibleField;
    }
    set
    {
      this.visibleField = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieBonsPlans
{

  private bool visibleField;

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public bool visible
  {
    get
    {
      return this.visibleField;
    }
    set
    {
      this.visibleField = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieXITI
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieELEMENT
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
public partial class GlobalConfigurationCategorieMARQUE
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
public partial class GlobalConfigurationCategorieMagasin
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
public partial class GlobalConfigurationCategorieCategorie
{

  private string tITLECategorieField;

  private GlobalConfigurationCategorieCategorieDVAL_ID dVAL_IDField;

  private string sYNField;

  private GlobalConfigurationCategorieCategorieXITI xITIField;

  private GlobalConfigurationCategorieCategorieCategorie[] categorieField;

  private string titleField;

  private uint dVAL_ID1Field;

  /// <remarks/>
  public string TITLECategorie
  {
    get
    {
      return this.tITLECategorieField;
    }
    set
    {
      this.tITLECategorieField = value;
    }
  }

  /// <remarks/>
  public GlobalConfigurationCategorieCategorieDVAL_ID DVAL_ID
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
  public GlobalConfigurationCategorieCategorieXITI XITI
  {
    get
    {
      return this.xITIField;
    }
    set
    {
      this.xITIField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlElementAttribute("Categorie")]
  public GlobalConfigurationCategorieCategorieCategorie[] Categorie
  {
    get
    {
      return this.categorieField;
    }
    set
    {
      this.categorieField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string Title
  {
    get
    {
      return this.titleField;
    }
    set
    {
      this.titleField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute("DVAL_ID")]
  public uint DVAL_ID1
  {
    get
    {
      return this.dVAL_ID1Field;
    }
    set
    {
      this.dVAL_ID1Field = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieCategorieDVAL_ID
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
public partial class GlobalConfigurationCategorieCategorieXITI
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieCategorieCategorie
{

  private GlobalConfigurationCategorieCategorieCategorieDVAL_ID dVAL_IDField;

  private string sYNField;

  private string tITLECategorieField;

  private GlobalConfigurationCategorieCategorieCategorieXITI xITIField;

  private string titleField;

  private uint dVAL_ID1Field;

  /// <remarks/>
  public GlobalConfigurationCategorieCategorieCategorieDVAL_ID DVAL_ID
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
  public string TITLECategorie
  {
    get
    {
      return this.tITLECategorieField;
    }
    set
    {
      this.tITLECategorieField = value;
    }
  }

  /// <remarks/>
  public GlobalConfigurationCategorieCategorieCategorieXITI XITI
  {
    get
    {
      return this.xITIField;
    }
    set
    {
      this.xITIField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute()]
  public string Title
  {
    get
    {
      return this.titleField;
    }
    set
    {
      this.titleField = value;
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlAttributeAttribute("DVAL_ID")]
  public uint DVAL_ID1
  {
    get
    {
      return this.dVAL_ID1Field;
    }
    set
    {
      this.dVAL_ID1Field = value;
    }
  }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GlobalConfigurationCategorieCategorieCategorieDVAL_ID
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
public partial class GlobalConfigurationCategorieCategorieCategorieXITI
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

