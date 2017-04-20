<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMileageTrackerViewAll
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvMilesDriven = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GasPurchasesDataSet = New VB_Final_Project.GasPurchasesDataSet()
        Me.MilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MilesTableAdapter = New VB_Final_Project.GasPurchasesDataSetTableAdapters.MilesTableAdapter()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginOdometerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndOdometerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMilesDriven, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GasPurchasesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(642, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'dgvMilesDriven
        '
        Me.dgvMilesDriven.AutoGenerateColumns = False
        Me.dgvMilesDriven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMilesDriven.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeDataGridViewTextBoxColumn, Me.VehicleDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.BeginOdometerDataGridViewTextBoxColumn, Me.EndOdometerDataGridViewTextBoxColumn, Me.MilesDataGridViewTextBoxColumn})
        Me.dgvMilesDriven.DataSource = Me.MilesBindingSource
        Me.dgvMilesDriven.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMilesDriven.Location = New System.Drawing.Point(0, 24)
        Me.dgvMilesDriven.Name = "dgvMilesDriven"
        Me.dgvMilesDriven.Size = New System.Drawing.Size(642, 262)
        Me.dgvMilesDriven.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 264)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(642, 22)
        Me.StatusStrip1.TabIndex = 4
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
        'MilesBindingSource
        '
        Me.MilesBindingSource.DataMember = "Miles"
        Me.MilesBindingSource.DataSource = Me.GasPurchasesDataSet
        '
        'MilesTableAdapter
        '
        Me.MilesTableAdapter.ClearBeforeFill = True
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        '
        'VehicleDataGridViewTextBoxColumn
        '
        Me.VehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle"
        Me.VehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle"
        Me.VehicleDataGridViewTextBoxColumn.Name = "VehicleDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'BeginOdometerDataGridViewTextBoxColumn
        '
        Me.BeginOdometerDataGridViewTextBoxColumn.DataPropertyName = "BeginOdometer"
        Me.BeginOdometerDataGridViewTextBoxColumn.HeaderText = "Begin Odometer"
        Me.BeginOdometerDataGridViewTextBoxColumn.Name = "BeginOdometerDataGridViewTextBoxColumn"
        '
        'EndOdometerDataGridViewTextBoxColumn
        '
        Me.EndOdometerDataGridViewTextBoxColumn.DataPropertyName = "EndOdometer"
        Me.EndOdometerDataGridViewTextBoxColumn.HeaderText = "End Odometer"
        Me.EndOdometerDataGridViewTextBoxColumn.Name = "EndOdometerDataGridViewTextBoxColumn"
        '
        'MilesDataGridViewTextBoxColumn
        '
        Me.MilesDataGridViewTextBoxColumn.DataPropertyName = "Miles"
        Me.MilesDataGridViewTextBoxColumn.HeaderText = "Miles"
        Me.MilesDataGridViewTextBoxColumn.Name = "MilesDataGridViewTextBoxColumn"
        '
        'frmMileageTrackerViewAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 286)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvMilesDriven)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMileageTrackerViewAll"
        Me.Text = "Miles Driven"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMilesDriven, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GasPurchasesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents dgvMilesDriven As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents GasPurchasesDataSet As GasPurchasesDataSet
    Friend WithEvents MilesBindingSource As BindingSource
    Friend WithEvents MilesTableAdapter As GasPurchasesDataSetTableAdapters.MilesTableAdapter
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeginOdometerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndOdometerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
