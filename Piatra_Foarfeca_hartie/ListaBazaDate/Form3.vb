Public Class Form3
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim number As Integer

    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.Crimson
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.FloralWhite
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        Const Piatra As Integer = 1
        Const Foarfeca As Integer = 2
        Const Hartie As Integer = 3

        Number = (3 * Rnd())

        If piatraButon.Checked And Number = Piatra Then
            Label7.Text = "Egalitate"
            Label5.Text = x
            Label6.Text = y

            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False

            PictureBox4.Visible = True
            PictureBox7.Visible = True
        ElseIf piatraButon.Checked And Number = Foarfeca Then
            Label7.Text = "Ai castigat"
            x += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False

            PictureBox4.Visible = True
            PictureBox8.Visible = True
        ElseIf piatraButon.Checked And Number = Hartie Then
            Label7.Text = "Ai pierdut"
            y += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False

            PictureBox4.Visible = True
            PictureBox9.Visible = True
        End If

        If foarfecaButon.Checked And Number = Piatra Then
            Label7.Text = "Ai pierdut"
            y += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False

            PictureBox5.Visible = True
            PictureBox7.Visible = True

        ElseIf foarfecaButon.Checked And Number = Foarfeca Then
            Label7.Text = "Egalitate"
            Label5.Text = x
            Label6.Text = y

            PictureBox7.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox9.Visible = False

            PictureBox5.Visible = True
            PictureBox8.Visible = True

        ElseIf foarfecaButon.Checked And Number = Hartie Then
            Label7.Text = "Ai castigat"
            x += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox7.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox8.Visible = False

            PictureBox5.Visible = True
            PictureBox9.Visible = True

        End If

        If hartieButon.Checked And Number = Piatra Then
            Label7.Text = "Ai castigat"
            x += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox5.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox4.Visible = False

            PictureBox6.Visible = True
            PictureBox7.Visible = True

        ElseIf hartieButon.Checked And Number = Foarfeca Then
            Label7.Text = "Ai pierdut"
            y += 1
            Label5.Text = x
            Label6.Text = y

            PictureBox5.Visible = False
            PictureBox4.Visible = False
            PictureBox9.Visible = False
            PictureBox7.Visible = False

            PictureBox6.Visible = True
            PictureBox8.Visible = True

        ElseIf hartieButon.Checked And Number = Hartie Then
            Label7.Text = "Egalitate"
            Label5.Text = x
            Label6.Text = y


            PictureBox5.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False

            PictureBox6.Visible = True
            PictureBox9.Visible = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = 0
        y = 0
        Label5.Text = "0"
        Label6.Text = "0"
        Label7.Text = "Alege-ti arma:"
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        piatraButon.Checked = CheckState.Unchecked
        foarfecaButon.Checked = CheckState.Unchecked
        hartieButon.Checked = CheckState.Unchecked
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Exit1_Mouse_in(sender As Object, e As EventArgs) Handles Exit1.MouseEnter
        Exit1.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub Exit1_Mouse_out(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.BackColor = Color.FloralWhite
    End Sub

    Private Sub Button1_Mouse_in(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Gold
    End Sub
    Private Sub Button1_Mouse_out(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FloralWhite
    End Sub

    Private Sub Button2_Mouse_in(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Orange
    End Sub

    Private Sub Button2_Mouse_out(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FloralWhite
    End Sub

    Private Sub Button3_Mouse_in(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub Button3_Mouse_out(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FloralWhite
    End Sub

    Private Sub piatraButon_Mouse_in(sender As Object, e As EventArgs) Handles piatraButon.MouseEnter
        piatraButon.BackColor = Color.DarkTurquoise
    End Sub
    Private Sub piatraButon_Mouse_out(sender As Object, e As EventArgs) Handles piatraButon.MouseLeave
        piatraButon.BackColor = Color.Transparent
    End Sub
    Private Sub hartieButon_Mouse_in(sender As Object, e As EventArgs) Handles hartieButon.MouseEnter
        hartieButon.BackColor = Color.Crimson
    End Sub
    Private Sub hartieButon_Mouse_out(sender As Object, e As EventArgs) Handles hartieButon.MouseLeave
        hartieButon.BackColor = Color.Transparent
    End Sub
    Private Sub foarfecaButon_Mouse_in(sender As Object, e As EventArgs) Handles foarfecaButon.MouseEnter
        foarfecaButon.BackColor = Color.Gold
    End Sub
    Private Sub foarfecaButon_Mouse_out(sender As Object, e As EventArgs) Handles foarfecaButon.MouseLeave
        foarfecaButon.BackColor = Color.Transparent
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class