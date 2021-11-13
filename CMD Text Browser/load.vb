Public Class load2
    Dim a As String = "5"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        a = a - 1
        If a = 4 Then
            songc.Text = "Wait...(4)"
            Label1.Visible = False


        ElseIf a = 3 Then
            songc.Text = "Wait...(3)"
            Label2.Visible = False
        ElseIf a = 2 Then
            songc.Text = "Wait...(2)"
            Label3.Visible = False
        ElseIf a = 1 Then
            songc.Text = "Wait...(1)"
            Label4.Visible = False
        ElseIf a = 0 Then
            Label5.Visible = False
            pb1.Visible = False
            pb2.Visible = True
            songc.Visible = False
            Label6.Visible = True
            '   choose.Show()

            browser2.Show()
            Timer2.Start()
            '  Me.Show()
            Timer1.Stop()
            '  Timer1.Enabled
        End If
    End Sub

    Private Sub load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songc.Text = "Wait...(5)"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        browser2.brtext.Visible = True
        browser2.brcmd.Visible = True
        browser2.access.Visible = True
        browser2.Label1.Visible = True
        browser2.Label2.Visible = True
        browser2.pbline.Visible = True
        browser2.pb1.Visible = True
        Me.Hide()
        browser2.Timer1.Enabled = True
        Timer2.Enabled = False
    End Sub
End Class
