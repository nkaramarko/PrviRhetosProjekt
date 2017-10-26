// Reference: C:\Users\nkaramarko\Desktop\Omega\01. Zadaci\01. MojPrviRhetosProjekt\Rhetos\bin\Generated\Captions.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll
// Reference: C:\Users\nkaramarko\Desktop\Omega\01. Zadaci\01. MojPrviRhetosProjekt\Rhetos\bin\Plugins\OmegaCommonConcepts.Mvc.Client.dll
// Reference: C:\Users\nkaramarko\Desktop\Omega\01. Zadaci\01. MojPrviRhetosProjekt\Rhetos\bin\Plugins\Rhetos.Mvc.Client.dll
// CompilerOptions: ""


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CaptionsResourceClass =  Rhetos.Mvc.Captions;
/*
    If you need to use additional DataAnnotation attributes, or override existing attributes in the generated MvcModel,
    create the following class in your project:

    [MetadataTypeAttribute(typeof(MyModel.AdditionalAttributes))]
    public partial class MyModel
    {
        internal sealed class AdditionalAttributes
        {
            private AdditionalAttributes() { }

            [Display(Name = "Last Name", Order = 1, Prompt = "Enter Last Name")]
            public string LastName { get; set; }

            // Add other properties ...
        }
    }
*/



namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_Osoba", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class Osoba : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityOsoba = "Osoba";

        [Display(Name = "Stanovnik_Osoba_OIB", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        //[MaxLength(256)]
        [Required()]
        [MinLength(11)]
        [MaxLength(11)]
        [RegularExpression(@"^[0-9]$", ErrorMessage = @"Property {0} does not match required format.")]
        public virtual string OIB { get; set; }
        public const string PropertyOIB = "OIB";
        
        [Display(Name = "Stanovnik_Osoba_Ime", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Ime { get; set; }
        public const string PropertyIme = "Ime";
        
        [Display(Name = "Stanovnik_Osoba_Prezime", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Prezime { get; set; }
        public const string PropertyPrezime = "Prezime";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_Drzava", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class Drzava : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityDrzava = "Drzava";

        [Display(Name = "Stanovnik_Drzava_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_Grad", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class Grad : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityGrad = "Grad";

        [Display(Name = "Stanovnik_Grad_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
        
        [Display(Name = "Stanovnik_Grad_PostanskiBroj", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string PostanskiBroj { get; set; }
        public const string PropertyPostanskiBroj = "PostanskiBroj";
        
        [Display(Name = "Stanovnik_Grad_GradUDrzavi", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? GradUDrzaviID { get; set; }
        public const string PropertyGradUDrzaviID = "GradUDrzaviID";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_Adresa", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class Adresa : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAdresa = "Adresa";

        [Display(Name = "Stanovnik_Adresa_Naziv", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Naziv { get; set; }
        public const string PropertyNaziv = "Naziv";
        
        [Display(Name = "Stanovnik_Adresa_KucniBroj", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string KucniBroj { get; set; }
        public const string PropertyKucniBroj = "KucniBroj";
        
        [Display(Name = "Stanovnik_Adresa_AdresaUGradu", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? AdresaUGraduID { get; set; }
        public const string PropertyAdresaUGraduID = "AdresaUGraduID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AutoCodeCache", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class AutoCodeCache : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAutoCodeCache = "AutoCodeCache";

        [Display(Name = "Common_AutoCodeCache_Entity", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Entity { get; set; }
        public const string PropertyEntity = "Entity";
        
        [Display(Name = "Common_AutoCodeCache_Property", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Property { get; set; }
        public const string PropertyProperty = "Property";
        
        [Display(Name = "Common_AutoCodeCache_Grouping", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Grouping { get; set; }
        public const string PropertyGrouping = "Grouping";
        
        [Display(Name = "Common_AutoCodeCache_Prefix", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Prefix { get; set; }
        public const string PropertyPrefix = "Prefix";
        
        [Display(Name = "Common_AutoCodeCache_MinDigits", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual int? MinDigits { get; set; }
        public const string PropertyMinDigits = "MinDigits";
        
        [Display(Name = "Common_AutoCodeCache_LastCode", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual int? LastCode { get; set; }
        public const string PropertyLastCode = "LastCode";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_FilterId", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class FilterId : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityFilterId = "FilterId";

        [Display(Name = "Common_FilterId_Handle", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? Handle { get; set; }
        public const string PropertyHandle = "Handle";
        
        [Display(Name = "Common_FilterId_Value", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? Value { get; set; }
        public const string PropertyValue = "Value";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_KeepSynchronizedMetadata", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class KeepSynchronizedMetadata : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityKeepSynchronizedMetadata = "KeepSynchronizedMetadata";

        [Display(Name = "Common_KeepSynchronizedMetadata_Target", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Target { get; set; }
        public const string PropertyTarget = "Target";
        
        [Display(Name = "Common_KeepSynchronizedMetadata_Source", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Source { get; set; }
        public const string PropertySource = "Source";
        
        [Display(Name = "Common_KeepSynchronizedMetadata_Context", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Context { get; set; }
        public const string PropertyContext = "Context";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_ExclusiveLock", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class ExclusiveLock : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityExclusiveLock = "ExclusiveLock";

        [Display(Name = "Common_ExclusiveLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_ExclusiveLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        [Required()]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
        
        [Display(Name = "Common_ExclusiveLock_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_ExclusiveLock_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_ExclusiveLock_LockStart", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? LockStart { get; set; }
        public const string PropertyLockStart = "LockStart";
        
        [Display(Name = "Common_ExclusiveLock_LockFinish", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? LockFinish { get; set; }
        public const string PropertyLockFinish = "LockFinish";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SetLock", typeof(CaptionsResourceClass))]
    public partial class SetLock : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntitySetLock = "SetLock";

        [Display(Name = "Common_SetLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_SetLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_ReleaseLock", typeof(CaptionsResourceClass))]
    public partial class ReleaseLock : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityReleaseLock = "ReleaseLock";

        [Display(Name = "Common_ReleaseLock_ResourceType", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ResourceType { get; set; }
        public const string PropertyResourceType = "ResourceType";
        
        [Display(Name = "Common_ReleaseLock_ResourceID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? ResourceID { get; set; }
        public const string PropertyResourceID = "ResourceID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogReader", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class LogReader : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogReader = "LogReader";

        [Display(Name = "Common_LogReader_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_LogReader_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_LogReader_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_LogReader_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_LogReader_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogReader_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogReader_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
        
        [Display(Name = "Common_LogReader_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogRelatedItemReader", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class LogRelatedItemReader : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogRelatedItemReader = "LogRelatedItemReader";

        [Display(Name = "Common_LogRelatedItemReader_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogRelatedItemReader_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
        
        [Display(Name = "Common_LogRelatedItemReader_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogRelatedItemReader_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Log", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class Log : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLog = "Log";

        [Display(Name = "Common_Log_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
        
        [Display(Name = "Common_Log_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_Log_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_Log_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_Log_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_Log_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_Log_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_Log_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AddToLog", typeof(CaptionsResourceClass))]
    public partial class AddToLog : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAddToLog = "AddToLog";

        [Display(Name = "Common_AddToLog_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_AddToLog_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_AddToLog_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_AddToLog_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogRelatedItem", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class LogRelatedItem : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityLogRelatedItem = "LogRelatedItem";

        [Display(Name = "Common_LogRelatedItem_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        [Required()]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_LogRelatedItem_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LogRelatedItem_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_LogRelatedItem_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RelatedEventsSource", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class RelatedEventsSource : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRelatedEventsSource = "RelatedEventsSource";

        [Display(Name = "Common_RelatedEventsSource_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_RelatedEventsSource_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
        
        [Display(Name = "Common_RelatedEventsSource_RelatedToTable", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string RelatedToTable { get; set; }
        public const string PropertyRelatedToTable = "RelatedToTable";
        
        [Display(Name = "Common_RelatedEventsSource_RelatedToItem", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? RelatedToItem { get; set; }
        public const string PropertyRelatedToItem = "RelatedToItem";
        
        [Display(Name = "Common_RelatedEventsSource_UserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string UserName { get; set; }
        public const string PropertyUserName = "UserName";
        
        [Display(Name = "Common_RelatedEventsSource_Workstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Workstation { get; set; }
        public const string PropertyWorkstation = "Workstation";
        
        [Display(Name = "Common_RelatedEventsSource_ContextInfo", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ContextInfo { get; set; }
        public const string PropertyContextInfo = "ContextInfo";
        
        [Display(Name = "Common_RelatedEventsSource_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_RelatedEventsSource_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_RelatedEventsSource_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_RelatedEventsSource_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
        
        [Display(Name = "Common_RelatedEventsSource_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Claim", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    [Rhetos.Mvc.Deactivatable]
    public partial class Claim : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityClaim = "Claim";

        [Display(Name = "Common_Claim_ClaimResource", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ClaimResource { get; set; }
        public const string PropertyClaimResource = "ClaimResource";
        
        [Display(Name = "Common_Claim_ClaimRight", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string ClaimRight { get; set; }
        public const string PropertyClaimRight = "ClaimRight";
        
        [Display(Name = "Common_Claim_Active", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [DefaultValue(true)]
        public virtual bool? Active { get; set; }
        public const string PropertyActive = "Active";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_MyClaim", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.Extends(typeof(Rhetos.Mvc.Common.Claim))]
    public partial class MyClaim : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityMyClaim = "MyClaim";

        [Display(Name = "Common_MyClaim_Applies", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? Applies { get; set; }
        public const string PropertyApplies = "Applies";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Principal", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class Principal : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipal = "Principal";

        [Display(Name = "Common_Principal_Name", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Name { get; set; }
        public const string PropertyName = "Name";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_PrincipalHasRole", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class PrincipalHasRole : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipalHasRole = "PrincipalHasRole";

        [Display(Name = "Common_PrincipalHasRole_Principal", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? PrincipalID { get; set; }
        public const string PropertyPrincipalID = "PrincipalID";
        
        [Display(Name = "Common_PrincipalHasRole_Role", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? RoleID { get; set; }
        public const string PropertyRoleID = "RoleID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_Role", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class Role : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRole = "Role";

        [Display(Name = "Common_Role_Name", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string Name { get; set; }
        public const string PropertyName = "Name";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RoleInheritsRole", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class RoleInheritsRole : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRoleInheritsRole = "RoleInheritsRole";

        [Display(Name = "Common_RoleInheritsRole_UsersFrom", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? UsersFromID { get; set; }
        public const string PropertyUsersFromID = "UsersFromID";
        
        [Display(Name = "Common_RoleInheritsRole_PermissionsFrom", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual Guid? PermissionsFromID { get; set; }
        public const string PropertyPermissionsFromID = "PermissionsFromID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_PrincipalPermission", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class PrincipalPermission : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityPrincipalPermission = "PrincipalPermission";

        [Display(Name = "Common_PrincipalPermission_Principal", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? PrincipalID { get; set; }
        public const string PropertyPrincipalID = "PrincipalID";
        
        [Display(Name = "Common_PrincipalPermission_Claim", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? ClaimID { get; set; }
        public const string PropertyClaimID = "ClaimID";
        
        [Display(Name = "Common_PrincipalPermission_IsAuthorized", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual bool? IsAuthorized { get; set; }
        public const string PropertyIsAuthorized = "IsAuthorized";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RolePermission", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    [Rhetos.Mvc.HasLogging]
    public partial class RolePermission : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityRolePermission = "RolePermission";

        [Display(Name = "Common_RolePermission_Role", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? RoleID { get; set; }
        public const string PropertyRoleID = "RoleID";
        
        [Display(Name = "Common_RolePermission_Claim", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.None)]
        public virtual Guid? ClaimID { get; set; }
        public const string PropertyClaimID = "ClaimID";
        
        [Display(Name = "Common_RolePermission_IsAuthorized", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Required()]
        public virtual bool? IsAuthorized { get; set; }
        public const string PropertyIsAuthorized = "IsAuthorized";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RowPermissionsReadItems", typeof(CaptionsResourceClass))]
    public partial class RowPermissionsReadItems
    {
        public const string EntityRowPermissionsReadItems = "RowPermissionsReadItems";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_RowPermissionsWriteItems", typeof(CaptionsResourceClass))]
    public partial class RowPermissionsWriteItems
    {
        public const string EntityRowPermissionsWriteItems = "RowPermissionsWriteItems";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LoggedItem", typeof(CaptionsResourceClass))]
    public partial class LoggedItem
    {
        public const string EntityLoggedItem = "LoggedItem";

        [Display(Name = "Common_LoggedItem_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_LoggedItem_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_DeletedItems", typeof(CaptionsResourceClass))]
    public partial class DeletedItems
    {
        public const string EntityDeletedItems = "DeletedItems";

        [Display(Name = "Common_DeletedItems_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_LogEntry", typeof(CaptionsResourceClass))]
    public partial class LogEntry
    {
        public const string EntityLogEntry = "LogEntry";

        [Display(Name = "Common_LogEntry_LogID", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [Rhetos.Mvc.RenderMode(Rhetos.Mvc.RenderMode.EditModeOnly)]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AuditRelatedEvents", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class AuditRelatedEvents : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAuditRelatedEvents = "AuditRelatedEvents";

        [Display(Name = "Common_AuditRelatedEvents_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_AuditRelatedEvents_Created", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual DateTime? Created { get; set; }
        public const string PropertyCreated = "Created";
        
        [Display(Name = "Common_AuditRelatedEvents_Action", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Action { get; set; }
        public const string PropertyAction = "Action";
        
        [Display(Name = "Common_AuditRelatedEvents_TableName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string TableName { get; set; }
        public const string PropertyTableName = "TableName";
        
        [Display(Name = "Common_AuditRelatedEvents_ItemId", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? ItemId { get; set; }
        public const string PropertyItemId = "ItemId";
        
        [Display(Name = "Common_AuditRelatedEvents_Description", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Description { get; set; }
        public const string PropertyDescription = "Description";
        
        [Display(Name = "Common_AuditRelatedEvents_ClientUserName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ClientUserName { get; set; }
        public const string PropertyClientUserName = "ClientUserName";
        
        [Display(Name = "Common_AuditRelatedEvents_ClientWorkstation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string ClientWorkstation { get; set; }
        public const string PropertyClientWorkstation = "ClientWorkstation";
        
        [Display(Name = "Common_AuditRelatedEvents_Relation", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Relation { get; set; }
        public const string PropertyRelation = "Relation";
        
        [Display(Name = "Common_AuditRelatedEvents_Summary", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string Summary { get; set; }
        public const string PropertySummary = "Summary";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_AuditDataModifications", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    public partial class AuditDataModifications : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityAuditDataModifications = "AuditDataModifications";

        [Display(Name = "Common_AuditDataModifications_Log", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual Guid? LogID { get; set; }
        public const string PropertyLogID = "LogID";
        
        [Display(Name = "Common_AuditDataModifications_Property", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        public virtual string Property { get; set; }
        public const string PropertyProperty = "Property";
        
        [Display(Name = "Common_AuditDataModifications_OldValue", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string OldValue { get; set; }
        public const string PropertyOldValue = "OldValue";
        
        [Display(Name = "Common_AuditDataModifications_NewValue", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [UIHint("StringMultiline")]
        public virtual string NewValue { get; set; }
        public const string PropertyNewValue = "NewValue";
        
        [Display(Name = "Common_AuditDataModifications_Modified", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual bool? Modified { get; set; }
        public const string PropertyModified = "Modified";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_ReportTemplate", typeof(CaptionsResourceClass))]
    [Rhetos.Mvc.ReadableDataStructure]
    [Rhetos.Mvc.WritableDataStructure]
    public partial class ReportTemplate : Rhetos.Mvc.BaseMvcModel
    {
        public const string EntityReportTemplate = "ReportTemplate";

        [Display(Name = "Common_ReportTemplate_FileName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string FileName { get; set; }
        public const string PropertyFileName = "FileName";
        
        [Display(Name = "Common_ReportTemplate_DisplayName", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        [MaxLength(256)]
        [Required()]
        public virtual string DisplayName { get; set; }
        public const string PropertyDisplayName = "DisplayName";
        
        [Display(Name = "Common_ReportTemplate_Content", ResourceType = typeof(CaptionsResourceClass), AutoGenerateFilter = true)]
        public virtual byte[] Content { get; set; }
        public const string PropertyContent = "Content";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_OIB_RegExMatchFilter", typeof(CaptionsResourceClass))]
    public partial class OIB_RegExMatchFilter
    {
        public const string EntityOIB_RegExMatchFilter = "OIB_RegExMatchFilter";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_OIB_MaxLengthFilter", typeof(CaptionsResourceClass))]
    public partial class OIB_MaxLengthFilter
    {
        public const string EntityOIB_MaxLengthFilter = "OIB_MaxLengthFilter";
    }
}


namespace Rhetos.Mvc.Stanovnik
{
    [Rhetos.Mvc.LocalizedDisplayName("Stanovnik_OIB_MinLengthFilter", typeof(CaptionsResourceClass))]
    public partial class OIB_MinLengthFilter
    {
        public const string EntityOIB_MinLengthFilter = "OIB_MinLengthFilter";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredActive", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredActive
    {
        public const string EntitySystemRequiredActive = "SystemRequiredActive";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredLog", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredLog
    {
        public const string EntitySystemRequiredLog = "SystemRequiredLog";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredPrincipal", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredPrincipal
    {
        public const string EntitySystemRequiredPrincipal = "SystemRequiredPrincipal";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredUsersFrom", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredUsersFrom
    {
        public const string EntitySystemRequiredUsersFrom = "SystemRequiredUsersFrom";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredClaim", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredClaim
    {
        public const string EntitySystemRequiredClaim = "SystemRequiredClaim";
    }
}


namespace Rhetos.Mvc.Common
{
    [Rhetos.Mvc.LocalizedDisplayName("Common_SystemRequiredRole", typeof(CaptionsResourceClass))]
    public partial class SystemRequiredRole
    {
        public const string EntitySystemRequiredRole = "SystemRequiredRole";
    }
}

