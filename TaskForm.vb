Imports Microsoft.VisualBasic

Public Class Class1
    Inherits Form

    Public Sub New(ByVal title As String)

        Me.Text = title

    End Sub

    Protected Overrides Sub OnSizeChanged(e As System.EventArgs)
        MyBase.OnSizeChanged(e)

        If (Me.WindowState = FormWindowState.Minimized) Then
            Visible = False
        Else
            Visible = True
        End If
    End Sub
End Class
