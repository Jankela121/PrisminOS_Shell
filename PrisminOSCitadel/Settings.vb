Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim wallpaper As String
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Form1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            wallpaper = OpenFileDialog1.FileName
            Launchpad.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutSection.Show()
    End Sub
End Class