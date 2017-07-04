Imports System.IO
Public Class bvmLists

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

    Public wanted As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fadeout()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub bvmLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadein()
        If wanted = "dorks" Then
            dorks()
        ElseIf wanted = "shellcodes" Then
            shellcodes()
        ElseIf wanted = "webshells" Then
            webshells()
        ElseIf wanted = "clicodes" Then
            clicodes()
        ElseIf wanted = "virusgens" Then
            virusgens()
        End If
    End Sub

    Private Sub dorks()
        catcom.Items.Add("SQLi")
        catcom.Items.Add("XSS Cheatsheet")
        catcom.Items.Add("LFI")
        catcom.Items.Add("RFI")
        catcom.Text = "Choose Dork Type"
    End Sub

    Private Sub shellcodes()
        catcom.Text = "Nothing to select! All shellcodes listed.."
        Try
            ListBox1.Items.AddRange(IO.Directory.GetFiles("shellcodes\", "*.htm*"))
        Catch ex As Exception
            MsgBox("ERROR: Folder not found!")
        End Try
    End Sub

    Private Sub webshells()
        ListBox1.Hide()
        RichTextBox1.Show()
        catcom.Text = "Choose a shell to display"
        catcom.Items.AddRange(IO.Directory.GetFiles("webshells\", "*.php*"))
    End Sub

    Private Sub clicodes()
        ListBox1.Hide()
        RichTextBox1.Show()
        catcom.Text = "Choose a shell system"
        catcom.Items.AddRange(IO.Directory.GetFiles("cmd\", "*.txt*"))
    End Sub

    Private Sub virusgens()
        catcom.Text = "Nothing to select! All Gens listed.."
        Try
            ListBox1.Items.AddRange(IO.Directory.GetFiles("eng\", "*.zip*"))
        Catch ex As Exception
            MsgBox("ERROR: Folder not found!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If wanted = "dorks" Then
            If catcom.Text = "SQLi" Then
                Try
                    ListBox1.Items.Clear()
                    Dim lines() As String = IO.File.ReadAllLines("dorks\sqlidorks.txt")
                    ListBox1.Items.AddRange(lines)
                Catch ex As Exception
                    MsgBox("ERROR: Directory or file not found!")
                    Form1.Show()
                    Me.Close()
                End Try
            ElseIf catcom.Text = "XSS Cheatsheet" Then
                Try
                    ListBox1.Items.Clear()
                    Dim lines() As String = IO.File.ReadAllLines("dorks\xsscheatsheet.txt")
                    ListBox1.Items.AddRange(lines)
                Catch ex As Exception
                    MsgBox("ERROR: Directory or file not found!")
                    Form1.Show()
                    Me.Close()
                End Try
            ElseIf catcom.Text = "LFI" Then
                Try
                    ListBox1.Items.Clear()
                    Dim lines() As String = IO.File.ReadAllLines("dorks\lfidorks.txt")
                    ListBox1.Items.AddRange(lines)
                Catch ex As Exception
                    MsgBox("ERROR: Directory or file not found!")
                    Form1.Show()
                    Me.Close()
                End Try
            ElseIf catcom.Text = "RFI" Then
                Try
                    ListBox1.Items.Clear()
                    Dim lines() As String = IO.File.ReadAllLines("dorks\rfidorks.txt")
                    ListBox1.Items.AddRange(lines)
                Catch ex As Exception
                    MsgBox("ERROR: Directory or file not found!")
                    Form1.Show()
                    Me.Close()
                End Try
            End If
        ElseIf wanted = "webshells" Then
            Dim fullPath = Path.Combine("", catcom.SelectedItem.ToString())
            RichTextBox1.LoadFile(fullPath, RichTextBoxStreamType.PlainText)
        ElseIf wanted = "clicodes" Then
            Dim fullPath = Path.Combine("", catcom.SelectedItem.ToString())
            RichTextBox1.LoadFile(fullPath, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Try
            If wanted = "dorks" Then
                Dim url = "https://www.google.com/?q=" + ListBox1.SelectedItem
                bvmBrowser.WebBrowser1.Navigate(url)
                bvmBrowser.Show()
                bvmBrowser.starter = "list"
            ElseIf wanted = "shellcodes" Then
                Try
                    Dim fullPath = Path.Combine("", ListBox1.SelectedItem.ToString())
                    Process.Start(fullPath)
                Catch ex As Exception
                    MsgBox("ËRROR: Opening the file!")
                End Try
            ElseIf wanted = "virusgens" Then
                Try
                    Dim fullPath = Path.Combine("", ListBox1.SelectedItem.ToString())
                    Process.Start(fullPath)
                Catch ex As Exception
                    MsgBox("ERROR: Cannot open! Pls open manually..")
                End Try
            End If
        Catch ex As Exception
            MsgBox("ERROR: Item cannot be opened!")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
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
    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer
    Private Sub Grip_MouseMove(sender As Object, e As MouseEventArgs) Handles Grip.MouseMove
        If GripDrag = True Then
            Me.Width = InitialSizeX + (Cursor.Position.X - (Me.Width + Me.Location.X))
            Me.Height = InitialSizeY + (Cursor.Position.Y - (Me.Height + Me.Location.Y))

            InitialSizeX = Me.Width
            InitialSizeY = Me.Height

            Me.Refresh()
        End If
    End Sub

    Private Sub Grip_MouseDown(sender As Object, e As MouseEventArgs) Handles Grip.MouseDown
        If e.Button = MouseButtons.Left Then 'If the control is being left-clicked
            GripDrag = True 'Confirms the grip is ready to be dragged
            InitialSizeX = Me.Width 'Sets the initial width
            InitialSizeY = Me.Height 'Sets the initial height
        End If
    End Sub

    Private Sub Grip_MouseUp(sender As Object, e As MouseEventArgs) Handles Grip.MouseUp
        GripDrag = False
    End Sub
End Class