Imports System.IO

Public Class bvmDorkContainer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fading()
    End Sub

    Private Sub fading()
        Dim iCount As Integer
        For iCount = 100 To 10 Step -30
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        Me.Close()
        bvmMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("dorks\sqlidorks.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("dorks\lfidorks.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("dorks\rfidorks.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("dorks\xsscheatsheet.txt")
            ListBox1.Items.AddRange(lines)
        Else
            MsgBox("Please Select An Item!")
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim fullPath = Path.Combine("https://www.google.com/#q=", ListBox1.SelectedItem.ToString())
        bvmBrowser.Show()
        bvmBrowser.WebBrowser1.Navigate(fullPath)
        bvmBrowser.TextBox1.Text = fullPath
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub bvmDorkContainer_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub bvmDorkContainer_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub bvmDorkContainer_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
End Class