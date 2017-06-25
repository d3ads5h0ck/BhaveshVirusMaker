Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        batchvirusmaker.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        bvmDownloader.Show()
        bvmDownloader.TextBox1.Text = "https://mega.nz/#!wUEHhSyT!Kw9F2XzWKfdb5WwTfuGECtWuch9ER5NBRn_hC5iUBrY"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Application.Exit()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        bvmLists.wanted = "dorks"
        bvmLists.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bvmLists.wanted = "shellcodes"
        bvmLists.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bvmLists.wanted = "webshells"
        bvmLists.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bvmLists.wanted = "clicodes"
        bvmLists.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        bvmLists.wanted = "virusgens"
        bvmLists.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bvmBrowser.starter = "form"
        bvmBrowser.WebBrowser1.Navigate("http://www.f2ko.de/en/ob2e.php")
        bvmBrowser.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Process.Start("http://cyberjokers.pe.hu")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Process.Start("README.txt")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        bvmBrowser.WebBrowser1.Navigate("http://textfiles.com/magazines/")
        bvmBrowser.starter = "form"
        bvmBrowser.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start("VirusScreen.exe")
        Catch ex As Exception
            MsgBox("ERROR: Error opening")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Process.Start("pyCipher.py")
        Catch ex As Exception
            MsgBox("ERROR: Opening file")
            MsgBox("Ensure you have Python3 working on path!")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Process.Start("pcscanner.exe")
        Catch ex As Exception
            MsgBox("ERROR: Opening file")
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Process.Start("rarcracker.exe")
        Catch ex As Exception
            MsgBox("ERROR: Opening file")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim op As New OpenFileDialog
            op.Title = "AlanD-RAT"
            op.InitialDirectory = "RAT\"
            op.ShowDialog()
        Catch ex As Exception
            MsgBox("Closed Or Not Opened")
        End Try

    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        bvmBrowser.WebBrowser1.Navigate("https://sourceforge.net/projects/bhavesh-virus-maker-skw/files/")
        bvmBrowser.starter = "form"
        bvmBrowser.Show()
        MsgBox("See if you have the latest version..")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Process.Start("https://github.com/NyanSniper101/BhaveshVirusMaker")
    End Sub
End Class
