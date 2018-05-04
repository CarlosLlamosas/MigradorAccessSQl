<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnMigrar = New System.Windows.Forms.Button()
        Me.lblconta = New System.Windows.Forms.Label()
        Me.txtPers = New System.Windows.Forms.TextBox()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl = New System.Windows.Forms.Label()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.Location = New System.Drawing.Point(355, 7)
        Me.lblConexion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(39, 13)
        Me.lblConexion.TabIndex = 0
        Me.lblConexion.Text = "Label1"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(84, 17)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(84, 46)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaFin.TabIndex = 2
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(27, 21)
        Me.lblInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(38, 13)
        Me.lblInicio.TabIndex = 3
        Me.lblInicio.Text = "Desde"
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Location = New System.Drawing.Point(27, 50)
        Me.lblFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(35, 13)
        Me.lblFin.TabIndex = 4
        Me.lblFin.Text = "Hasta"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(201, 61)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 28)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(19, 98)
        Me.dgvDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.Size = New System.Drawing.Size(387, 121)
        Me.dgvDatos.TabIndex = 6
        '
        'btnMigrar
        '
        Me.btnMigrar.Location = New System.Drawing.Point(291, 61)
        Me.btnMigrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMigrar.Name = "btnMigrar"
        Me.btnMigrar.Size = New System.Drawing.Size(56, 28)
        Me.btnMigrar.TabIndex = 7
        Me.btnMigrar.Text = "Migrar"
        Me.btnMigrar.UseVisualStyleBackColor = True
        '
        'lblconta
        '
        Me.lblconta.AutoSize = True
        Me.lblconta.Location = New System.Drawing.Point(373, 45)
        Me.lblconta.Name = "lblconta"
        Me.lblconta.Size = New System.Drawing.Size(13, 13)
        Me.lblconta.TabIndex = 8
        Me.lblconta.Text = "0"
        '
        'txtPers
        '
        Me.txtPers.Location = New System.Drawing.Point(84, 71)
        Me.txtPers.Name = "txtPers"
        Me.txtPers.Size = New System.Drawing.Size(76, 20)
        Me.txtPers.TabIndex = 9
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(27, 74)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(22, 13)
        Me.lblPin.TabIndex = 10
        Me.lblPin.Text = "Pin"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(19, 236)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 11
        Me.lbl.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 261)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.txtPers)
        Me.Controls.Add(Me.lblconta)
        Me.Controls.Add(Me.btnMigrar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblFin)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblConexion)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migrador"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConexion As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblInicio As Label
    Friend WithEvents lblFin As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnMigrar As Button
    Friend WithEvents lblconta As Label
    Friend WithEvents txtPers As TextBox
    Friend WithEvents lblPin As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl As Label
End Class
