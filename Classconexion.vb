Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class Classconexion
    'Public servidor As String = "Data source = 'Nombre del servidor'; Initial catalog= 'Base de datos'; Integrated security = true"
    Public servidor As String = "Data source = MSI\SQLEXPRESS; Initial catalog=Ferreteria;Integrated security =true"
    Public conexiion As New SqlConnection(servidor)

    Public Sub conectar()
        Try
            If conexiion.State = Data.ConnectionState.Closed Then
                conexiion.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar la Base de Datos" & vbCrLf & ex.Message)
        End Try


    End Sub

    Public Sub desconectar()
        Try
            If conexiion.State = Data.ConnectionState.Open Then
                conexiion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function reader(ByVal cons As String) As SqlDataReader
        Dim dr As SqlDataReader
        Try
            conectar()
            Dim cmdinstruction As New SqlCommand(cons, conexiion)
            dr = cmdinstruction.ExecuteReader
        Catch ex As Exception
            dr = Nothing
            MsgBox(ex.Message)
        Finally
        End Try

        Return dr
    End Function

    Public Sub manipular(ByVal query As String)
        Dim comando As New SqlCommand(query, conexiion)
        Try
            conectar()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub


    Public Function val(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand
        Try
            conectar()
            cmd = New SqlCommand(query, conexiion)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
