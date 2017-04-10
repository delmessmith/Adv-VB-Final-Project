<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMileageTrackerNewEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEndOdometer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBeginOdometer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboVehicle = New System.Windows.Forms.ComboBox()
        Me.cboEmployee = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.chkGasPurchase = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtEndOdometer
        '
        Me.txtEndOdometer.Location = New System.Drawing.Point(126, 129)
        Me.txtEndOdometer.Name = "txtEndOdometer"
        Me.txtEndOdometer.Size = New System.Drawing.Size(121, 20)
        Me.txtEndOdometer.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Ending Odometer:"
        '
        'txtBeginOdometer
        '
        Me.txtBeginOdometer.Location = New System.Drawing.Point(126, 103)
        Me.txtBeginOdometer.Name = "txtBeginOdometer"
        Me.txtBeginOdometer.Size = New System.Drawing.Size(121, 20)
        Me.txtBeginOdometer.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Beginning Odometer:"
        '
        'cboVehicle
        '
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Location = New System.Drawing.Point(126, 50)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(121, 21)
        Me.cboVehicle.TabIndex = 21
        '
        'cboEmployee
        '
        Me.cboEmployee.Enabled = False
        Me.cboEmployee.FormattingEnabled = True
        Me.cboEmployee.Location = New System.Drawing.Point(126, 21)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(121, 21)
        Me.cboEmployee.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Vehicle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Employee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(126, 77)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpDate.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(129, 203)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(48, 203)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chkGasPurchase
        '
        Me.chkGasPurchase.AutoSize = True
        Me.chkGasPurchase.Location = New System.Drawing.Point(15, 164)
        Me.chkGasPurchase.Name = "chkGasPurchase"
        Me.chkGasPurchase.Size = New System.Drawing.Size(132, 17)
        Me.chkGasPurchase.TabIndex = 26
        Me.chkGasPurchase.Text = "Gas Purchased Today"
        Me.chkGasPurchase.UseVisualStyleBackColor = True
        '
        'frmMileageTrackerNewEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 261)
        Me.Controls.Add(Me.chkGasPurchase)
        Me.Controls.Add(Me.txtEndOdometer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBeginOdometer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboVehicle)
        Me.Controls.Add(Me.cboEmployee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmMileageTrackerNewEntry"
        Me.Text = "Log Miles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEndOdometer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBeginOdometer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboVehicle As ComboBox
    Friend WithEvents cboEmployee As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents chkGasPurchase As CheckBox
End Class
