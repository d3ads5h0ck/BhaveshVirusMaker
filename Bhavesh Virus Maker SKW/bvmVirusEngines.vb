Imports System.IO

Public Class bvmVirusEngines

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub bvmVirusEngines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(IO.Directory.GetFiles("eng\", "*.zip*"))
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Dim fullPath = Path.Combine("", ListBox1.SelectedItem.ToString())
        Process.Start(fullPath)
    End Sub
End Class