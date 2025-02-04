<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLeaveEntitlement
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLeaveEntitlement))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CustomGroupBox2 = New HRM.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.gbox_filter = New HRM.CustomGroupBox
        Me.cmb_leavetype = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_filtername = New System.Windows.Forms.ComboBox
        Me.cmb_filterby = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_filtername = New System.Windows.Forms.Label
        Me.txt_filtername = New System.Windows.Forms.TextBox
        Me.txt_days = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Panel1.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        Me.gbox_filter.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CustomGroupBox2)
        Me.Panel1.Controls.Add(Me.gbox_filter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(451, 207)
        Me.Panel1.TabIndex = 2
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.SystemColors.Control
        Me.CustomGroupBox2.Controls.Add(Me.btn_next)
        Me.CustomGroupBox2.Controls.Add(Me.btn_save)
        Me.CustomGroupBox2.Controls.Add(Me.btn_close)
        Me.CustomGroupBox2.Location = New System.Drawing.Point(8, 149)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(436, 48)
        Me.CustomGroupBox2.TabIndex = 63
        Me.CustomGroupBox2.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(189, 13)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(93, 23)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(86, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(93, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(288, 13)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 23)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'gbox_filter
        '
        Me.gbox_filter.BorderColor = System.Drawing.SystemColors.Control
        Me.gbox_filter.Controls.Add(Me.cmb_leavetype)
        Me.gbox_filter.Controls.Add(Me.Label5)
        Me.gbox_filter.Controls.Add(Me.cmb_filtername)
        Me.gbox_filter.Controls.Add(Me.cmb_filterby)
        Me.gbox_filter.Controls.Add(Me.Label3)
        Me.gbox_filter.Controls.Add(Me.lbl_filtername)
        Me.gbox_filter.Controls.Add(Me.txt_filtername)
        Me.gbox_filter.Controls.Add(Me.txt_days)
        Me.gbox_filter.Controls.Add(Me.Label11)
        Me.gbox_filter.ForeColor = System.Drawing.SystemColors.Control
        Me.gbox_filter.Location = New System.Drawing.Point(8, 8)
        Me.gbox_filter.Name = "gbox_filter"
        Me.gbox_filter.Size = New System.Drawing.Size(436, 135)
        Me.gbox_filter.TabIndex = 62
        Me.gbox_filter.TabStop = False
        Me.gbox_filter.Text = "Leave Entitlement Details    "
        '
        'cmb_leavetype
        '
        Me.cmb_leavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_leavetype.FormattingEnabled = True
        Me.cmb_leavetype.Items.AddRange(New Object() {"Employee ID", "Employee Category", "Employee Type", "Employee Grade", "Employee Sex", "Employee Blood Group", "Employee Religion", "Employee Marital Status", "Employee Nationality", "Employee Recruitment Mode", "Employee Branch", "Employee Department", "Employee Designation", "Employee Reporting Boss", "None"})
        Me.cmb_leavetype.Location = New System.Drawing.Point(149, 71)
        Me.cmb_leavetype.Name = "cmb_leavetype"
        Me.cmb_leavetype.Size = New System.Drawing.Size(224, 21)
        Me.cmb_leavetype.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "LeaveType"
        '
        'cmb_filtername
        '
        Me.cmb_filtername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtername.FormattingEnabled = True
        Me.cmb_filtername.Location = New System.Drawing.Point(149, 45)
        Me.cmb_filtername.Name = "cmb_filtername"
        Me.cmb_filtername.Size = New System.Drawing.Size(224, 21)
        Me.cmb_filtername.TabIndex = 112
        '
        'cmb_filterby
        '
        Me.cmb_filterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filterby.FormattingEnabled = True
        Me.cmb_filterby.Items.AddRange(New Object() {"Employee ID", "Employee Category", "Employee Type", "Employee Grade", "Employee Sex", "Employee Blood Group", "Employee Religion", "Employee Marital Status", "Employee Nationality", "Employee Recruitment Mode", "Employee Branch", "Employee Department", "Employee Designation", "Employee Reporting Boss", "All"})
        Me.cmb_filterby.Location = New System.Drawing.Point(149, 19)
        Me.cmb_filterby.Name = "cmb_filterby"
        Me.cmb_filterby.Size = New System.Drawing.Size(224, 21)
        Me.cmb_filterby.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Entitle By"
        '
        'lbl_filtername
        '
        Me.lbl_filtername.AutoSize = True
        Me.lbl_filtername.Location = New System.Drawing.Point(17, 48)
        Me.lbl_filtername.Name = "lbl_filtername"
        Me.lbl_filtername.Size = New System.Drawing.Size(67, 13)
        Me.lbl_filtername.TabIndex = 114
        Me.lbl_filtername.Text = "Employee ID"
        '
        'txt_filtername
        '
        Me.txt_filtername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_filtername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_filtername.Location = New System.Drawing.Point(149, 46)
        Me.txt_filtername.Name = "txt_filtername"
        Me.txt_filtername.Size = New System.Drawing.Size(251, 20)
        Me.txt_filtername.TabIndex = 113
        '
        'txt_days
        '
        Me.txt_days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_days.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_days.Location = New System.Drawing.Point(149, 98)
        Me.txt_days.Name = "txt_days"
        Me.txt_days.Size = New System.Drawing.Size(226, 20)
        Me.txt_days.TabIndex = 107
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Days Entitled"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer)))
        '
        'AddLeaveEntitlement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 207)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddLeaveEntitlement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee Leave Entitlement"
        Me.Panel1.ResumeLayout(False)
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.gbox_filter.ResumeLayout(False)
        Me.gbox_filter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_leavetype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_filtername As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_filterby As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_filtername As System.Windows.Forms.Label
    Friend WithEvents gbox_filter As HRM.CustomGroupBox
    Friend WithEvents txt_filtername As System.Windows.Forms.TextBox
    Friend WithEvents txt_days As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CustomGroupBox2 As HRM.CustomGroupBox
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
