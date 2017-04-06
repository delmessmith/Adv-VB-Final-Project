<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGasTracker = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGasTrackerAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGasTrackerViewAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMileTracker = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMileTrackerAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMileTrackerViewAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del's Gas and Mileage Tracker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Created by Del Smith"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuGasTracker, Me.mnuMileTracker, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(546, 24)
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
        'mnuGasTracker
        '
        Me.mnuGasTracker.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGasTrackerAddNew, Me.mnuGasTrackerViewAll, Me.GenerateReportToolStripMenuItem})
        Me.mnuGasTracker.Name = "mnuGasTracker"
        Me.mnuGasTracker.Size = New System.Drawing.Size(79, 20)
        Me.mnuGasTracker.Text = "Gas Tracker"
        '
        'mnuGasTrackerAddNew
        '
        Me.mnuGasTrackerAddNew.Name = "mnuGasTrackerAddNew"
        Me.mnuGasTrackerAddNew.Size = New System.Drawing.Size(159, 22)
        Me.mnuGasTrackerAddNew.Text = "Add New Entry"
        '
        'mnuGasTrackerViewAll
        '
        Me.mnuGasTrackerViewAll.Name = "mnuGasTrackerViewAll"
        Me.mnuGasTrackerViewAll.Size = New System.Drawing.Size(159, 22)
        Me.mnuGasTrackerViewAll.Text = "View All"
        '
        'mnuMileTracker
        '
        Me.mnuMileTracker.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMileTrackerAddNew, Me.mnuMileTrackerViewAll, Me.GenerateReportToolStripMenuItem1})
        Me.mnuMileTracker.Name = "mnuMileTracker"
        Me.mnuMileTracker.Size = New System.Drawing.Size(102, 20)
        Me.mnuMileTracker.Text = "Mileage Tracker"
        '
        'mnuMileTrackerAddNew
        '
        Me.mnuMileTrackerAddNew.Name = "mnuMileTrackerAddNew"
        Me.mnuMileTrackerAddNew.Size = New System.Drawing.Size(159, 22)
        Me.mnuMileTrackerAddNew.Text = "Add New Entry"
        '
        'mnuMileTrackerViewAll
        '
        Me.mnuMileTrackerViewAll.Name = "mnuMileTrackerViewAll"
        Me.mnuMileTrackerViewAll.Size = New System.Drawing.Size(159, 22)
        Me.mnuMileTrackerViewAll.Text = "View All"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'GenerateReportToolStripMenuItem
        '
        Me.GenerateReportToolStripMenuItem.Name = "GenerateReportToolStripMenuItem"
        Me.GenerateReportToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerateReportToolStripMenuItem.Text = "Generate Report"
        '
        'GenerateReportToolStripMenuItem1
        '
        Me.GenerateReportToolStripMenuItem1.Name = "GenerateReportToolStripMenuItem1"
        Me.GenerateReportToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.GenerateReportToolStripMenuItem1.Text = "Generate Report"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 176)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Del's Gas and Mileage Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuGasTracker As ToolStripMenuItem
    Friend WithEvents mnuGasTrackerAddNew As ToolStripMenuItem
    Friend WithEvents mnuGasTrackerViewAll As ToolStripMenuItem
    Friend WithEvents mnuMileTracker As ToolStripMenuItem
    Friend WithEvents mnuMileTrackerAddNew As ToolStripMenuItem
    Friend WithEvents mnuMileTrackerViewAll As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateReportToolStripMenuItem1 As ToolStripMenuItem
End Class
