<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasTrackerViewAll
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvGasPurchases = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GasPurchasesDataSet = New VB_Final_Project.GasPurchasesDataSet()
        Me.GasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GasTableAdapter = New VB_Final_Project.GasPurchasesDataSetTableAdapters.GasTableAdapter()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GasStationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvGasPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GasPurchasesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGasPurchases
        '
        Me.dgvGasPurchases.AllowUserToAddRows = False
        Me.dgvGasPurchases.AllowUserToDeleteRows = False
        Me.dgvGasPurchases.AutoGenerateColumns = False
        Me.dgvGasPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGasPurchases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeDataGridViewTextBoxColumn, Me.VehicleDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.PurchaseAmountDataGridViewTextBoxColumn, Me.GasStationDataGridViewTextBoxColumn, Me.ReceiptNumberDataGridViewTextBoxColumn})
        Me.dgvGasPurchases.DataSource = Me.GasBindingSource
        Me.dgvGasPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGasPurchases.Location = New System.Drawing.Point(0, 24)
        Me.dgvGasPurchases.Name = "dgvGasPurchases"
        Me.dgvGasPurchases.ReadOnly = True
        Me.dgvGasPurchases.Size = New System.Drawing.Size(644, 261)
        Me.dgvGasPurchases.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuFileClose.Text = "Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(644, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GasPurchasesDataSet
        '
        Me.GasPurchasesDataSet.DataSetName = "GasPurchasesDataSet"
        Me.GasPurchasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GasBindingSource
        '
        Me.GasBindingSource.DataMember = "Gas"
        Me.GasBindingSource.DataSource = Me.GasPurchasesDataSet
        '
        'GasTableAdapter
        '
        Me.GasTableAdapter.ClearBeforeFill = True
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "Employee"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.EmployeeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        Me.EmployeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleDataGridViewTextBoxColumn
        '
        Me.VehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle"
        Me.VehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle"
        Me.VehicleDataGridViewTextBoxColumn.Name = "VehicleDataGridViewTextBoxColumn"
        Me.VehicleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseAmountDataGridViewTextBoxColumn
        '
        Me.PurchaseAmountDataGridViewTextBoxColumn.DataPropertyName = "PurchaseAmount"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "-"
        Me.PurchaseAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PurchaseAmountDataGridViewTextBoxColumn.HeaderText = "Purchase Amount"
        Me.PurchaseAmountDataGridViewTextBoxColumn.Name = "PurchaseAmountDataGridViewTextBoxColumn"
        Me.PurchaseAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GasStationDataGridViewTextBoxColumn
        '
        Me.GasStationDataGridViewTextBoxColumn.DataPropertyName = "GasStation"
        Me.GasStationDataGridViewTextBoxColumn.HeaderText = "Gas Station"
        Me.GasStationDataGridViewTextBoxColumn.Name = "GasStationDataGridViewTextBoxColumn"
        Me.GasStationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReceiptNumberDataGridViewTextBoxColumn
        '
        Me.ReceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNumber"
        Me.ReceiptNumberDataGridViewTextBoxColumn.HeaderText = "Receipt Number"
        Me.ReceiptNumberDataGridViewTextBoxColumn.Name = "ReceiptNumberDataGridViewTextBoxColumn"
        Me.ReceiptNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmGasTrackerViewAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 285)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvGasPurchases)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGasTrackerViewAll"
        Me.Text = "Gas Purchases"
        CType(Me.dgvGasPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GasPurchasesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGasPurchases As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents GasPurchasesDataSet As GasPurchasesDataSet
    Friend WithEvents GasBindingSource As BindingSource
    Friend WithEvents GasTableAdapter As GasPurchasesDataSetTableAdapters.GasTableAdapter
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GasStationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
