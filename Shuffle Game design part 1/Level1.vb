Public Class Level1
    Public clicks As Integer
    Dim a As Integer
    Private stopwatch As New Stopwatch

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffel()
        Timer1.Start()
        stopwatch.Start()
        My.Computer.Audio.Play(My.Resources.bensound_clearday__online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elasped As TimeSpan = stopwatch.Elapsed
        Label3.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                    Math.Floor(elasped.TotalHours),
                                     elasped.Minutes, elasped.Seconds)
    End Sub

    Sub score()
        clicks = clicks + 1
        Label7.Text = ""
        Label7.Text = clicks
    End Sub

    Sub ChkBut(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt1.Text = ""
            Solve()
            score()
        End If
    End Sub

    Sub Solve()

        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And
        Button8.Text = "8" And Button9.Text = "9" And Button10.Text = "10" And Button11.Text = "11" And Button12.Text = "12" And Button13.Text = "13" And Button14.Text = "14" And
        Button15.Text = "15" And Button16.Text = "16" And Button17.Text = "17" And Button18.Text = "18" And Button19.Text = "19" And Button20.Text = "" Then
            MsgBox("Solved", vbInformation)

        End If
    End Sub

    Sub shuffel()
        Dim a(19), i, j, RN As Integer
        Dim flag As Boolean
        flag = False
        i = 1
        a(j) = 1
        Do While i <= 19
            Randomize()
            RN = CInt(Int((19 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If

        Loop
        Button1.Text = a(1)
        Button2.Text = a(2)
        Button3.Text = a(3)
        Button4.Text = a(4)
        Button5.Text = a(5)
        Button6.Text = a(6)
        Button7.Text = a(7)
        Button8.Text = a(8)
        Button9.Text = a(9)
        Button10.Text = a(10)
        Button11.Text = a(11)
        Button12.Text = a(12)
        Button13.Text = a(13)
        Button14.Text = a(14)
        Button15.Text = a(15)
        Button16.Text = a(16)
        Button17.Text = a(17)
        Button18.Text = a(18)
        Button19.Text = a(19)
        Button20.Text = ""
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChkBut(Button1, Button2)
        ChkBut(Button1, Button6)
        Solve()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChkBut(Button2, Button1)
        ChkBut(Button2, Button3)
        ChkBut(Button2, Button7)
        Solve()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ChkBut(Button3, Button2)
        ChkBut(Button3, Button4)
        ChkBut(Button3, Button8)
        Solve()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ChkBut(Button4, Button3)
        ChkBut(Button4, Button5)
        ChkBut(Button4, Button9)
        Solve()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ChkBut(Button5, Button4)
        ChkBut(Button5, Button10)
        Solve()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChkBut(Button6, Button1)
        ChkBut(Button6, Button7)
        ChkBut(Button6, Button11)
        Solve()
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ChkBut(Button7, Button2)
        ChkBut(Button7, Button6)
        ChkBut(Button7, Button8)
        ChkBut(Button7, Button12)
        Solve()
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ChkBut(Button8, Button3)
        ChkBut(Button8, Button7)
        ChkBut(Button8, Button9)
        ChkBut(Button8, Button13)
        Solve()
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ChkBut(Button9, Button4)
        ChkBut(Button9, Button8)
        ChkBut(Button9, Button10)
        ChkBut(Button9, Button14)
        Solve()
    End Sub

    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ChkBut(Button10, Button5)
        ChkBut(Button10, Button9)
        ChkBut(Button10, Button15)
        Solve()
    End Sub

    Private Sub Btn11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ChkBut(Button11, Button6)
        ChkBut(Button11, Button12)
        ChkBut(Button11, Button16)
        Solve()
    End Sub

    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ChkBut(Button12, Button7)
        ChkBut(Button12, Button11)
        ChkBut(Button12, Button13)
        ChkBut(Button12, Button17)
        Solve()
    End Sub

    Private Sub Btn13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ChkBut(Button13, Button8)
        ChkBut(Button13, Button12)
        ChkBut(Button13, Button14)
        ChkBut(Button13, Button18)
        Solve()
    End Sub

    Private Sub Btn14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ChkBut(Button14, Button9)
        ChkBut(Button14, Button13)
        ChkBut(Button14, Button15)
        ChkBut(Button14, Button19)
        Solve()
    End Sub

    Private Sub Btn15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ChkBut(Button15, Button10)
        ChkBut(Button15, Button14)
        ChkBut(Button15, Button20)
        Solve()
    End Sub

    Private Sub Btn16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ChkBut(Button16, Button11)
        ChkBut(Button16, Button17)
        Solve()
    End Sub

    Private Sub Btn17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ChkBut(Button17, Button12)
        ChkBut(Button17, Button16)
        ChkBut(Button17, Button18)
        Solve()
    End Sub

    Private Sub Btn18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ChkBut(Button18, Button13)
        ChkBut(Button18, Button17)
        ChkBut(Button18, Button19)
        Solve()
    End Sub

    Private Sub Btn19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ChkBut(Button19, Button14)
        ChkBut(Button19, Button18)
        ChkBut(Button19, Button20)
        Solve()
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ChkBut(Button20, Button15)
        ChkBut(Button20, Button19)
        Solve()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click


    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Level1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ToolStripMenuItem2.Checked = True Then
            ToolStripMenuItem2.Checked = False
            My.Computer.Audio.Play(My.Resources.bensound_clearday__online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
            ToolStripSplitButton1.Image = My.Resources.favicon__3____Copy
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If ToolStripMenuItem1.Checked = True Then
            ToolStripMenuItem1.Checked = False
            My.Computer.Audio.Stop()
            ToolStripSplitButton1.Image = My.Resources.favicon__5____Copy
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        shuffel()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        End
    End Sub
End Class

