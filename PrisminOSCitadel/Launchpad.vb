Public Class Launchpad
    Private Sub Launchpad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wallpaper As String
        Try
            wallpaper = Settings.OpenFileDialog1.FileName
            Me.BackgroundImage = Image.FromFile(wallpaper)
        Catch ex As Exception
        End Try

        Me.TopMost = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FileExplorer.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class