<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasks
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
        Me.addEventBtn = New System.Windows.Forms.Button()
        Me.satTabPage = New System.Windows.Forms.TabPage()
        Me.satList = New System.Windows.Forms.ListBox()
        Me.friTabPage = New System.Windows.Forms.TabPage()
        Me.friList = New System.Windows.Forms.ListBox()
        Me.thurTabPage = New System.Windows.Forms.TabPage()
        Me.thurList = New System.Windows.Forms.ListBox()
        Me.wedTabPage = New System.Windows.Forms.TabPage()
        Me.wedList = New System.Windows.Forms.ListBox()
        Me.tueTabPage = New System.Windows.Forms.TabPage()
        Me.tueList = New System.Windows.Forms.ListBox()
        Me.monTabPage = New System.Windows.Forms.TabPage()
        Me.monList = New System.Windows.Forms.ListBox()
        Me.sunTabPage = New System.Windows.Forms.TabPage()
        Me.sunList = New System.Windows.Forms.ListBox()
        Me.WeekTabs = New System.Windows.Forms.TabControl()
        Me.satTabPage.SuspendLayout()
        Me.friTabPage.SuspendLayout()
        Me.thurTabPage.SuspendLayout()
        Me.wedTabPage.SuspendLayout()
        Me.tueTabPage.SuspendLayout()
        Me.monTabPage.SuspendLayout()
        Me.sunTabPage.SuspendLayout()
        Me.WeekTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'addEventBtn
        '
        Me.addEventBtn.Location = New System.Drawing.Point(320, 0)
        Me.addEventBtn.Name = "addEventBtn"
        Me.addEventBtn.Size = New System.Drawing.Size(57, 19)
        Me.addEventBtn.TabIndex = 1
        Me.addEventBtn.Text = "+"
        Me.addEventBtn.UseVisualStyleBackColor = True
        '
        'satTabPage
        '
        Me.satTabPage.Controls.Add(Me.satList)
        Me.satTabPage.Location = New System.Drawing.Point(4, 22)
        Me.satTabPage.Name = "satTabPage"
        Me.satTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.satTabPage.Size = New System.Drawing.Size(593, 345)
        Me.satTabPage.TabIndex = 6
        Me.satTabPage.Text = "Saturday"
        Me.satTabPage.UseVisualStyleBackColor = True
        '
        'satList
        '
        Me.satList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.satList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.satList.FormattingEnabled = True
        Me.satList.ItemHeight = 45
        Me.satList.Location = New System.Drawing.Point(110, 48)
        Me.satList.Name = "satList"
        Me.satList.Size = New System.Drawing.Size(345, 225)
        Me.satList.TabIndex = 2
        '
        'friTabPage
        '
        Me.friTabPage.Controls.Add(Me.friList)
        Me.friTabPage.Location = New System.Drawing.Point(4, 22)
        Me.friTabPage.Name = "friTabPage"
        Me.friTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.friTabPage.Size = New System.Drawing.Size(593, 345)
        Me.friTabPage.TabIndex = 5
        Me.friTabPage.Text = "Friday"
        Me.friTabPage.UseVisualStyleBackColor = True
        '
        'friList
        '
        Me.friList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.friList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.friList.FormattingEnabled = True
        Me.friList.ItemHeight = 45
        Me.friList.Location = New System.Drawing.Point(110, 48)
        Me.friList.Name = "friList"
        Me.friList.Size = New System.Drawing.Size(345, 225)
        Me.friList.TabIndex = 2
        '
        'thurTabPage
        '
        Me.thurTabPage.Controls.Add(Me.thurList)
        Me.thurTabPage.Location = New System.Drawing.Point(4, 22)
        Me.thurTabPage.Name = "thurTabPage"
        Me.thurTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.thurTabPage.Size = New System.Drawing.Size(593, 345)
        Me.thurTabPage.TabIndex = 4
        Me.thurTabPage.Text = "Thursday"
        Me.thurTabPage.UseVisualStyleBackColor = True
        '
        'thurList
        '
        Me.thurList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.thurList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.thurList.FormattingEnabled = True
        Me.thurList.ItemHeight = 45
        Me.thurList.Location = New System.Drawing.Point(110, 48)
        Me.thurList.Name = "thurList"
        Me.thurList.Size = New System.Drawing.Size(345, 225)
        Me.thurList.TabIndex = 2
        '
        'wedTabPage
        '
        Me.wedTabPage.Controls.Add(Me.wedList)
        Me.wedTabPage.Location = New System.Drawing.Point(4, 22)
        Me.wedTabPage.Name = "wedTabPage"
        Me.wedTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.wedTabPage.Size = New System.Drawing.Size(593, 345)
        Me.wedTabPage.TabIndex = 3
        Me.wedTabPage.Text = "Wednesday"
        Me.wedTabPage.UseVisualStyleBackColor = True
        '
        'wedList
        '
        Me.wedList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wedList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.wedList.FormattingEnabled = True
        Me.wedList.ItemHeight = 45
        Me.wedList.Location = New System.Drawing.Point(110, 48)
        Me.wedList.Name = "wedList"
        Me.wedList.Size = New System.Drawing.Size(345, 225)
        Me.wedList.TabIndex = 2
        '
        'tueTabPage
        '
        Me.tueTabPage.Controls.Add(Me.tueList)
        Me.tueTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tueTabPage.Name = "tueTabPage"
        Me.tueTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tueTabPage.Size = New System.Drawing.Size(593, 345)
        Me.tueTabPage.TabIndex = 2
        Me.tueTabPage.Text = "Tuesday"
        Me.tueTabPage.UseVisualStyleBackColor = True
        '
        'tueList
        '
        Me.tueList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tueList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.tueList.FormattingEnabled = True
        Me.tueList.ItemHeight = 45
        Me.tueList.Location = New System.Drawing.Point(110, 48)
        Me.tueList.Name = "tueList"
        Me.tueList.Size = New System.Drawing.Size(345, 225)
        Me.tueList.TabIndex = 2
        '
        'monTabPage
        '
        Me.monTabPage.Controls.Add(Me.monList)
        Me.monTabPage.Location = New System.Drawing.Point(4, 22)
        Me.monTabPage.Name = "monTabPage"
        Me.monTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.monTabPage.Size = New System.Drawing.Size(593, 345)
        Me.monTabPage.TabIndex = 1
        Me.monTabPage.Text = "Monday"
        Me.monTabPage.UseVisualStyleBackColor = True
        '
        'monList
        '
        Me.monList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.monList.FormattingEnabled = True
        Me.monList.ItemHeight = 45
        Me.monList.Location = New System.Drawing.Point(110, 48)
        Me.monList.Name = "monList"
        Me.monList.Size = New System.Drawing.Size(345, 225)
        Me.monList.TabIndex = 1
        '
        'sunTabPage
        '
        Me.sunTabPage.Controls.Add(Me.sunList)
        Me.sunTabPage.Location = New System.Drawing.Point(4, 22)
        Me.sunTabPage.Name = "sunTabPage"
        Me.sunTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.sunTabPage.Size = New System.Drawing.Size(593, 345)
        Me.sunTabPage.TabIndex = 0
        Me.sunTabPage.Text = "Sunday"
        Me.sunTabPage.UseVisualStyleBackColor = True
        '
        'sunList
        '
        Me.sunList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sunList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.sunList.FormattingEnabled = True
        Me.sunList.ItemHeight = 45
        Me.sunList.Location = New System.Drawing.Point(110, 48)
        Me.sunList.Name = "sunList"
        Me.sunList.Size = New System.Drawing.Size(345, 180)
        Me.sunList.TabIndex = 0
        '
        'WeekTabs
        '
        Me.WeekTabs.Controls.Add(Me.sunTabPage)
        Me.WeekTabs.Controls.Add(Me.monTabPage)
        Me.WeekTabs.Controls.Add(Me.tueTabPage)
        Me.WeekTabs.Controls.Add(Me.wedTabPage)
        Me.WeekTabs.Controls.Add(Me.thurTabPage)
        Me.WeekTabs.Controls.Add(Me.friTabPage)
        Me.WeekTabs.Controls.Add(Me.satTabPage)
        Me.WeekTabs.Location = New System.Drawing.Point(0, 38)
        Me.WeekTabs.Name = "WeekTabs"
        Me.WeekTabs.SelectedIndex = 0
        Me.WeekTabs.Size = New System.Drawing.Size(601, 371)
        Me.WeekTabs.TabIndex = 0
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 408)
        Me.Controls.Add(Me.addEventBtn)
        Me.Controls.Add(Me.WeekTabs)
        Me.Name = "Tasks"
        Me.Text = "Tasks"
        Me.satTabPage.ResumeLayout(False)
        Me.friTabPage.ResumeLayout(False)
        Me.thurTabPage.ResumeLayout(False)
        Me.wedTabPage.ResumeLayout(False)
        Me.tueTabPage.ResumeLayout(False)
        Me.monTabPage.ResumeLayout(False)
        Me.sunTabPage.ResumeLayout(False)
        Me.WeekTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addEventBtn As Button
    Friend WithEvents satTabPage As TabPage
    Friend WithEvents friTabPage As TabPage
    Friend WithEvents friList As ListBox
    Friend WithEvents thurTabPage As TabPage
    Friend WithEvents thurList As ListBox
    Friend WithEvents wedTabPage As TabPage
    Friend WithEvents wedList As ListBox
    Friend WithEvents tueTabPage As TabPage
    Friend WithEvents tueList As ListBox
    Friend WithEvents monTabPage As TabPage
    Friend WithEvents monList As ListBox
    Friend WithEvents sunTabPage As TabPage
    Friend WithEvents sunList As ListBox
    Friend WithEvents WeekTabs As TabControl
    Friend WithEvents satList As ListBox
End Class
