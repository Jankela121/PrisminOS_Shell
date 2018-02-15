Public Class FileExplorer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim locpst As String
        Me.BackgroundImage = Image.FromFile("C:\Program Files\Prismin OS\Resources\FileExplorerMusic.png")
        locpst = "C:\Program Files\Prismin OS\Resources\FileExplorerMusic.png"
    End Sub

    Private Sub FileExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.BackgroundImage = Image.FromFile("C:\Program Files\Prismin OS\Resources\FileExplorerDocuments.png")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.BackgroundImage = Image.FromFile("C:\Program Files\Prismin OS\Resources\FileExplorerPictures.png")
    End Sub
End Class