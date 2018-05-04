Imports System.Data
Imports System.Data.OleDb

Module Access
    Public conex As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand
    Public source As String
    Sub enlace()
        Try
            conex.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & source & "")
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub

    Public Function genTabla(comando_sql As String) As DataTable
        'Definos una tabla temporal
        'para guardar el resultado del comando sql
        Dim tabla As New DataTable
        Try
            'Creamos el objeto para el comando sql
            Dim cmd As New OleDbCommand(comando_sql, conex)
            'Creamos el objeto para el adaptador de datos
            Dim adaptador As New OleDbDataAdapter(cmd)
            'Llenamos el temporal con los resultados de la consulta
            adaptador.Fill(tabla)
            'Finalmente retornamos el resultado
            If IsDBNull(tabla) = False Then
                Return tabla
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
End Module
