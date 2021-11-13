Imports System.Text.RegularExpressions
Public Class browser2
    Dim a As String = 1
    Dim khois_tv As String = 0
    Dim khoitao As String = 0
    Dim phanxa As String = 0
    Dim tienvao As String = 0
    Dim leght As String = 0
    Private Sub browser2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Me.Enabled = False
        load2.TopMost = True
        load2.Show()
        autocenter()
    End Sub
    Sub autocenter()
        '     brtext.Top = (Me.ClientSize.Height / 2) - (brtext.Height / 2)
        brtext.Left = (Me.ClientSize.Width / 2) - (brtext.Width / 2) - 80
        brcmd.Left = (Me.ClientSize.Width / 2) - (brcmd.Width / 2) + 80
        access.Left = (Me.ClientSize.Width / 2) - (access.Width / 2)
        Label1.Left = (Me.ClientSize.Width / 2) - (Label1.Width / 2)
        '   status.Left = (Me.ClientSize.Width / 2) - (status.Width / 2) + 50
        Label2.Left = (Me.ClientSize.Width / 2) - (Label2.Width / 2)
        pbline.Left = (Me.ClientSize.Width / 2) - (pbline.Width / 2)
        pb1.Left = (Me.ClientSize.Width / 2) - (pb1.Width / 2)

        '   brtext.Top = (Me.Top / 2) - (brtext.Top)
        '    brcmd.Top = (Me.Top / 2) - (brcmd.Top)
        '    access.Top = (Me.Top / 2) - (access.Top)
        '   Label1.Top = (Me.Top / 2) - (Label1.Top)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If a = 1 Then
            Me.BackgroundImage = My.Resources._11
            a = a + 1
        Else
            Me.BackgroundImage = My.Resources._21
            a = 1

        End If
    End Sub

    Private Sub brtext_Click(sender As Object, e As EventArgs) Handles brtext.Click
        leght = leght + 1
        Dim input As String = access.Text
        Dim result As String() = Regex.Split(input, ">")
        For Each s As String In result

            If leght > 3 Then
                MsgBox("Địa chỉ kết nối tối đa là 3 tích.")
            Else
                '  If leght = 1 Then
                '      khoitao = s
                '   ElseIf leght = 2 Then
                '      phanxa = s
                '   ElseIf leght = 3 Then
                '      tienvao = s

                ' Else
                MsgBox(s)
                khois_tv = 0
                    timetruyvan.Enabled = True
                    brtext.Enabled = False
                '    End If

            End If

        Next
    End Sub

    Private Sub timetruyvan_Tick(sender As Object, e As EventArgs) Handles timetruyvan.Tick
        If khois_tv = 0 Then
            Label1.Text = ("Đã kết nối với máy chủ...")
            khois_tv = khois_tv + 1
        ElseIf khois_tv = 1 Then
            Label1.Text = ("Đang truy cập cơ sở dữ liệu...")
            khois_tv = khois_tv + 1
        ElseIf khois_tv = 2 Then
            Label1.Text = ("Đang truy vấn thông tin...")
            khois_tv = khois_tv + 1
        ElseIf khois_tv = 3 Then
            Label1.Text = ("Đang truy vấn dữ liệu...")
            khois_tv = khois_tv + 1
        ElseIf khois_tv = 4 Then
            Label1.Text = ("Đang chuẩn bị CMD...")
            khois_tv = khois_tv + 1
        Else
            khois_tv = 0
            timetruyvan.Stop()

        End If
    End Sub
End Class