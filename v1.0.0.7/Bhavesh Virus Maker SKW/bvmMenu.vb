Public Class bvmMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        batchvirusmaker.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("BVM Browser doesn't support this site design, shitfing to system browser!")
        Process.Start("http://cyberjokers.pe.hu/")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim iCount As Integer
        For iCount = 100 To 10 Step -30
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bvmBrowser.Show()
        bvmBrowser.WebBrowser1.Navigate("http://www.f2ko.de/en/ob2e.php")
        bvmBrowser.TextBox1.Text = "http://www.f2ko.de/en/ob2e.php"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bvmShellcode.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        bvmWebshells.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bvmDorkContainer.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("RAT\")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("This will ONLY work in python 3.5")
        MsgBox("You can take the file directly and run manually :) ")
        Process.Start("pyCipher.py")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        bvmBrowser.Show()
        bvmBrowser.TextBox1.Text = "http://textfiles.com/magazines/"
        bvmBrowser.WebBrowser1.Navigate(bvmBrowser.TextBox1.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        bvmCommandlinecodes.Show()
        Me.Close()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub bvmMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub bvmMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub bvmMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        bvmVirusEngines.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim iCount As Integer
        For iCount = 100 To 10 Step -30
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        Me.Close()
        bvmMenu2.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        bvmDownloader.Show()
        bvmDownloader.TextBox1.Text = "https://mega.nz/#!wUEHhSyT!Kw9F2XzWKfdb5WwTfuGECtWuch9ER5NBRn_hC5iUBrY"
        Me.Close()
    End Sub

    Private Sub bvmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 1
    End Sub
End Class