Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Access.source = OpenFileDialog1.FileName
            'lbl.Text = CStr(Application.StartupPath)
            Access.enlace()
            lblConexion.Text = estado
        End If
        LeerArchivo()
        lbl.Text = CStr(conexion.ConnectionString)
        btnMigrar.Visible = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Access.conex.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'comando = New OleDb.OleDbCommand("SELECT CHECKINOUT.USERID, USERINFO.NAME, CHECKINOUT.CHECKTIME FROM CHECKINOUT INNER JOIN USERINFO ON CHECKINOUT.USERID = USERINFO.USERID WHERE (((CHECKINOUT.CHECKTIME)>#" & CDate(dtpFechaFin.Value) & "# And (CHECKINOUT.CHECKTIME)<#" & CDate(dtpFechaFin.Value) & "#));")

        Try
            If txtPers.Text <> "" Then
                dgvDatos.DataSource = genTabla("SELECT CHECKINOUT.USERID, USERINFO.NAME, CHECKINOUT.CHECKTIME FROM CHECKINOUT INNER JOIN USERINFO ON CHECKINOUT.USERID = USERINFO.USERID WHERE (((CHECKINOUT.CHECKTIME)>#" & CStr(dtpFechaInicio.Value) & "# And (CHECKINOUT.CHECKTIME)<#" & CStr(dtpFechaFin.Value) & "#) and (CHECKINOUT.USERID) like '" & CStr(txtPers.Text) & "');")
                lblconta.Text = dgvDatos.RowCount
            Else
                dgvDatos.DataSource = genTabla("SELECT CHECKINOUT.USERID, USERINFO.NAME, CHECKINOUT.CHECKTIME FROM CHECKINOUT INNER JOIN USERINFO ON CHECKINOUT.USERID = USERINFO.USERID WHERE (((CHECKINOUT.CHECKTIME)>#" & CStr(dtpFechaInicio.Value) & "# And (CHECKINOUT.CHECKTIME)<#" & CStr(dtpFechaFin.Value) & "#));")
                lblconta.Text = dgvDatos.RowCount
            End If

            btnMigrar.Visible = True
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub btnMigrar_Click(sender As Object, e As EventArgs) Handles btnMigrar.Click
        Dim agregar As SqlCommand = New SqlCommand("insert into HORABIO(PIN,NAME,CHECKTIME) values (@pin,@name,@time)", conexion)
        conexion.Open()
        'Dim vec As String()
        'Dim c As Integer = 0
        Dim fila As DataTable = genTabla("SELECT CHECKINOUT.USERID, USERINFO.NAME, CHECKINOUT.CHECKTIME FROM CHECKINOUT INNER JOIN USERINFO ON CHECKINOUT.USERID = USERINFO.USERID WHERE (((CHECKINOUT.CHECKTIME)>#" & CStr(dtpFechaInicio.Value) & "# And (CHECKINOUT.CHECKTIME)<#" & CStr(dtpFechaFin.Value) & "#));")
        Try
            'For c As Integer = 0 To dgvDatos.RowCount
            For Each row As DataGridViewRow In dgvDatos.Rows
                If String.IsNullOrEmpty(CStr(row.Cells("USERID").Value)) Or
                        String.IsNullOrEmpty(CStr(row.Cells("USERID").Value)) Then
                    Continue For
                End If
                agregar.Parameters.Clear()
                'MsgBox(CStr(fila.Rows(c).Item("USERID")) & " - " & CStr(fila.Rows(c).Item("NAME")) & " - " & CStr(fila.Rows(c).Item("CHECKTIME")) & " - " & c)
                agregar.Parameters.AddWithValue("@pin", CStr(row.Cells("USERID").Value))
                agregar.Parameters.AddWithValue("@name", CStr(row.Cells("NAME").Value))
                agregar.Parameters.AddWithValue("@time", CStr(row.Cells("CHECKTIME").Value))
                Dim consulta As DataTable = generar_DataTable("select PIN,NAME,CHECKTIME from HORABIO where PIN ='" & CStr(row.Cells("USERID").Value) & "' and CHECKTIME = '" & CStr(row.Cells("CHECKTIME").Value) & "'")

                If (consulta.Rows.Count = 0) Then
                    agregar.ExecuteNonQuery()
                End If

            Next
            MsgBox("Fin de la migración")
            'While c <= CInt(lblconta.Text)
            '    ReDim Preserve vec(c)
            '    vec(c) = ((fila.Rows(c).Item("USERID")) & (fila.Rows(c).Item("NAME")) & (fila.Rows(c).Item("CHECKTIME")))
            '    agregar.Parameters.Clear()
            '    agregar.Parameters.AddWithValue("@pin", (fila.Rows(c).Item("USERID")))
            '    agregar.Parameters.AddWithValue("@name", (fila.Rows(c).Item("NAME")))
            '    agregar.Parameters.AddWithValue("@time", (fila.Rows(c).Item("CHECKTIME")))
            '    agregar.ExecuteNonQuery()
            '    c = c + 1
            'End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
