Public Class Form3
    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.LightGray
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Exit1_Mouse_in(sender As Object, e As EventArgs) Handles Exit1.MouseEnter
        Exit1.BackColor = Color.LightGray
    End Sub
    Private Sub Exit1_Mouse_out(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button2_Mouse_in(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.LightGray
    End Sub

    Private Sub Button2_Mouse_out(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Inmultire1.CheckedChanged
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Inmultire.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Inmultire.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) * Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = Inmultire.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Rezultatul.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles adunare.Click
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = adunare.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = adunare.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) + Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = adunare.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Scadere.Click
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Scadere.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Scadere.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) - Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = Scadere.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Inmultire.Click
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Inmultire.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Inmultire.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) * Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = Inmultire.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Impartire.Click
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Inmultire.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                If Convert.ToDecimal(Valoare2.Text) = 0 Then
                    Semnul.Text = Impartire.Text
                    Rezultatul.Text = "Nu se poate efectua impartirea la 0"
                Else
                    Semnul.Text = Impartire.Text
                    Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) / Convert.ToDecimal(Valoare2.Text))
                End If
            Else
                Semnul.Text = Impartire.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Radical.Click
        Dim x As Integer
        If String.IsNullOrEmpty(Valoare1.Text) = True Then
            Rezultatul.Text = "Va rog sa introduceti o valoare"
        Else
            x = Convert.ToDecimal(Valoare1.Text)
            If String.IsNullOrEmpty(Valoare1.Text) Then
                Semnul.Text = Radical.Text
            Else
                If IsNumeric(Valoare1.Text) = True Then
                    Semnul.Text = Radical.Text
                    Rezultatul.Text = Convert.ToString((Math.Sqrt(x)))
                Else
                    Semnul.Text = Radical.Text
                    Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Procent.Click
        Dim x As Integer
        If String.IsNullOrEmpty(Valoare1.Text) = True Or String.IsNullOrEmpty(Valoare2.Text) Then
            Rezultatul.Text = "Va rog sa introduceti o valoare"
        Else
            x = Convert.ToDecimal(Valoare2.Text)
            If String.IsNullOrEmpty(Valoare1.Text) Then
                Semnul.Text = Procent.Text
            Else
                Dim a As Integer
                If IsNumeric(Valoare1.Text) = True Then
                    If Not Integer.Parse(Me.Valoare2.Text) Then
                        a = 1

                    End If
                    Semnul.Text = Procent.Text
                    If a = 1 Then
                        Rezultatul.Text = (Val(Valoare1.Text) / 100) * x
                    End If
                Else
                    Semnul.Text = Procent.Text
                    Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
                End If
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Concatenare.Click
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Concatenare.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Concatenare.Text
                Rezultatul.Text = Valoare1.Text + Valoare2.Text
            Else
                Semnul.Text = Concatenare.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            adunare.Show()
            Scadere.Show()
            Inmultire.Show()
            Impartire.Show()
            Concatenare.Show()
            Radical.Show()
            Procent.Show()
            CheckBox2.Enabled = False
        Else
            adunare.Hide()
            Scadere.Hide()
            Inmultire.Hide()
            Impartire.Hide()
            Concatenare.Hide()
            Radical.Hide()
            Procent.Hide()
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles Concatenare1.CheckedChanged
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Concatenare.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Concatenare.Text
                Rezultatul.Text = Valoare1.Text + Valoare2.Text
            Else
                Semnul.Text = Concatenare.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Valoare1.Text = ""
        Valoare2.Text = ""
        Semnul.Text = ""
        Rezultatul.Text = ""
        CheckBox1.CheckState = CheckState.Unchecked
        CheckBox2.CheckState = CheckState.Unchecked
        Plus.Checked = False
        Minus.Checked = False
        Inmultire1.Checked = False
        Impartire1.Checked = False
        Radical1.Checked = False
        Procent1.Checked = False
        Concatenare1.Checked = False

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            Plus.Show()
            Minus.Show()
            Inmultire1.Show()
            Impartire1.Show()
            Radical1.Show()
            Procent1.Show()
            Concatenare1.Show()
            CheckBox1.Enabled = False
        Else
            Plus.Hide()
            Minus.Hide()
            Inmultire1.Hide()
            Impartire1.Hide()
            Radical1.Hide()
            Procent1.Hide()
            Concatenare1.Hide()
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub Plus_CheckedChanged(sender As Object, e As EventArgs) Handles Plus.CheckedChanged
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = adunare.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = adunare.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) + Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = adunare.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Minus_CheckedChanged(sender As Object, e As EventArgs) Handles Minus.CheckedChanged
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Scadere.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                Semnul.Text = Scadere.Text
                Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) - Convert.ToDecimal(Valoare2.Text))
            Else
                Semnul.Text = Scadere.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Impartire1_CheckedChanged(sender As Object, e As EventArgs) Handles Impartire1.CheckedChanged
        If String.IsNullOrEmpty(Valoare1.Text) Or String.IsNullOrEmpty(Valoare2.Text) Then
            Semnul.Text = Inmultire.Text
        Else
            If IsNumeric(Valoare1.Text) = True And IsNumeric(Valoare2.Text) = True Then
                If Convert.ToDecimal(Valoare2.Text) = 0 Then
                    Semnul.Text = Impartire.Text
                    Rezultatul.Text = "Nu se poate efectua impartirea la 0"
                Else
                    Semnul.Text = Impartire.Text
                    Rezultatul.Text = Convert.ToString(Convert.ToDecimal(Valoare1.Text) / Convert.ToDecimal(Valoare2.Text))
                End If
            Else
                Semnul.Text = Impartire.Text
                Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
            End If
        End If
    End Sub

    Private Sub Radical1_CheckedChanged(sender As Object, e As EventArgs) Handles Radical1.CheckedChanged
        Dim x As Integer
        If String.IsNullOrEmpty(Valoare1.Text) = True Then
            Rezultatul.Text = "Va rog sa introduceti o valoare"
        Else
            x = Convert.ToDecimal(Valoare1.Text)
            If String.IsNullOrEmpty(Valoare1.Text) Then
                Semnul.Text = Radical.Text
            Else
                If IsNumeric(Valoare1.Text) = True Then
                    Semnul.Text = Radical.Text
                    Rezultatul.Text = Convert.ToString((Math.Sqrt(x)))
                Else
                    Semnul.Text = Radical.Text
                    Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
                End If
            End If
        End If
    End Sub

    Private Sub Procent1_CheckedChanged(sender As Object, e As EventArgs) Handles Procent1.CheckedChanged
        Dim x As Integer
        If String.IsNullOrEmpty(Valoare1.Text) = True Or String.IsNullOrEmpty(Valoare2.Text) Then
            Rezultatul.Text = "Va rog sa introduceti o valoare"
        Else
            x = Convert.ToDecimal(Valoare2.Text)
            If String.IsNullOrEmpty(Valoare1.Text) Then
                Semnul.Text = Procent.Text
            Else
                Dim a As Integer
                If IsNumeric(Valoare1.Text) = True Then
                    If Not Integer.Parse(Me.Valoare2.Text) Then
                        a = 1

                    End If
                    Semnul.Text = Procent.Text
                    If a = 1 Then
                        Rezultatul.Text = (Val(Valoare1.Text) / 100) * x
                    End If
                Else
                    Semnul.Text = Procent.Text
                    Rezultatul.Text = "Va rog sa introduceti doar valori numerice!"
                End If
            End If
        End If
    End Sub
    Private Sub CheckBox1_Mouse_in(sender As Object, e As EventArgs) Handles CheckBox1.MouseEnter
        CheckBox1.BackColor = Color.DimGray
    End Sub
    Private Sub CheckBox1_Mouse_out(sender As Object, e As EventArgs) Handles CheckBox1.MouseLeave
        CheckBox1.BackColor = Color.Transparent
    End Sub
    Private Sub CheckBox2_Mouse_in(sender As Object, e As EventArgs) Handles CheckBox2.MouseEnter
        CheckBox2.BackColor = Color.DimGray
    End Sub
    Private Sub CheckBox2_Mouse_out(sender As Object, e As EventArgs) Handles CheckBox2.MouseLeave
        CheckBox2.BackColor = Color.Transparent
    End Sub
    Private Sub adunare_Mouse_in(sender As Object, e As EventArgs) Handles adunare.MouseEnter
        adunare.BackColor = Color.LightGray
    End Sub
    Private Sub adunare_Mouse_out(sender As Object, e As EventArgs) Handles adunare.MouseLeave
        adunare.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Scadere_Mouse_in(sender As Object, e As EventArgs) Handles Scadere.MouseEnter
        Scadere.BackColor = Color.LightGray
    End Sub
    Private Sub Scadere_Mouse_out(sender As Object, e As EventArgs) Handles Scadere.MouseLeave
        Scadere.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Inmultire_Mouse_in(sender As Object, e As EventArgs) Handles Inmultire.MouseEnter
        Inmultire.BackColor = Color.LightGray
    End Sub
    Private Sub Inmultire_Mouse_out(sender As Object, e As EventArgs) Handles Inmultire.MouseLeave
        Inmultire.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Impartire_Mouse_in(sender As Object, e As EventArgs) Handles Impartire.MouseEnter
        Impartire.BackColor = Color.LightGray
    End Sub
    Private Sub Impartire_Mouse_out(sender As Object, e As EventArgs) Handles Impartire.MouseLeave
        Impartire.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Radical_Mouse_in(sender As Object, e As EventArgs) Handles Radical.MouseEnter
        Radical.BackColor = Color.LightGray
    End Sub
    Private Sub Radical_Mouse_out(sender As Object, e As EventArgs) Handles Radical.MouseLeave
        Radical.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Procent_Mouse_in(sender As Object, e As EventArgs) Handles Procent.MouseEnter
        Procent.BackColor = Color.LightGray
    End Sub
    Private Sub Procent_Mouse_out(sender As Object, e As EventArgs) Handles Procent.MouseLeave
        Procent.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Concatenare_Mouse_in(sender As Object, e As EventArgs) Handles Concatenare.MouseEnter
        Concatenare.BackColor = Color.LightGray
    End Sub
    Private Sub Concatenare_Mouse_out(sender As Object, e As EventArgs) Handles Concatenare.MouseLeave
        Concatenare.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Plus_Mouse_in(sender As Object, e As EventArgs) Handles Plus.MouseEnter
        Plus.BackColor = Color.DimGray
    End Sub
    Private Sub Plus_Mouse_out(sender As Object, e As EventArgs) Handles Plus.MouseLeave
        Plus.BackColor = Color.Transparent
    End Sub
    Private Sub Minus_Mouse_in(sender As Object, e As EventArgs) Handles Minus.MouseEnter
        Minus.BackColor = Color.DimGray
    End Sub
    Private Sub Minus_Mouse_out(sender As Object, e As EventArgs) Handles Minus.MouseLeave
        Minus.BackColor = Color.Transparent
    End Sub
    Private Sub Inmultire1_Mouse_in(sender As Object, e As EventArgs) Handles Inmultire1.MouseEnter
        Inmultire1.BackColor = Color.DimGray
    End Sub
    Private Sub Inmultire1_Mouse_out(sender As Object, e As EventArgs) Handles Inmultire1.MouseLeave
        Inmultire1.BackColor = Color.Transparent
    End Sub
    Private Sub Impartire1_Mouse_in(sender As Object, e As EventArgs) Handles Impartire1.MouseEnter
        Impartire1.BackColor = Color.DimGray
    End Sub
    Private Sub Impartire1_Mouse_out(sender As Object, e As EventArgs) Handles Impartire1.MouseLeave
        Impartire1.BackColor = Color.Transparent
    End Sub
    Private Sub Radical1_Mouse_in(sender As Object, e As EventArgs) Handles Radical1.MouseEnter
        Radical1.BackColor = Color.DimGray
    End Sub
    Private Sub Radical1_Mouse_out(sender As Object, e As EventArgs) Handles Radical1.MouseLeave
        Radical1.BackColor = Color.Transparent
    End Sub
    Private Sub Procent1_Mouse_in(sender As Object, e As EventArgs) Handles Procent1.MouseEnter
        Procent1.BackColor = Color.DimGray
    End Sub
    Private Sub Procent1_Mouse_out(sender As Object, e As EventArgs) Handles Procent1.MouseLeave
        Procent1.BackColor = Color.Transparent
    End Sub
    Private Sub Concatenare1_Mouse_in(sender As Object, e As EventArgs) Handles Concatenare1.MouseEnter
        Concatenare1.BackColor = Color.DimGray
    End Sub
    Private Sub Concatenare1_Mouse_out(sender As Object, e As EventArgs) Handles Concatenare1.MouseLeave
        Concatenare1.BackColor = Color.Transparent
    End Sub
End Class
