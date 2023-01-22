Public Class Form4
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Exit1_Mouse_in(sender As Object, e As EventArgs) Handles Exit1.MouseEnter
        Exit1.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub Exit1_Mouse_out(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.BackColor = Color.FloralWhite
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.Crimson
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.FloralWhite
    End Sub
End Class