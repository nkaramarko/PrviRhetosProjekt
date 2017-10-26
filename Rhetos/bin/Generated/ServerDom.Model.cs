// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Autofac.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Rhetos.Extensibility.Interfaces.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Rhetos.Utilities.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Rhetos.Security.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Rhetos.Logging.Interfaces.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\EntityFramework.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\EntityFramework.SqlServer.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Rhetos.Persistence.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
// Reference: C:\Users\nkaramarko\Desktop\Projekti\MojPrviRhetosProjekt\Rhetos\Rhetos.2.2.0\bin\Plugins\OmegaCommonConcepts.dll
// CompilerOptions: "/optimize"

namespace Stanovnik
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Stanovnik*/

    [DataContract]/*DataStructureInfo ClassAttributes Stanovnik.Osoba*/
    public class Osoba : EntityBase<Stanovnik.Osoba>/*Next DataStructureInfo ClassInterace Stanovnik.Osoba*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Stanovnik_Osoba ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Stanovnik_Osoba
            {
                ID = item.ID,
                OIB = item.OIB,
                Ime = item.Ime,
                Prezime = item.Prezime/*DataStructureInfo AssignSimpleProperty Stanovnik.Osoba*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Stanovnik.Osoba.OIB*/
        public int? OIB { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Osoba.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Osoba.Prezime*/
        public string Prezime { get; set; }
        /*DataStructureInfo ClassBody Stanovnik.Osoba*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Stanovnik.Drzava*/
    public class Drzava : EntityBase<Stanovnik.Drzava>/*Next DataStructureInfo ClassInterace Stanovnik.Drzava*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Stanovnik_Drzava ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Stanovnik_Drzava
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Stanovnik.Drzava*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Stanovnik.Drzava.Sifra*/
        public int? Sifra { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Drzava.Naziv*/
        public string Naziv { get; set; }
        /*DataStructureInfo ClassBody Stanovnik.Drzava*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Stanovnik.Grad*/
    public class Grad : EntityBase<Stanovnik.Grad>/*Next DataStructureInfo ClassInterace Stanovnik.Grad*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Stanovnik_Grad ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Stanovnik_Grad
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                PostanskiBroj = item.PostanskiBroj,
                GradUDrzaviID = item.GradUDrzaviID/*DataStructureInfo AssignSimpleProperty Stanovnik.Grad*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Stanovnik.Grad.Sifra*/
        public int? Sifra { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Grad.Naziv*/
        public string Naziv { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Grad.PostanskiBroj*/
        public string PostanskiBroj { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Grad.GradUDrzaviID*/
        public Guid? GradUDrzaviID { get; set; }
        /*DataStructureInfo ClassBody Stanovnik.Grad*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Stanovnik.Adresa*/
    public class Adresa : EntityBase<Stanovnik.Adresa>/*Next DataStructureInfo ClassInterace Stanovnik.Adresa*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Stanovnik_Adresa ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Stanovnik_Adresa
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                KucniBroj = item.KucniBroj,
                AdresaUGraduID = item.AdresaUGraduID/*DataStructureInfo AssignSimpleProperty Stanovnik.Adresa*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Stanovnik.Adresa.Sifra*/
        public int? Sifra { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Adresa.Naziv*/
        public string Naziv { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Adresa.KucniBroj*/
        public string KucniBroj { get; set; }
        [DataMember]/*PropertyInfo Attribute Stanovnik.Adresa.AdresaUGraduID*/
        public Guid? AdresaUGraduID { get; set; }
        /*DataStructureInfo ClassBody Stanovnik.Adresa*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Stanovnik.SystemRequiredSifra*/
    public class SystemRequiredSifra/*DataStructureInfo ClassInterace Stanovnik.SystemRequiredSifra*/
    {
        /*DataStructureInfo ClassBody Stanovnik.SystemRequiredSifra*/
    }

    /*ModuleInfo Body Stanovnik*/
}

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    [DataContract]/*DataStructureInfo ClassAttributes Common.AutoCodeCache*/
    public class AutoCodeCache : EntityBase<Common.AutoCodeCache>/*Next DataStructureInfo ClassInterace Common.AutoCodeCache*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AutoCodeCache ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Entity*/
        public string Entity { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Grouping*/
        public string Grouping { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.MinDigits*/
        public int? MinDigits { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.LastCode*/
        public int? LastCode { get; set; }
        /*DataStructureInfo ClassBody Common.AutoCodeCache*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.FilterId*/
    public class FilterId : EntityBase<Common.FilterId>, Rhetos.Dom.DefaultConcepts.ICommonFilterId/*Next DataStructureInfo ClassInterace Common.FilterId*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_FilterId ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.FilterId.Handle*/
        public Guid? Handle { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.FilterId.Value*/
        public Guid? Value { get; set; }
        /*DataStructureInfo ClassBody Common.FilterId*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata : EntityBase<Common.KeepSynchronizedMetadata>, Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata/*Next DataStructureInfo ClassInterace Common.KeepSynchronizedMetadata*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_KeepSynchronizedMetadata ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Target*/
        public string Target { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Source*/
        public string Source { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Context*/
        public string Context { get; set; }
        /*DataStructureInfo ClassBody Common.KeepSynchronizedMetadata*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ExclusiveLock*/
    public class ExclusiveLock : EntityBase<Common.ExclusiveLock>/*Next DataStructureInfo ClassInterace Common.ExclusiveLock*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ExclusiveLock ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockStart*/
        public DateTime? LockStart { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockFinish*/
        public DateTime? LockFinish { get; set; }
        /*DataStructureInfo ClassBody Common.ExclusiveLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SetLock*/
    public class SetLock/*DataStructureInfo ClassInterace Common.SetLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.SetLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReleaseLock*/
    public class ReleaseLock/*DataStructureInfo ClassInterace Common.ReleaseLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.ReleaseLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogReader*/
    public class LogReader : EntityBase<Common.LogReader>/*Next DataStructureInfo ClassInterace Common.LogReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogReader.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.LogReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader : EntityBase<Common.LogRelatedItemReader>/*Next DataStructureInfo ClassInterace Common.LogRelatedItemReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItemReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.LogID*/
        public Guid? LogID { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItemReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Log*/
    public class Log : EntityBase<Common.Log>/*Next DataStructureInfo ClassInterace Common.Log*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Log ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Log.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.Log*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AddToLog*/
    public class AddToLog/*DataStructureInfo ClassInterace Common.AddToLog*/
    {
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.AddToLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItem*/
    public class LogRelatedItem : EntityBase<Common.LogRelatedItem>/*Next DataStructureInfo ClassInterace Common.LogRelatedItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.Relation*/
        public string Relation { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource : EntityBase<Common.RelatedEventsSource>/*Next DataStructureInfo ClassInterace Common.RelatedEventsSource*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RelatedEventsSource ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToTable*/
        public string RelatedToTable { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToItem*/
        public Guid? RelatedToItem { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Created*/
        public DateTime? Created { get; set; }
        /*DataStructureInfo ClassBody Common.RelatedEventsSource*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Claim*/
    public class Claim : EntityBase<Common.Claim>, Rhetos.Dom.DefaultConcepts.IDeactivatable, Rhetos.Dom.DefaultConcepts.ICommonClaim/*Next DataStructureInfo ClassInterace Common.Claim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Claim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimResource*/
        public string ClaimResource { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimRight*/
        public string ClaimRight { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.Active*/
        public bool? Active { get; set; }
        /*DataStructureInfo ClassBody Common.Claim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.MyClaim*/
    public class MyClaim : EntityBase<Common.MyClaim>/*Next DataStructureInfo ClassInterace Common.MyClaim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_MyClaim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.MyClaim.Applies*/
        public bool? Applies { get; set; }
        /*DataStructureInfo ClassBody Common.MyClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Principal*/
    public class Principal : EntityBase<Common.Principal>, Rhetos.Dom.DefaultConcepts.IPrincipal/*Next DataStructureInfo ClassInterace Common.Principal*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Principal ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Principal.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Principal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole : EntityBase<Common.PrincipalHasRole>, Rhetos.Dom.DefaultConcepts.IPrincipalHasRole/*Next DataStructureInfo ClassInterace Common.PrincipalHasRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalHasRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.RoleID*/
        public Guid? RoleID { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalHasRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Role*/
    public class Role : EntityBase<Common.Role>, Rhetos.Dom.DefaultConcepts.IRole/*Next DataStructureInfo ClassInterace Common.Role*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Role ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Role.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Role*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole : EntityBase<Common.RoleInheritsRole>, Rhetos.Dom.DefaultConcepts.IRoleInheritsRole/*Next DataStructureInfo ClassInterace Common.RoleInheritsRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RoleInheritsRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.UsersFromID*/
        public Guid? UsersFromID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.PermissionsFromID*/
        public Guid? PermissionsFromID { get; set; }
        /*DataStructureInfo ClassBody Common.RoleInheritsRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalPermission*/
    public class PrincipalPermission : EntityBase<Common.PrincipalPermission>, Rhetos.Dom.DefaultConcepts.IPrincipalPermission/*Next DataStructureInfo ClassInterace Common.PrincipalPermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalPermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalPermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RolePermission*/
    public class RolePermission : EntityBase<Common.RolePermission>, Rhetos.Dom.DefaultConcepts.IRolePermission/*Next DataStructureInfo ClassInterace Common.RolePermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RolePermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RolePermission.RoleID*/
        public Guid? RoleID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.RolePermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsReadItems*/
    public class RowPermissionsReadItems/*DataStructureInfo ClassInterace Common.RowPermissionsReadItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsReadItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsWriteItems*/
    public class RowPermissionsWriteItems/*DataStructureInfo ClassInterace Common.RowPermissionsWriteItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsWriteItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LoggedItem*/
    public class LoggedItem/*DataStructureInfo ClassInterace Common.LoggedItem*/
    {
        [DataMember]/*PropertyInfo Attribute Common.LoggedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LoggedItem.ItemId*/
        public Guid? ItemId { get; set; }
        /*DataStructureInfo ClassBody Common.LoggedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.DeletedItems*/
    public class DeletedItems/*DataStructureInfo ClassInterace Common.DeletedItems*/
    {
        [DataMember]/*PropertyInfo Attribute Common.DeletedItems.TableName*/
        public string TableName { get; set; }
        /*DataStructureInfo ClassBody Common.DeletedItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogEntry*/
    public class LogEntry/*DataStructureInfo ClassInterace Common.LogEntry*/
    {
        [DataMember]/*PropertyInfo Attribute Common.LogEntry.LogID*/
        public Guid? LogID { get; set; }
        /*DataStructureInfo ClassBody Common.LogEntry*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AuditRelatedEvents*/
    public class AuditRelatedEvents : EntityBase<Common.AuditRelatedEvents>/*Next DataStructureInfo ClassInterace Common.AuditRelatedEvents*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AuditRelatedEvents ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AuditRelatedEvents
            {
                ID = item.ID,
                LogID = item.LogID,
                Created = item.Created,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                ClientUserName = item.ClientUserName,
                ClientWorkstation = item.ClientWorkstation,
                Relation = item.Relation,
                Summary = item.Summary/*DataStructureInfo AssignSimpleProperty Common.AuditRelatedEvents*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.ClientUserName*/
        public string ClientUserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.ClientWorkstation*/
        public string ClientWorkstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditRelatedEvents.Summary*/
        public string Summary { get; set; }
        /*DataStructureInfo ClassBody Common.AuditRelatedEvents*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AuditDataModifications*/
    public class AuditDataModifications : EntityBase<Common.AuditDataModifications>/*Next DataStructureInfo ClassInterace Common.AuditDataModifications*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AuditDataModifications ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AuditDataModifications
            {
                ID = item.ID,
                LogID = item.LogID,
                Property = item.Property,
                OldValue = item.OldValue,
                NewValue = item.NewValue,
                Modified = item.Modified/*DataStructureInfo AssignSimpleProperty Common.AuditDataModifications*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AuditDataModifications.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditDataModifications.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditDataModifications.OldValue*/
        public string OldValue { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditDataModifications.NewValue*/
        public string NewValue { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AuditDataModifications.Modified*/
        public bool? Modified { get; set; }
        /*DataStructureInfo ClassBody Common.AuditDataModifications*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReportTemplate*/
    public class ReportTemplate : EntityBase<Common.ReportTemplate>/*Next DataStructureInfo ClassInterace Common.ReportTemplate*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ReportTemplate ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ReportTemplate
            {
                ID = item.ID,
                FileName = item.FileName,
                DisplayName = item.DisplayName,
                Content = item.Content/*DataStructureInfo AssignSimpleProperty Common.ReportTemplate*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ReportTemplate.FileName*/
        public string FileName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReportTemplate.DisplayName*/
        public string DisplayName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReportTemplate.Content*/
        public byte[] Content { get; set; }
        /*DataStructureInfo ClassBody Common.ReportTemplate*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Common.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredLog*/
    public class SystemRequiredLog/*DataStructureInfo ClassInterace Common.SystemRequiredLog*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredPrincipal*/
    public class SystemRequiredPrincipal/*DataStructureInfo ClassInterace Common.SystemRequiredPrincipal*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredPrincipal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredUsersFrom*/
    public class SystemRequiredUsersFrom/*DataStructureInfo ClassInterace Common.SystemRequiredUsersFrom*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredUsersFrom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredClaim*/
    public class SystemRequiredClaim/*DataStructureInfo ClassInterace Common.SystemRequiredClaim*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredRole*/
    public class SystemRequiredRole/*DataStructureInfo ClassInterace Common.SystemRequiredRole*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredRole*/
    }

    /*ModuleInfo Body Common*/
}

/*SimpleClasses*/

namespace Common.Queryable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes Stanovnik.Osoba*/
    public class Stanovnik_Osoba : global::Stanovnik.Osoba, IQueryableEntity<Stanovnik.Osoba>, System.IEquatable<Stanovnik_Osoba>, IDetachOverride/*DataStructureInfo QueryableClassInterace Stanovnik.Osoba*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Stanovnik.Osoba ToSimple()
        {
            var item = this;
            return new Stanovnik.Osoba
            {
                ID = item.ID,
                OIB = item.OIB,
                Ime = item.Ime,
                Prezime = item.Prezime/*DataStructureInfo AssignSimpleProperty Stanovnik.Osoba*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Stanovnik.Osoba*/

        public bool Equals(Stanovnik_Osoba other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Stanovnik.Drzava*/
    public class Stanovnik_Drzava : global::Stanovnik.Drzava, IQueryableEntity<Stanovnik.Drzava>, System.IEquatable<Stanovnik_Drzava>, IDetachOverride/*DataStructureInfo QueryableClassInterace Stanovnik.Drzava*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Stanovnik.Drzava ToSimple()
        {
            var item = this;
            return new Stanovnik.Drzava
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Stanovnik.Drzava*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Stanovnik.Drzava*/

        public bool Equals(Stanovnik_Drzava other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Stanovnik.Grad*/
    public class Stanovnik_Grad : global::Stanovnik.Grad, IQueryableEntity<Stanovnik.Grad>, System.IEquatable<Stanovnik_Grad>, IDetachOverride/*DataStructureInfo QueryableClassInterace Stanovnik.Grad*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Stanovnik.Grad ToSimple()
        {
            var item = this;
            return new Stanovnik.Grad
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                PostanskiBroj = item.PostanskiBroj,
                GradUDrzaviID = item.GradUDrzaviID/*DataStructureInfo AssignSimpleProperty Stanovnik.Grad*/
            };
        }

        private Common.Queryable.Stanovnik_Drzava _gradUDrzavi;

        /*DataStructureQueryable PropertyAttribute Stanovnik.Grad.GradUDrzavi*/
        public virtual Common.Queryable.Stanovnik_Drzava GradUDrzavi
        {
            get
            {
                /*DataStructureQueryable Getter Stanovnik.Grad.GradUDrzavi*/
                return _gradUDrzavi;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Stanovnik.Grad.GradUDrzavi*/
                _gradUDrzavi = value;
                GradUDrzaviID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Stanovnik.Grad*/

        public bool Equals(Stanovnik_Grad other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Stanovnik.Adresa*/
    public class Stanovnik_Adresa : global::Stanovnik.Adresa, IQueryableEntity<Stanovnik.Adresa>, System.IEquatable<Stanovnik_Adresa>, IDetachOverride/*DataStructureInfo QueryableClassInterace Stanovnik.Adresa*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Stanovnik.Adresa ToSimple()
        {
            var item = this;
            return new Stanovnik.Adresa
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                KucniBroj = item.KucniBroj,
                AdresaUGraduID = item.AdresaUGraduID/*DataStructureInfo AssignSimpleProperty Stanovnik.Adresa*/
            };
        }

        private Common.Queryable.Stanovnik_Grad _adresaUGradu;

        /*DataStructureQueryable PropertyAttribute Stanovnik.Adresa.AdresaUGradu*/
        public virtual Common.Queryable.Stanovnik_Grad AdresaUGradu
        {
            get
            {
                /*DataStructureQueryable Getter Stanovnik.Adresa.AdresaUGradu*/
                return _adresaUGradu;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Stanovnik.Adresa.AdresaUGradu*/
                _adresaUGradu = value;
                AdresaUGraduID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Stanovnik.Adresa*/

        public bool Equals(Stanovnik_Adresa other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.AutoCodeCache*/
    public class Common_AutoCodeCache : global::Common.AutoCodeCache, IQueryableEntity<Common.AutoCodeCache>, System.IEquatable<Common_AutoCodeCache>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AutoCodeCache*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AutoCodeCache ToSimple()
        {
            var item = this;
            return new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.AutoCodeCache*/

        public bool Equals(Common_AutoCodeCache other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.FilterId*/
    public class Common_FilterId : global::Common.FilterId, IQueryableEntity<Common.FilterId>, System.IEquatable<Common_FilterId>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.FilterId*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.FilterId ToSimple()
        {
            var item = this;
            return new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.FilterId*/

        public bool Equals(Common_FilterId other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.KeepSynchronizedMetadata*/
    public class Common_KeepSynchronizedMetadata : global::Common.KeepSynchronizedMetadata, IQueryableEntity<Common.KeepSynchronizedMetadata>, System.IEquatable<Common_KeepSynchronizedMetadata>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.KeepSynchronizedMetadata*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.KeepSynchronizedMetadata ToSimple()
        {
            var item = this;
            return new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.KeepSynchronizedMetadata*/

        public bool Equals(Common_KeepSynchronizedMetadata other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ExclusiveLock*/
    public class Common_ExclusiveLock : global::Common.ExclusiveLock, IQueryableEntity<Common.ExclusiveLock>, System.IEquatable<Common_ExclusiveLock>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ExclusiveLock*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ExclusiveLock ToSimple()
        {
            var item = this;
            return new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ExclusiveLock*/

        public bool Equals(Common_ExclusiveLock other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogReader*/
    public class Common_LogReader : global::Common.LogReader, IQueryableEntity<Common.LogReader>, System.IEquatable<Common_LogReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogReader ToSimple()
        {
            var item = this;
            return new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.LogReader*/

        public bool Equals(Common_LogReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItemReader*/
    public class Common_LogRelatedItemReader : global::Common.LogRelatedItemReader, IQueryableEntity<Common.LogRelatedItemReader>, System.IEquatable<Common_LogRelatedItemReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItemReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItemReader ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItemReader.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItemReader.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItemReader.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItemReader*/

        public bool Equals(Common_LogRelatedItemReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Log*/
    public class Common_Log : global::Common.Log, IQueryableEntity<Common.Log>, System.IEquatable<Common_Log>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Log*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Log ToSimple()
        {
            var item = this;
            return new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Log*/

        public bool Equals(Common_Log other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItem*/
    public class Common_LogRelatedItem : global::Common.LogRelatedItem, IQueryableEntity<Common.LogRelatedItem>, System.IEquatable<Common_LogRelatedItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItem ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItem.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItem.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItem.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItem*/

        public bool Equals(Common_LogRelatedItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RelatedEventsSource*/
    public class Common_RelatedEventsSource : global::Common.RelatedEventsSource, IQueryableEntity<Common.RelatedEventsSource>, System.IEquatable<Common_RelatedEventsSource>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RelatedEventsSource*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RelatedEventsSource ToSimple()
        {
            var item = this;
            return new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.RelatedEventsSource.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.RelatedEventsSource.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RelatedEventsSource.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RelatedEventsSource*/

        public bool Equals(Common_RelatedEventsSource other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Claim*/
    public class Common_Claim : global::Common.Claim, IQueryableEntity<Common.Claim>, System.IEquatable<Common_Claim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Claim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Claim ToSimple()
        {
            var item = this;
            return new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        private Common.Queryable.Common_MyClaim _extension_MyClaim;

        /*DataStructureQueryable PropertyAttribute Common.Claim.Extension_MyClaim*/
        public virtual Common.Queryable.Common_MyClaim Extension_MyClaim
        {
            get
            {
                /*DataStructureQueryable Getter Common.Claim.Extension_MyClaim*/
                return _extension_MyClaim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.Claim.Extension_MyClaim*/
                _extension_MyClaim = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.Claim*/

        public bool Equals(Common_Claim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.MyClaim*/
    public class Common_MyClaim : global::Common.MyClaim, IQueryableEntity<Common.MyClaim>, System.IEquatable<Common_MyClaim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.MyClaim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.MyClaim ToSimple()
        {
            var item = this;
            return new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        private Common.Queryable.Common_Claim _base;

        /*DataStructureQueryable PropertyAttribute Common.MyClaim.Base*/
        public virtual Common.Queryable.Common_Claim Base
        {
            get
            {
                /*DataStructureQueryable Getter Common.MyClaim.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.MyClaim.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.MyClaim*/

        public bool Equals(Common_MyClaim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Principal*/
    public class Common_Principal : global::Common.Principal, IQueryableEntity<Common.Principal>, System.IEquatable<Common_Principal>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Principal*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Principal ToSimple()
        {
            var item = this;
            return new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Principal*/

        public bool Equals(Common_Principal other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalHasRole*/
    public class Common_PrincipalHasRole : global::Common.PrincipalHasRole, IQueryableEntity<Common.PrincipalHasRole>, System.IEquatable<Common_PrincipalHasRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalHasRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalHasRole ToSimple()
        {
            var item = this;
            return new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalHasRole*/

        public bool Equals(Common_PrincipalHasRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Role*/
    public class Common_Role : global::Common.Role, IQueryableEntity<Common.Role>, System.IEquatable<Common_Role>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Role*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Role ToSimple()
        {
            var item = this;
            return new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Role*/

        public bool Equals(Common_Role other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RoleInheritsRole*/
    public class Common_RoleInheritsRole : global::Common.RoleInheritsRole, IQueryableEntity<Common.RoleInheritsRole>, System.IEquatable<Common_RoleInheritsRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RoleInheritsRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RoleInheritsRole ToSimple()
        {
            var item = this;
            return new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        private Common.Queryable.Common_Role _usersFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.UsersFrom*/
        public virtual Common.Queryable.Common_Role UsersFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.UsersFrom*/
                return _usersFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.UsersFrom*/
                _usersFrom = value;
                UsersFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _permissionsFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.PermissionsFrom*/
        public virtual Common.Queryable.Common_Role PermissionsFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.PermissionsFrom*/
                return _permissionsFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.PermissionsFrom*/
                _permissionsFrom = value;
                PermissionsFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RoleInheritsRole*/

        public bool Equals(Common_RoleInheritsRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalPermission*/
    public class Common_PrincipalPermission : global::Common.PrincipalPermission, IQueryableEntity<Common.PrincipalPermission>, System.IEquatable<Common_PrincipalPermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalPermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalPermission ToSimple()
        {
            var item = this;
            return new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalPermission*/

        public bool Equals(Common_PrincipalPermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RolePermission*/
    public class Common_RolePermission : global::Common.RolePermission, IQueryableEntity<Common.RolePermission>, System.IEquatable<Common_RolePermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RolePermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RolePermission ToSimple()
        {
            var item = this;
            return new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RolePermission*/

        public bool Equals(Common_RolePermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.AuditRelatedEvents*/
    public class Common_AuditRelatedEvents : global::Common.AuditRelatedEvents, IQueryableEntity<Common.AuditRelatedEvents>, System.IEquatable<Common_AuditRelatedEvents>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AuditRelatedEvents*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AuditRelatedEvents ToSimple()
        {
            var item = this;
            return new Common.AuditRelatedEvents
            {
                ID = item.ID,
                LogID = item.LogID,
                Created = item.Created,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                ClientUserName = item.ClientUserName,
                ClientWorkstation = item.ClientWorkstation,
                Relation = item.Relation,
                Summary = item.Summary/*DataStructureInfo AssignSimpleProperty Common.AuditRelatedEvents*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.AuditRelatedEvents.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.AuditRelatedEvents.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.AuditRelatedEvents.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.AuditRelatedEvents*/

        public bool Equals(Common_AuditRelatedEvents other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.AuditDataModifications*/
    public class Common_AuditDataModifications : global::Common.AuditDataModifications, IQueryableEntity<Common.AuditDataModifications>, System.IEquatable<Common_AuditDataModifications>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AuditDataModifications*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AuditDataModifications ToSimple()
        {
            var item = this;
            return new Common.AuditDataModifications
            {
                ID = item.ID,
                LogID = item.LogID,
                Property = item.Property,
                OldValue = item.OldValue,
                NewValue = item.NewValue,
                Modified = item.Modified/*DataStructureInfo AssignSimpleProperty Common.AuditDataModifications*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.AuditDataModifications.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.AuditDataModifications.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.AuditDataModifications.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.AuditDataModifications*/

        public bool Equals(Common_AuditDataModifications other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ReportTemplate*/
    public class Common_ReportTemplate : global::Common.ReportTemplate, IQueryableEntity<Common.ReportTemplate>, System.IEquatable<Common_ReportTemplate>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ReportTemplate*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ReportTemplate ToSimple()
        {
            var item = this;
            return new Common.ReportTemplate
            {
                ID = item.ID,
                FileName = item.FileName,
                DisplayName = item.DisplayName,
                Content = item.Content/*DataStructureInfo AssignSimpleProperty Common.ReportTemplate*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ReportTemplate*/

        public bool Equals(Common_ReportTemplate other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*CommonQueryableMemebers*/
}

namespace Rhetos.Dom.DefaultConcepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Stanovnik.Osoba> ToSimple(this IQueryable<Common.Queryable.Stanovnik_Osoba> query)
        {
            return query.Select(item => new Stanovnik.Osoba
            {
                ID = item.ID,
                OIB = item.OIB,
                Ime = item.Ime,
                Prezime = item.Prezime/*DataStructureInfo AssignSimpleProperty Stanovnik.Osoba*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Stanovnik.Drzava> ToSimple(this IQueryable<Common.Queryable.Stanovnik_Drzava> query)
        {
            return query.Select(item => new Stanovnik.Drzava
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv/*DataStructureInfo AssignSimpleProperty Stanovnik.Drzava*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Stanovnik.Grad> ToSimple(this IQueryable<Common.Queryable.Stanovnik_Grad> query)
        {
            return query.Select(item => new Stanovnik.Grad
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                PostanskiBroj = item.PostanskiBroj,
                GradUDrzaviID = item.GradUDrzaviID/*DataStructureInfo AssignSimpleProperty Stanovnik.Grad*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Stanovnik.Adresa> ToSimple(this IQueryable<Common.Queryable.Stanovnik_Adresa> query)
        {
            return query.Select(item => new Stanovnik.Adresa
            {
                ID = item.ID,
                Sifra = item.Sifra,
                Naziv = item.Naziv,
                KucniBroj = item.KucniBroj,
                AdresaUGraduID = item.AdresaUGraduID/*DataStructureInfo AssignSimpleProperty Stanovnik.Adresa*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                ItemId = item.ItemId,
                LogID = item.LogID/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                Created = item.Created/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AuditRelatedEvents> ToSimple(this IQueryable<Common.Queryable.Common_AuditRelatedEvents> query)
        {
            return query.Select(item => new Common.AuditRelatedEvents
            {
                ID = item.ID,
                LogID = item.LogID,
                Created = item.Created,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description,
                ClientUserName = item.ClientUserName,
                ClientWorkstation = item.ClientWorkstation,
                Relation = item.Relation,
                Summary = item.Summary/*DataStructureInfo AssignSimpleProperty Common.AuditRelatedEvents*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AuditDataModifications> ToSimple(this IQueryable<Common.Queryable.Common_AuditDataModifications> query)
        {
            return query.Select(item => new Common.AuditDataModifications
            {
                ID = item.ID,
                LogID = item.LogID,
                Property = item.Property,
                OldValue = item.OldValue,
                NewValue = item.NewValue,
                Modified = item.Modified/*DataStructureInfo AssignSimpleProperty Common.AuditDataModifications*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ReportTemplate> ToSimple(this IQueryable<Common.Queryable.Common_ReportTemplate> query)
        {
            return query.Select(item => new Common.ReportTemplate
            {
                ID = item.ID,
                FileName = item.FileName,
                DisplayName = item.DisplayName,
                Content = item.Content/*DataStructureInfo AssignSimpleProperty Common.ReportTemplate*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            var query = items as IQueryable<IQueryableEntity<TEntity>>;
            var navigationItems = items as IEnumerable<IQueryableEntity<TEntity>>;

            if (query != null)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (navigationItems != null)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }
}