Imports System.Net

Module Crypt
    Public Function enccode(ByVal inString As String) As String
        Dim enc As New System.Text.UnicodeEncoding
        Dim buffer As Byte() = enc.GetBytes(inString)
        enccode = Convert.ToBase64String(buffer)

    End Function

    Public Function deccode(ByVal inString As String) As String
        Try
            Dim enc As New System.Text.UnicodeEncoding
            Dim buffer As Byte() = Convert.FromBase64String(inString)
            deccode = enc.GetString(buffer)
        Catch

        End Try
    End Function
End Module