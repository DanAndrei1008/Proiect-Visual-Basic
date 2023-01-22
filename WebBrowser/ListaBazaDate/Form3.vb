Public Class Form3
    Dim folder As String
    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.LightSalmon
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.AliceBlue
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Exit1_Mouse_in(sender As Object, e As EventArgs) Handles Exit1.MouseEnter
        Exit1.BackColor = Color.CadetBlue
    End Sub
    Private Sub Exit1_Mouse_out(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button6_Mouse_in(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.BackColor = Color.SlateBlue
    End Sub
    Private Sub Button6_Mouse_out(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button5_Mouse_in(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.BackColor = Color.SlateBlue
    End Sub
    Private Sub Button5_Mouse_out(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button4_Mouse_in(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub Button4_Mouse_out(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button3_Mouse_in(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.LightSalmon
    End Sub
    Private Sub Button3_Mouse_out(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button1_Mouse_in(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.SteelBlue
    End Sub
    Private Sub Button1_Mouse_out(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button2_Mouse_in(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.CadetBlue
    End Sub
    Private Sub Button2_Mouse_out(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub
End Class
