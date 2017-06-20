Public Class bvmCommandlinecodes

    Private Sub bvmCommandlinecodes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim iCount As Integer
        For iCount = 100 To 10 Step -30
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        bvmMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\cmd.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\powershell.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\bash.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\osx.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 4 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\access.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 5 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\vbscript.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 6 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\oracle.txt")
            ListBox1.Items.AddRange(lines)
        ElseIf ComboBox1.SelectedIndex = 7 Then
            ListBox1.Items.Clear()
            Dim lines() As String = IO.File.ReadAllLines("cmd\sqlserver.txt")
            ListBox1.Items.AddRange(lines)
        End If
    End Sub
End Class