Public Class Form1
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New ColorDialog
        c.ShowDialog()
        Me.RichTextBox1.SelectionColor = c.Color

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.RichTextBox1.SelectionAlignment = HorizontalAlignment.Right

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f As New FontDialog
        f.ShowDialog()
        Me.RichTextBox1.SelectionFont = f.Font
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter


    End Sub
End Class
