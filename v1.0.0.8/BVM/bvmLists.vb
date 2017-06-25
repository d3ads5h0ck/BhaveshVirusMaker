﻿Imports System.IO
Public Class bvmLists

    Public wanted As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub bvmLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
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