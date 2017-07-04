Public Class bvmBrowser
    Public starter As String

    Sub fadein()
        For fadeinside = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadeinside
            Me.Refresh()
            Threading.Thread.Sleep(0.1)
        Next
    End Sub

    Sub fadeout()
        For fadeoutside = 90 To 10 Step -10
            Me.Opacity = fadeoutside / 100
            Me.Refresh()
            Threading.Thread.Sleep(0.1)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fadeout()
        If starter = "list" Then
            bvmLists.Show()
            Me.Close()
        ElseIf starter = "form" Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            fadeout()
            Me.WindowState = FormWindowState.Maximized
            fadein()
        Else
            fadeout()
            Me.WindowState = FormWindowState.Normal
            fadein()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bvmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Maximized
        fadein()
    End Sub

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            fadeout()
            Me.WindowState = FormWindowState.Maximized
            fadein()
        Else
            fadeout()
            Me.WindowState = FormWindowState.Normal
            fadein()
        End If
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub
End Class