
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Media
Public Class AddEmployeeCategory
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MAXIMIZE As Integer = &HF030
    Private Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Private Const HTCAPTION As Integer = &H2
    Private widthint As Integer = 397
    Private heightint As Integer = 227

    Private classEmp As New ClassEmployee

    Private Sub form_init()

        Me.txt_name.Select()
        Me.txt_name.Text = ""
        Me.txt_descrip.Text = ""


    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        'Me.WindowState = 2
        If (m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_MAXIMIZE) OrElse (m.Msg = WM_NCLBUTTONDBLCLK AndAlso m.WParam.ToInt32 = HTCAPTION) Then
            Me.Bounds = New Rectangle(0, 0, widthint, heightint)
            m.Result = CType(0, IntPtr)
            Return
        End If
        MyBase.WndProc(m)

    End Sub

    Private Sub AddEmployeeCategory_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        Me.Refresh()
    End Sub

    Private Sub AddEmployeeCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call form_init()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        save_next = False
        Call classEmp.add_EmpCategories()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        save_next = True
        Call classEmp.add_EmpCategories()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class