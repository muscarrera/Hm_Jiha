Module AutoModule

    Public Function isAdminFacture(ByVal FctId As Integer) As Boolean
        Dim b As Boolean = False
        Using c As DataAccess = New DataAccess(My.Settings.ALMohassinDBConnectionString, True)

            Dim tableName As String = "Facture"
            Dim fld As String = "fctid"
            If Form1.btswitsh.Tag = 0 Then
                tableName = "Bon"
                fld = "bonid"

            End If
            Dim params As New Dictionary(Of String, Object)
            params.Add(fld, FctId)
            Dim isAdmin = c.SelectByScalar(tableName, "admin", params)
            Try
                If CBool(isAdmin) = True Then
                    b = True
                End If
            Catch ex As Exception
                b = False
            End Try
        End Using
        Return b
    End Function




End Module
