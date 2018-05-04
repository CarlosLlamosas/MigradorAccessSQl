Imports System.Data.SqlClient
Imports System.Net
Imports System
Imports System.IO
Imports System.Collections
Module DatosBD
    Public _ComandoBD As SqlCommand
    Public drDataReader As SqlDataReader
    Public servidor As String
    Public base As String
    Public usr As String
    Public pwd As String
    Public conexion As New SqlConnection
    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = Application.StartupPath
    ':::Nombre del archivo
    Dim archivo As String = "\CONEXION.DSN"
    'Creamos el objeto de conexión

    Sub LeerArchivo()
        Try
            servidor = (IO.File.ReadLines(ruta & archivo)(11)).Substring(7)
            base = (IO.File.ReadLines(ruta & archivo)(8)).Substring(9)
            usr = (IO.File.ReadLines(ruta & archivo)(2)).Substring(4)
            pwd = (IO.File.ReadLines(ruta & archivo)(3)).Substring(4)
            conexion.ConnectionString = ("data source=" & servidor & ";initial catalog=" & base & ";uid=" & usr & ";pwd=" & pwd & ";")
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    'Public conexion As New SqlConnection("data source=" & servidor & ";initial catalog=" & base & ";uid=" & usr & ";pwd=" & pwd & ";")
    'Public conexion As New SqlConnection("data source=(local)\sqlexpress2014;initial catalog=PRESTAMO;uid=adm;pwd=admadm")


    'Función para recuperar registros de la base de datos (select)
    Public Function generar_DataTable(comando_sql As String) As DataTable
        'Definos una tabla temporal
        'para guardar el resultado del comando sql
        Dim tabla As New DataTable
        Try
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion)
            'Creamos el objeto para el adaptador de datos
            Dim adaptador As New SqlDataAdapter(cmd)
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
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Public Function generar_DataTableT(comando_sql As String, ByRef dbtransac As SqlTransaction) As DataTable
        'Definos una tabla temporal
        'para guardar el resultado del comando sql
        Dim tabla As New DataTable
        Try
            'Vericamos si la conexión actual esta cerrada
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion, dbtransac)
            'Creamos el objeto para el adaptador de datos
            Dim adaptador As New SqlDataAdapter(cmd)
            'Llenamos el temporal con los resultados de la consulta
            adaptador.Fill(tabla)
            'Finalmente retornamos el resultado
            Return tabla
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    'Procedimiento para insertar, eliminar y actualizar 
    Public Sub EjecutarSQL(comando_sql As String, ParamArray Arrayparametros() As Object)
        Try
            'Abrimos la conexión si esta cerrada
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            'Creamos el objeto para el comando sql
            Dim cmd As New SqlCommand(comando_sql, conexion)
            'Recuperamos la lista de parametros del array
            For i As Integer = 1 To Arrayparametros.Length
                cmd.Parameters.AddWithValue("@" & i.ToString, Arrayparametros(i - 1))
            Next
            'Finalmente ejecutamos el comando sql
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EjecutarSQLT(instruccion_SQL As String, ByRef dbtransac As SqlTransaction, ParamArray parametros() As Object)
        Try
            Dim comando As New SqlCommand(instruccion_SQL, conexion, dbtransac)
            'cargar parámetros desde el array hacia la instrucción SQL
            For i As Integer = 1 To parametros.Length
                'nombre del parámetro y valor
                comando.Parameters.AddWithValue("@" & i.ToString(), parametros(i - 1))
            Next
            'ejecutar el comando
            comando.ExecuteNonQuery()
        Catch ex As Exception
            AnularTransaccion(dbtransac)
            Throw ex
        End Try
    End Sub
    'Función para iniciar una transacción
    Public Function IniciarTransaccion() As SqlTransaction
        Try
            'Iniciar y retornar una transacción

            Return conexion.BeginTransaction
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    'Procedimiento para anular una transacción
    Public Sub AnularTransaccion(ByRef dbt As SqlTransaction)
        Try
            dbt.Rollback()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ConfirmarTransaccion(ByRef dbt As SqlTransaction)
        Try
            'Confirmar la transacción
            dbt.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function TraerValor(comando_sql As String) As Object
        Try
            conexion.Open()
            Dim cmd As New SqlCommand(comando_sql, conexion)
            Return cmd.ExecuteScalar
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Public Function TraerValorT(instruccionSQL As String, ByRef dbtransac As SqlTransaction) As Object
        Try
            Dim cmd As New SqlCommand(instruccionSQL, conexion, dbtransac)
            'ExecuteScalar retorna el valor de la primera celda devuelta por la consulta.
            Return cmd.ExecuteScalar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Module
