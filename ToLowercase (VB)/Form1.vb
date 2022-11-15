''' <summary>
''' This program is provided AS-IS and allows the user to 
''' quickly paste in text to be converted to lowercase and 
''' copy to the clipboard.
''' </summary>
''' 

Public Class Form1

#Region "Constant"
    Public Const WM_QUERYENDSESSION As Integer = &H11
#End Region

#Region "Convert Button"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox1.Text.ToLower
    End Sub
#End Region

#Region "Exit Button"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
#End Region

#Region "Clear Button"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox1.Focus()
    End Sub
#End Region

#Region "Copy to Clipboard Button"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.SetText(TextBox2.Text.Trim)
    End Sub
#End Region

#Region "WndProc"
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_QUERYENDSESSION Then Application.Exit()
        MyBase.WndProc(m)
    End Sub
#End Region

End Class
