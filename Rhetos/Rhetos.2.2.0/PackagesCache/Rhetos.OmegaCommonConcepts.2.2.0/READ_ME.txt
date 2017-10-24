Build procedura:
1. (samo ako je promijenjen interface) Uzeti zadnju verziju Rhetos dll-ova u "Packages\Rhetos\" (UpdateRhetosDlls.bat).
2. Buildati solution OmegaCommonConcepts.sln (VS 2010 ili 2012).

Izrada instalacijskog paketa:
* Alati koji se ovdje koriste očekuju određenu relativnu putanju do Rhetos repozitoriju, istu kao na PROTON serveru (..\..\Rhetos)
1. Upiši novu verziju u "ChangeVersion.bat" i pokreni ga.
2. Pokreni "CreatePackage.bat". Instalacijski paket (.zip) je kreiran u parent folderu iznad TemplaterReport.
