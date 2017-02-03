Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Module Module1
    Sub Main()
        Dim objsession As New Session()
        objsession.ConnectionString = "Data Source=WFR-BTM-024\MSQLSERVER3;Initial Catalog=Test123;Integrated Security = SSPI;"

        Dim objEmployee As Employee = New Employee(objsession)
        Dim objSite As Site = New Site(objsession)
        Dim objtambahan As tambahan = New tambahan(objsession)
        objtambahan.testing1 = "TESTING123"
        objtambahan.testing2 = "Testing456"
        objtambahan.Save()

        Dim collectionEmployee As XPCollection = New XPCollection(objsession, GetType(Employee))
        Dim collectionSite As XPCollection = New XPCollection(objsession, GetType(Site))




        For Each objSite In collectionSite

            For Each objEmployee In collectionEmployee
                Dim objsiteEmployee As SiteEmployee = New SiteEmployee(objsession)
                objsiteEmployee.namasite = objSite.namasite.ToString()
                objsiteEmployee.nama = objEmployee.nama.ToString()
                objsiteEmployee.Save()
            Next
        Next



    End Sub

End Module
