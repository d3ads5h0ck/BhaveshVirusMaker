Public Class bvmSettings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iCount As Integer
        For iCount = 100 To 10 Step -30
            Me.Opacity = iCount / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bvmUpdate.Show()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.SelectedItem = "Black" Then

            ' FORM 1
            Form1.BackColor = Color.Black
            Form1.ForeColor = Color.White
            Form1.Button6.BackColor = Color.Black
            Form1.Button6.ForeColor = Color.White
            Form1.Button4.BackColor = Color.Black
            Form1.Button4.ForeColor = Color.White

            ' MENU 1
            bvmMenu.BackColor = Color.Black
            bvmMenu.ForeColor = Color.Gray
            bvmMenu.Button1.BackColor = Color.Black
            bvmMenu.Button2.BackColor = Color.Black
            bvmMenu.Button3.BackColor = Color.Black
            bvmMenu.Button4.BackColor = Color.Black
            bvmMenu.Button5.BackColor = Color.Black
            bvmMenu.Button6.BackColor = Color.Black
            bvmMenu.Button7.BackColor = Color.Black
            bvmMenu.Button8.BackColor = Color.Black
            bvmMenu.Button9.BackColor = Color.Black
            bvmMenu.Button10.BackColor = Color.Black
            bvmMenu.Button11.BackColor = Color.Black
            bvmMenu.Button12.BackColor = Color.Black
            bvmMenu.Button13.BackColor = Color.Black

            bvmMenu.Button1.ForeColor = Color.Gray
            bvmMenu.Button2.ForeColor = Color.Gray
            bvmMenu.Button3.ForeColor = Color.Gray
            bvmMenu.Button4.ForeColor = Color.Gray
            bvmMenu.Button5.ForeColor = Color.Gray
            bvmMenu.Button6.ForeColor = Color.Gray
            bvmMenu.Button7.ForeColor = Color.Gray
            bvmMenu.Button8.ForeColor = Color.Gray
            bvmMenu.Button9.ForeColor = Color.Gray
            bvmMenu.Button10.ForeColor = Color.Gray
            bvmMenu.Button11.ForeColor = Color.Gray
            bvmMenu.Button12.ForeColor = Color.Gray
            bvmMenu.Button13.ForeColor = Color.Gray

            ' MENU 2
            bvmMenu2.BackColor = Color.Black
            bvmMenu2.ForeColor = Color.White
            bvmMenu2.Button1.BackColor = Color.Black
            bvmMenu2.Button2.BackColor = Color.Black
            bvmMenu2.Button3.BackColor = Color.Black
            bvmMenu2.Button4.BackColor = Color.Black

            bvmMenu2.Button1.ForeColor = Color.White
            bvmMenu2.Button2.ForeColor = Color.White
            bvmMenu2.Button3.ForeColor = Color.White
            bvmMenu2.Button4.ForeColor = Color.White

            ' SETTINGS WINDOW
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White

        ElseIf ComboBox1.SelectedItem = "White" Then

            ' FORM 1
            Form1.BackColor = Color.White
            Form1.ForeColor = Color.Black
            Form1.Button6.BackColor = Color.White
            Form1.Button6.ForeColor = Color.Black
            Form1.Button4.BackColor = Color.White
            Form1.Button4.ForeColor = Color.Black

            ' MENU 1
            bvmMenu.BackColor = Color.White
            bvmMenu.ForeColor = Color.Black
            bvmMenu.Button1.BackColor = Color.White
            bvmMenu.Button2.BackColor = Color.White
            bvmMenu.Button3.BackColor = Color.White
            bvmMenu.Button4.BackColor = Color.White
            bvmMenu.Button5.BackColor = Color.White
            bvmMenu.Button6.BackColor = Color.White
            bvmMenu.Button7.BackColor = Color.White
            bvmMenu.Button8.BackColor = Color.White
            bvmMenu.Button9.BackColor = Color.White
            bvmMenu.Button10.BackColor = Color.White
            bvmMenu.Button11.BackColor = Color.White
            bvmMenu.Button12.BackColor = Color.White
            bvmMenu.Button13.BackColor = Color.White

            bvmMenu.Button1.ForeColor = Color.Black
            bvmMenu.Button2.ForeColor = Color.Black
            bvmMenu.Button3.ForeColor = Color.Black
            bvmMenu.Button4.ForeColor = Color.Black
            bvmMenu.Button5.ForeColor = Color.Black
            bvmMenu.Button6.ForeColor = Color.Black
            bvmMenu.Button7.ForeColor = Color.Black
            bvmMenu.Button8.ForeColor = Color.Black
            bvmMenu.Button9.ForeColor = Color.Black
            bvmMenu.Button10.ForeColor = Color.Black
            bvmMenu.Button11.ForeColor = Color.Black
            bvmMenu.Button12.ForeColor = Color.Black
            bvmMenu.Button13.ForeColor = Color.Black

            ' MENU 2
            bvmMenu2.BackColor = Color.White
            bvmMenu2.ForeColor = Color.Black
            bvmMenu2.Button1.BackColor = Color.White
            bvmMenu2.Button2.BackColor = Color.White
            bvmMenu2.Button3.BackColor = Color.White
            bvmMenu2.Button4.BackColor = Color.White

            bvmMenu2.Button1.ForeColor = Color.Black
            bvmMenu2.Button2.ForeColor = Color.Black
            bvmMenu2.Button3.ForeColor = Color.Black
            bvmMenu2.Button4.ForeColor = Color.Black


            ' SETTINGS WINDOW
            Me.BackColor = Color.White
            Me.ForeColor = Color.Black

        End If
    End Sub
End Class