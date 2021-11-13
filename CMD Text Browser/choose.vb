Public Class choose
    Dim a As String = "5"
    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        End
    End Sub

    Private Sub ext_MouseMove(sender As Object, e As MouseEventArgs) Handles ext.MouseMove
        ext.ForeColor = Color.Red
    End Sub

    Private Sub choose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub choose_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ext.ForeColor = Color.White
        Label22.ForeColor = Color.White
        Label33.ForeColor = Color.White
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label22.MouseMove
        Label22.ForeColor = Color.Blue
    End Sub
    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label33.MouseMove
        Label33.ForeColor = Color.Blue
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        a = a - 1
        If a = 4 Then
            ' songc.Text = "Wait...(4)"
            Label1.Visible = False
            Label5.Visible = True
            Label11.Left = Label11.Left - 11

        ElseIf a = 3 Then
            '  songc.Text = "Wait...(3)"
            Label2.Visible = False
            Label4.Visible = True
        ElseIf a = 2 Then
            '  songc.Text = "Wait...(2)"
            Label3.Visible = False
            Label2.Visible = True
        ElseIf a = 1 Then
            ' songc.Text = "Wait...(1)"
            Label4.Visible = False
        ElseIf a = 0 Then
            Label5.Visible = False
            Label1.Visible = True
            Label2.Visible = True
            Label11.Left = Label11.Left + 11
            Label3.Visible = True
            Label4.Visible = True

            a = 5
        End If
    End Sub
End Class