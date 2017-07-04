Imports System.Net
Public Class Form1
    Dim teststring As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        teststring = "'"
        Dim sourceString As String
        sourceString = TextBox1.Text
        sourceString = sourceString + teststring
        Try
            sourceString = New System.Net.WebClient().DownloadString(sourceString)
        Catch ex As Exception
            MsgBox("Error processing URL!")
        End Try
        If sourceString.Contains("error in your SQL syntax") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("mysql_num_rows") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("Error Occured") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("Microsoft OLE") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("InvalidQuerystring") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("VBScript Runtime") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("EOF") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("OLE DB Provider for ODBC") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("ADODB.Command") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("JET Database") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("include") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("Synatax error") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("mysql_fetch_assoc") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("mesql_fetch_object") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("mesql_numrows") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("GetArray") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("FetchRow") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("Input string was not in a correct format") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("You have an error in your SQL syntax") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("MySQL server version") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("MySQL version") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("right syntax") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("''") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        ElseIf sourceString.Contains("at line") Then
            Label1.Text = "Status: Returned Error!" + vbNewLine + "May be vulnerable"
            Label1.ForeColor = Color.Lime
        End If
    End Sub

    Sub fadein()
        For fadeinside = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadeinside
            Me.Refresh()
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Sub fadeout()
        For fadeoutside = 90 To 10 Step -10
            Me.Opacity = fadeoutside / 100
            Me.Refresh()
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fadeout()
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Fixed Size!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        fadeout()
        Me.WindowState = FormWindowState.Minimized
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadein()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Normal Or Me.WindowState = FormWindowState.Maximized Then
            Me.Opacity = 1
        Else
            Me.Opacity = 0
        End If
    End Sub
End Class
