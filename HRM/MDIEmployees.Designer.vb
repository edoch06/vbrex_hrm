<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIEmployees
    'Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIEmployees))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empdetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_regnewemp = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_editemployee = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_emptitle = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empcategory = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_emptype = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empgrade = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empworkstation = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empguardian = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empsex = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empbloodgroup = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empreligion = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empnationationality = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empdepts = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_emprecruitment = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empbranch = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empdesignation = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empboss = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_uploadempmaster = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empshifts = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_timeshiftatten = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_dailyatten = New System.Windows.Forms.ToolStripMenuItem
        Me.LeavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeLeavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeaveApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayRollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalaryStructureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeaveDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecruitmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecruitmentDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoanApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeTrainingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_empdetailsreports = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ts_reportattentshift = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_dailyattenreport = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.RecriutmentReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayrollToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_companydetails = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_dbconn = New System.Windows.Forms.ToolStripMenuItem
        Me.ts_countries = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.ts_masterleaveentitle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.LeavesToolStripMenuItem, Me.PayRollToolStripMenuItem, Me.RecruitmentToolStripMenuItem, Me.LoanToolStripMenuItem, Me.TrainingsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_empdetails, Me.ts_regnewemp, Me.ts_editemployee, Me.ToolStripSeparator1, Me.ts_emptitle, Me.ts_empcategory, Me.ts_emptype, Me.ts_empgrade, Me.ts_empworkstation, Me.ts_empguardian, Me.ts_empsex, Me.ts_empbloodgroup, Me.ts_empreligion, Me.ts_empnationationality, Me.ts_empdepts, Me.ts_emprecruitment, Me.ts_empbranch, Me.ts_empdesignation, Me.ts_empboss, Me.ToolStripSeparator2, Me.ts_uploadempmaster})
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EmployeesToolStripMenuItem.Text = "&Employees"
        '
        'ts_empdetails
        '
        Me.ts_empdetails.Name = "ts_empdetails"
        Me.ts_empdetails.Size = New System.Drawing.Size(267, 22)
        Me.ts_empdetails.Text = "&Registered Employee Details"
        '
        'ts_regnewemp
        '
        Me.ts_regnewemp.Name = "ts_regnewemp"
        Me.ts_regnewemp.Size = New System.Drawing.Size(267, 22)
        Me.ts_regnewemp.Text = "&Register New Employee"
        '
        'ts_editemployee
        '
        Me.ts_editemployee.Name = "ts_editemployee"
        Me.ts_editemployee.Size = New System.Drawing.Size(267, 22)
        Me.ts_editemployee.Text = "&Edit Employee"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(264, 6)
        '
        'ts_emptitle
        '
        Me.ts_emptitle.Name = "ts_emptitle"
        Me.ts_emptitle.Size = New System.Drawing.Size(267, 22)
        Me.ts_emptitle.Text = "&Master Title"
        '
        'ts_empcategory
        '
        Me.ts_empcategory.Name = "ts_empcategory"
        Me.ts_empcategory.Size = New System.Drawing.Size(267, 22)
        Me.ts_empcategory.Text = "&Master Employee Category"
        '
        'ts_emptype
        '
        Me.ts_emptype.Name = "ts_emptype"
        Me.ts_emptype.Size = New System.Drawing.Size(267, 22)
        Me.ts_emptype.Text = "&Master Employee Type"
        '
        'ts_empgrade
        '
        Me.ts_empgrade.Name = "ts_empgrade"
        Me.ts_empgrade.Size = New System.Drawing.Size(267, 22)
        Me.ts_empgrade.Text = "&Master Employee Grade"
        '
        'ts_empworkstation
        '
        Me.ts_empworkstation.Name = "ts_empworkstation"
        Me.ts_empworkstation.Size = New System.Drawing.Size(267, 22)
        Me.ts_empworkstation.Text = "&Master Employee Workstation"
        '
        'ts_empguardian
        '
        Me.ts_empguardian.Name = "ts_empguardian"
        Me.ts_empguardian.Size = New System.Drawing.Size(267, 22)
        Me.ts_empguardian.Text = "&Master Guardian Relationship"
        '
        'ts_empsex
        '
        Me.ts_empsex.Name = "ts_empsex"
        Me.ts_empsex.Size = New System.Drawing.Size(267, 22)
        Me.ts_empsex.Text = "&Master Employee Sex"
        '
        'ts_empbloodgroup
        '
        Me.ts_empbloodgroup.Name = "ts_empbloodgroup"
        Me.ts_empbloodgroup.Size = New System.Drawing.Size(267, 22)
        Me.ts_empbloodgroup.Text = "&Master Employee Blood Group"
        '
        'ts_empreligion
        '
        Me.ts_empreligion.Name = "ts_empreligion"
        Me.ts_empreligion.Size = New System.Drawing.Size(267, 22)
        Me.ts_empreligion.Text = "&Master Employee Religion"
        '
        'ts_empnationationality
        '
        Me.ts_empnationationality.Name = "ts_empnationationality"
        Me.ts_empnationationality.Size = New System.Drawing.Size(267, 22)
        Me.ts_empnationationality.Text = "&Master Employee Nationality"
        '
        'ts_empdepts
        '
        Me.ts_empdepts.Name = "ts_empdepts"
        Me.ts_empdepts.Size = New System.Drawing.Size(267, 22)
        Me.ts_empdepts.Text = "&Master Employee Departments"
        '
        'ts_emprecruitment
        '
        Me.ts_emprecruitment.Name = "ts_emprecruitment"
        Me.ts_emprecruitment.Size = New System.Drawing.Size(267, 22)
        Me.ts_emprecruitment.Text = "&Master Employee Recruitment Mode"
        '
        'ts_empbranch
        '
        Me.ts_empbranch.Name = "ts_empbranch"
        Me.ts_empbranch.Size = New System.Drawing.Size(267, 22)
        Me.ts_empbranch.Text = "&Master Employee Branch"
        '
        'ts_empdesignation
        '
        Me.ts_empdesignation.Name = "ts_empdesignation"
        Me.ts_empdesignation.Size = New System.Drawing.Size(267, 22)
        Me.ts_empdesignation.Text = "&Master Employee Designation"
        '
        'ts_empboss
        '
        Me.ts_empboss.Name = "ts_empboss"
        Me.ts_empboss.Size = New System.Drawing.Size(267, 22)
        Me.ts_empboss.Text = "&Master Employee Reporting Boss"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(264, 6)
        '
        'ts_uploadempmaster
        '
        Me.ts_uploadempmaster.Name = "ts_uploadempmaster"
        Me.ts_uploadempmaster.Size = New System.Drawing.Size(267, 22)
        Me.ts_uploadempmaster.Text = "&Upload Employee Master"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_timeshiftatten, Me.ts_dailyatten, Me.ToolStripSeparator5, Me.ts_empshifts})
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendanceToolStripMenuItem.Text = "&Attendance"
        '
        'ts_empshifts
        '
        Me.ts_empshifts.Name = "ts_empshifts"
        Me.ts_empshifts.Size = New System.Drawing.Size(219, 22)
        Me.ts_empshifts.Text = "&Master Employee Shift"
        '
        'ts_timeshiftatten
        '
        Me.ts_timeshiftatten.Name = "ts_timeshiftatten"
        Me.ts_timeshiftatten.Size = New System.Drawing.Size(219, 22)
        Me.ts_timeshiftatten.Text = "&Time Shift Attendance"
        '
        'ts_dailyatten
        '
        Me.ts_dailyatten.Name = "ts_dailyatten"
        Me.ts_dailyatten.Size = New System.Drawing.Size(219, 22)
        Me.ts_dailyatten.Text = "&Daily Employee Attendance"
        '
        'LeavesToolStripMenuItem
        '
        Me.LeavesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeLeavesToolStripMenuItem, Me.LeaveApplicationToolStripMenuItem, Me.ToolStripSeparator6, Me.ts_masterleaveentitle})
        Me.LeavesToolStripMenuItem.Name = "LeavesToolStripMenuItem"
        Me.LeavesToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.LeavesToolStripMenuItem.Text = "&Leaves"
        '
        'EmployeeLeavesToolStripMenuItem
        '
        Me.EmployeeLeavesToolStripMenuItem.Name = "EmployeeLeavesToolStripMenuItem"
        Me.EmployeeLeavesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EmployeeLeavesToolStripMenuItem.Text = "&Employee Leaves"
        '
        'LeaveApplicationToolStripMenuItem
        '
        Me.LeaveApplicationToolStripMenuItem.Name = "LeaveApplicationToolStripMenuItem"
        Me.LeaveApplicationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LeaveApplicationToolStripMenuItem.Text = "&Leave Application"
        '
        'PayRollToolStripMenuItem
        '
        Me.PayRollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalaryStructureToolStripMenuItem, Me.AttendanceDetailToolStripMenuItem, Me.LeaveDetailToolStripMenuItem})
        Me.PayRollToolStripMenuItem.Name = "PayRollToolStripMenuItem"
        Me.PayRollToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PayRollToolStripMenuItem.Text = "&PayRoll"
        '
        'SalaryStructureToolStripMenuItem
        '
        Me.SalaryStructureToolStripMenuItem.Name = "SalaryStructureToolStripMenuItem"
        Me.SalaryStructureToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SalaryStructureToolStripMenuItem.Text = "&Salary Structure"
        '
        'AttendanceDetailToolStripMenuItem
        '
        Me.AttendanceDetailToolStripMenuItem.Name = "AttendanceDetailToolStripMenuItem"
        Me.AttendanceDetailToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AttendanceDetailToolStripMenuItem.Text = "&Attendance Detail"
        '
        'LeaveDetailToolStripMenuItem
        '
        Me.LeaveDetailToolStripMenuItem.Name = "LeaveDetailToolStripMenuItem"
        Me.LeaveDetailToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LeaveDetailToolStripMenuItem.Text = "&Leave Detail"
        '
        'RecruitmentToolStripMenuItem
        '
        Me.RecruitmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem, Me.RecruitmentDetailToolStripMenuItem})
        Me.RecruitmentToolStripMenuItem.Name = "RecruitmentToolStripMenuItem"
        Me.RecruitmentToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.RecruitmentToolStripMenuItem.Text = "&Recruitment"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegisterToolStripMenuItem.Text = "&Register"
        '
        'RecruitmentDetailToolStripMenuItem
        '
        Me.RecruitmentDetailToolStripMenuItem.Name = "RecruitmentDetailToolStripMenuItem"
        Me.RecruitmentDetailToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RecruitmentDetailToolStripMenuItem.Text = "&Recruitment Detail"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeLoanToolStripMenuItem, Me.LoanApplicationToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.LoanToolStripMenuItem.Text = "&Loan"
        '
        'EmployeeLoanToolStripMenuItem
        '
        Me.EmployeeLoanToolStripMenuItem.Name = "EmployeeLoanToolStripMenuItem"
        Me.EmployeeLoanToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EmployeeLoanToolStripMenuItem.Text = "&Employee Loan"
        '
        'LoanApplicationToolStripMenuItem
        '
        Me.LoanApplicationToolStripMenuItem.Name = "LoanApplicationToolStripMenuItem"
        Me.LoanApplicationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LoanApplicationToolStripMenuItem.Text = "&Loan Application"
        '
        'TrainingsToolStripMenuItem
        '
        Me.TrainingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeTrainingsToolStripMenuItem, Me.TrainingEventsToolStripMenuItem})
        Me.TrainingsToolStripMenuItem.Name = "TrainingsToolStripMenuItem"
        Me.TrainingsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TrainingsToolStripMenuItem.Text = "&Trainings"
        '
        'EmployeeTrainingsToolStripMenuItem
        '
        Me.EmployeeTrainingsToolStripMenuItem.Name = "EmployeeTrainingsToolStripMenuItem"
        Me.EmployeeTrainingsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EmployeeTrainingsToolStripMenuItem.Text = "&Employee Trainings"
        '
        'TrainingEventsToolStripMenuItem
        '
        Me.TrainingEventsToolStripMenuItem.Name = "TrainingEventsToolStripMenuItem"
        Me.TrainingEventsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TrainingEventsToolStripMenuItem.Text = "&Training Events"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_empdetailsreports, Me.ToolStripSeparator3, Me.ts_reportattentshift, Me.ts_dailyattenreport, Me.ToolStripSeparator4, Me.RecriutmentReportsToolStripMenuItem, Me.PayrollToolStripMenuItem1, Me.TrainingReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'ts_empdetailsreports
        '
        Me.ts_empdetailsreports.Name = "ts_empdetailsreports"
        Me.ts_empdetailsreports.Size = New System.Drawing.Size(235, 22)
        Me.ts_empdetailsreports.Text = "&Employee Details Reports"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(232, 6)
        '
        'ts_reportattentshift
        '
        Me.ts_reportattentshift.Name = "ts_reportattentshift"
        Me.ts_reportattentshift.Size = New System.Drawing.Size(235, 22)
        Me.ts_reportattentshift.Text = "&Time Shift Attendance Reports"
        '
        'ts_dailyattenreport
        '
        Me.ts_dailyattenreport.Name = "ts_dailyattenreport"
        Me.ts_dailyattenreport.Size = New System.Drawing.Size(235, 22)
        Me.ts_dailyattenreport.Text = "&Daily Attendance Reports"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(232, 6)
        '
        'RecriutmentReportsToolStripMenuItem
        '
        Me.RecriutmentReportsToolStripMenuItem.Name = "RecriutmentReportsToolStripMenuItem"
        Me.RecriutmentReportsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RecriutmentReportsToolStripMenuItem.Text = "&Recruitment Reports"
        '
        'PayrollToolStripMenuItem1
        '
        Me.PayrollToolStripMenuItem1.Name = "PayrollToolStripMenuItem1"
        Me.PayrollToolStripMenuItem1.Size = New System.Drawing.Size(235, 22)
        Me.PayrollToolStripMenuItem1.Text = "&Payroll"
        '
        'TrainingReportsToolStripMenuItem
        '
        Me.TrainingReportsToolStripMenuItem.Name = "TrainingReportsToolStripMenuItem"
        Me.TrainingReportsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.TrainingReportsToolStripMenuItem.Text = "&Training Reports"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_companydetails, Me.ts_dbconn, Me.ts_countries})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ts_companydetails
        '
        Me.ts_companydetails.Name = "ts_companydetails"
        Me.ts_companydetails.Size = New System.Drawing.Size(192, 22)
        Me.ts_companydetails.Text = "&Company Details"
        '
        'ts_dbconn
        '
        Me.ts_dbconn.Name = "ts_dbconn"
        Me.ts_dbconn.Size = New System.Drawing.Size(192, 22)
        Me.ts_dbconn.Text = "&Database Connections"
        '
        'ts_countries
        '
        Me.ts_countries.Name = "ts_countries"
        Me.ts_countries.Size = New System.Drawing.Size(192, 22)
        Me.ts_countries.Text = "&Countries Setup"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(794, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer)))
        '
        'ts_masterleaveentitle
        '
        Me.ts_masterleaveentitle.Name = "ts_masterleaveentitle"
        Me.ts_masterleaveentitle.Size = New System.Drawing.Size(207, 22)
        Me.ts_masterleaveentitle.Text = "&Master Leave Entitlement"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(216, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(204, 6)
        '
        'MDIEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cornea - HRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empdetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_regnewemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_editemployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeavesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayRollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeLeavesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryStructureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecruitmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecruitmentDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_reportattentshift As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecriutmentReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empdetailsreports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeTrainingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingEventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_emptitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empcategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_emptype As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empgrade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empworkstation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empguardian As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empsex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empbloodgroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empreligion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empnationationality As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_emprecruitment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_dbconn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_companydetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_countries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_uploadempmaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empdepts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empbranch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empdesignation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empboss As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_empshifts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_timeshiftatten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_dailyatten As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_dailyattenreport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_masterleaveentitle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
