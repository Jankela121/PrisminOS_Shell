Imports Microsoft.VisualBasic

Public Class Class1
    Inherits ToolStripMenuItem

    Private WithEvents CloseItem As ToolStripMenuItem
    Private WithEvents RestoreItem As ToolStripMenuItem

    Private _form As Form

    Public Sub New(ByVal text As String, ByVal img As Image, ByVal frm As Form)

        MyBase.New(text, img)
        _form = frm

        AddHandler CloseItem.Click, AddressOf Close_Click
        AddHandler RestoreItem.Click, AddressOf Restore_Click
        add

    End Sub

    Private Sub Close_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Parent.Items.Remove(Me)
        If (Not isNothing(_form)) Then
            _form.Close()
        End If
    End Sub

    Private Sub Restore_Click(ByVal sender As Object, ByVal e As EventArgs)
        If (_form.WindowState = FormWindowState.Minimized) Then
            _form.WindowState = FormWindowState.Normal
            _form.Visible = True
        End If
    End Sub
End Class
