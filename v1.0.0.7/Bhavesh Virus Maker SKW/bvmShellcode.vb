Imports System.IO
Public Class bvmShellcode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bvmMenu.Show()
        Me.Close()
    End Sub

    Private Sub bvmShellcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(IO.Directory.GetFiles("shellcodes\", "*.htm*"))
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim fullPath = Path.Combine("", ListBox1.SelectedItem.ToString())
        Process.Start(fullPath)
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

End Class