Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        batchvirusmaker.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Process.Start("https://mega.nz/#!wUEHhSyT!Kw9F2XzWKfdb5WwTfuGECtWuch9ER5NBRn_hC5iUBrY")
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
        Process.Start("README.html")
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
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Process.Start("pyCipher.py")
        Catch ex As Exception
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Process.Start("pcscanner.exe")
        Catch ex As Exception
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Process.Start("rarcracker.exe")
        Catch ex As Exception
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
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

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            Process.Start("Bhavesh Shellsploit Framework\Bhavesh Shellsploit Framework\bin\Debug\Bhavesh Shellsploit Framework.exe")
        Catch ex As Exception
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.firsttime = 0 'for testing only
        btndesigner()
        If My.Settings.firsttime = 0 Then
            Process.Start("README.html")
            My.Settings.firsttime = 1
        Else
            'nothing
        End If
    End Sub

    Sub btndesigner()
        Dim p As New Drawing2D.GraphicsPath
        Dim q As New Drawing2D.GraphicsPath
        Dim r As New Drawing2D.GraphicsPath

        'Button 16
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        p.AddLine(10, 0, Button16.Width - 10, 0)
        p.AddArc(New Rectangle(Button16.Width - 40, 0, 40, 40), -90, 180)
        p.AddLine(Button16.Width, 40, Button16.Width, Button16.Height - 40)
        p.AddArc(New Rectangle(Button16.Width - 1, Button16.Height - 1, 1, 1), 0, 180)
        p.AddLine(Button16.Width - 40, Button16.Height, 40, Button16.Height)
        p.AddArc(New Rectangle(0, Button16.Height - 10, 10, 10), 180, 90)
        p.CloseFigure()
        Button16.Region = New Region(p)

        'Button 17
        q.StartFigure()
        q.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        q.AddLine(10, 0, Button17.Width - 10, 0)
        q.AddArc(New Rectangle(Button17.Width - 40, 0, 40, 40), -90, 180)
        q.AddLine(Button17.Width, 40, Button17.Width, Button17.Height - 40)
        q.AddArc(New Rectangle(Button17.Width - 1, Button17.Height - 1, 1, 1), 0, 180)
        q.AddLine(Button17.Width - 40, Button17.Height, 40, Button17.Height)
        q.AddArc(New Rectangle(0, Button17.Height - 10, 10, 10), 180, 90)
        q.CloseFigure()
        Button17.Region = New Region(q)

        'Button 18
        r.StartFigure()
        r.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        r.AddLine(10, 0, Button18.Width - 10, 0)
        r.AddArc(New Rectangle(Button18.Width - 40, 0, 40, 40), -90, 180)
        r.AddLine(Button18.Width, 40, Button18.Width, Button18.Height - 40)
        r.AddArc(New Rectangle(Button18.Width - 1, Button18.Height - 1, 1, 1), 0, 180)
        r.AddLine(Button18.Width - 40, Button18.Height, 40, Button18.Height)
        r.AddArc(New Rectangle(0, Button18.Height - 10, 10, 10), 180, 90)
        r.CloseFigure()
        Button18.Region = New Region(r)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Process.Start("MalwareOrganizer.exe")
        Catch ex As Exception
            Process.Start("http://cyberjokers.pe.hu/bvm/downloads.html")
        End Try
    End Sub
End Class
