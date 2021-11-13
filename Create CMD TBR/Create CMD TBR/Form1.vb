

Public Class home
    Dim a As String = "@$@#$#@%#$%@#%#$%^#$^%$&#^#$%#@$%#$%#$^%^%$^#$%^#$%^$#^#^#$^$#^$&%%^&%^&$%^#$^#$%#$%^#$^#$^%#$ "
    Dim b As String = " /-+-*/*-++-*/*--+++--*///*-*-++--**/*--++--*/***--+++-*-*/*-*-+++--***-++--*--+++-*--++--**--++--**-+-"
    Dim c As String = " )()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()( "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  code1.Text = enccode(code1.Text)

        If trinhsoan1.code.Text = "" Then
            MsgBox("Please enter the code!")
        Else
            code1.Text = enccode(a + b + c + trinhsoan1.code.Text + b + a + c)
            tinhtg.Text = "Status : Completed!"
            Label3.Visible = False
            code1.Enabled = True
            ' Clipboard.SetText(code1.SelectedText)
            MsgBox("Copied file code!", vbInformation, "Notice")
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'code1.Text = deccode(code1.Text)
        '  code1.Text = Replace(code1.Text, a, "")
        '  code1.Text = Replace(code1.Text, b, "")
        '  code1.Text = Replace(code1.Text, c, "")
        ' code1.Text = deccode(code1.Text)
    End Sub



    Private Sub code1_TextChanged(sender As Object, e As EventArgs) Handles code1.TextChanged

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   code1.Text.Paste()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  Clipboard.SetText(code1.SelectedText)
    End Sub
End Class
