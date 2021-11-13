Imports System
Imports System.IO
Imports System.Text
Public Class trinhsoan1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = "Guide : Enter a project name. Example: 'NameAddress: New Project'"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Guide : Enter a description of the project. Example: 'ProjectDescr: Project new text'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Text = "Guide : Enter the text name. Example: 'TextName: Hello World'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button4.BackColor = Color.Red
        Button3.BackColor = Color.Red

        Label3.Text = "Guide : Enter the text alignment, complementary part Text Name. Example: 'TextAlign.1: Center|Left|Right'"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Button4.BackColor = Color.White
        Button3.BackColor = Color.White
        Button5.BackColor = Color.White
        Button11.BackColor = Color.White

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button4.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Label3.Text = "Guide : Enter the text size , complementary part Text Name, complementary part Text Align. Example: 'TextSize.1: 16'"
    End Sub

    Private Sub taoduan_Click(sender As Object, e As EventArgs) Handles taoduan.Click
        'home.code1.Text = code3.Text

        If code.Text = "" Then


        Else
            home.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim wordsRED As New List(Of String)
        Dim wordsBLUE As New List(Of String)
        Dim wordsPurple As New List(Of String)
        Dim wordsGREEN As New List(Of String)


        'green
        wordsGREEN.Add("NameAddress:")
        wordsGREEN.Add("ProjectDescr:")
        wordsGREEN.Add("TextName")
        wordsGREEN.Add("TextAlign.1:")
        wordsGREEN.Add("TextSize.1:")
        wordsGREEN.Add("TextColor.1:")
        wordsGREEN.Add("TextOI:")
        wordsGREEN.Add("TextSize.2:")
        wordsGREEN.Add("TextAlign.2:")
        wordsGREEN.Add("TextColor.2:")
        wordsGREEN.Add("Start Project")
        wordsGREEN.Add("End Project")
        wordsGREEN.Add("(br)")

        If code3.Lines.Length > 0 Then
            Dim selectStart As Integer = code3.SelectionStart
            code3.Select(0, code3.Text.Length)
            code3.SelectionColor = Color.Black
            code3.DeselectAll()

            code3.SelectionStart = selectStart
            'green color words
            For Each oneWord As String In wordsGREEN
                Dim pos As Integer = 0

                Do While code3.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = code3.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    code3.Select(pos, oneWord.Length)
                    code3.SelectionColor = Color.Blue
                    pos += 1
                Loop
            Next
            code3.SelectionStart = selectStart
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label3.Text = "Guide : Enter the text content. Using (br) for carriage. Example: 'TextOI: Hello world! (br) Welcome to CTB!"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button4.BackColor = Color.Red
        Button3.BackColor = Color.Red
        Button5.BackColor = Color.Red
        Button11.BackColor = Color.Red
        Label3.Text = "Guide : Enter a color for Text Name. Example: 'TextColor.1: Red|Blue|White|Yellow|Orange|Tomato|Green|Pink"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        code.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim wordsRED As New List(Of String)
        Dim wordsBLUE As New List(Of String)
        Dim wordsPurple As New List(Of String)
        Dim wordsGREEN As New List(Of String)


        'green
        wordsGREEN.Add("NameAddress:")
        wordsGREEN.Add("ProjectDescr:")
        wordsGREEN.Add("TextName")
        wordsGREEN.Add("TextAlign.1:")
        wordsGREEN.Add("TextSize.1:")
        wordsGREEN.Add("TextColor.1:")
        wordsGREEN.Add("TextOI:")
        wordsGREEN.Add("TextSize.2:")
        wordsGREEN.Add("TextAlign.2:")
        wordsGREEN.Add("TextColor.2:")
        wordsGREEN.Add("Start Project")
        wordsGREEN.Add("End Project")
        wordsGREEN.Add("(br)")

        If code3.Lines.Length > 0 Then
            Dim selectStart As Integer = code3.SelectionStart
            code3.Select(0, code3.Text.Length)
            code3.SelectionColor = Color.Black
            code3.DeselectAll()

            code3.SelectionStart = selectStart
            'green color words
            For Each oneWord As String In wordsGREEN
                Dim pos As Integer = 0

                Do While code3.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                    pos = code3.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                    code3.Select(pos, oneWord.Length)
                    code3.SelectionColor = Color.Blue
                    pos += 1
                Loop
            Next
            code3.SelectionStart = selectStart
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button10.BackColor = Color.Yellow
        Button8.BackColor = Color.Yellow
        Label3.Text = "Guide : Enter the text size , complementary part Text OI. Example: 'TextSize.2: 8'"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button10.BackColor = Color.Yellow
        Button8.BackColor = Color.Yellow
        Button9.BackColor = Color.Yellow

        Label3.Text = "Guide : Enter the text alignment, complementary part Text IO. Example: 'TextAlign.2 Center|Left|Right'"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button10.BackColor = Color.Yellow
        Button8.BackColor = Color.Yellow
        Button9.BackColor = Color.Yellow
        Button7.BackColor = Color.Yellow

        Label3.Text = "Guide : Enter a color for Text IO. Example: 'TextColor.2: Red|Blue|White|Yellow|Orange|Tomato|Green|Pink"
    End Sub


    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        Button10.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
        Button7.BackColor = Color.White
    End Sub
End Class