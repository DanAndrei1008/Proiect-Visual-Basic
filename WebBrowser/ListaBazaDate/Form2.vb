Public Class Form2
    Dim I1 As Integer
    Dim ListaUtilizatoriGrupe(8) As ComboBox
    Dim ListaParoleGrupe(8) As ComboBox
    Dim ListaDenumiriGrupe(8) As Label
    Dim ListaLoginGrupe(8) As RadioButton
    Dim x As Integer
    Private Sub Adauga_Click(sender As Object, e As EventArgs) Handles Adauga.Click
        I1 = Grupe.SelectedIndex

        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9

        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        If Trim(Username.Text) = "" Or Trim(Parola.Text) = "" Or I1 < 0 Then
            MsgBox("Utilizatorul, parola sau grupa nu a/au fost selectat/e!")
        Else
            If Me.ListaNume.Items.Contains(Me.Username.Text) = False And Me.ListaParole.Items.Contains(Me.Parola.Text) = False Then
                Me.ListaNume.Items.Add(Me.Username.Text)
                Me.ListaParole.Items.Add(Me.Parola.Text)
                ListaUtilizatoriGrupe(I1).Items.Add(Me.Username.Text)
                ListaParoleGrupe(I1).Items.Add(Me.Parola.Text)
                ListaGrupeMembri.Items.Add(Grupe.Items(I1).ToString())
                Me.Username.Clear()
                Me.Parola.Clear()
            Else
                MsgBox("Elementul exista deja!")
            End If
        End If
    End Sub
    Private Sub Adauga_Mouse_in(sender As Object, e As EventArgs) Handles Adauga.MouseEnter
        Adauga.BackColor = Color.CadetBlue
    End Sub
    Private Sub Adauga_Mouse_out(sender As Object, e As EventArgs) Handles Adauga.MouseLeave
        Adauga.BackColor = Color.AliceBlue
    End Sub

    Private Sub Sterge_Click(sender As Object, e As EventArgs) Handles Sterge.Click
        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9


        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        I1 = ListaNume.SelectedIndex
        If I1 >= 0 Then
            For i = 0 To ListaUtilizatoriGrupe.Length - 1
                If ListaUtilizatoriGrupe(i).Items.Contains(ListaNume.Items(I1).ToString()) Then
                    ListaUtilizatoriGrupe(i).Items.Remove(ListaNume.Items(I1).ToString())
                    ListaParoleGrupe(i).Items.Remove(ListaParole.Items(I1).ToString())
                End If
            Next
            Me.ListaNume.Items.RemoveAt(I1)
            Me.ListaParole.Items.RemoveAt(I1)
            Me.ListaGrupeMembri.Items.RemoveAt(I1)

        Else
            MsgBox("Selectati elementul de sters")
        End If
    End Sub
    Private Sub Sterge_Mouse_in(sender As Object, e As EventArgs) Handles Sterge.MouseEnter
        Sterge.BackColor = Color.CadetBlue
    End Sub
    Private Sub Sterge_Mouse_out(sender As Object, e As EventArgs) Handles Sterge.MouseLeave
        Sterge.BackColor = Color.AliceBlue
    End Sub

    Private Sub Modifica1_Click(sender As Object, e As EventArgs) Handles Modifica1.Click
        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9


        I1 = ListaNume.SelectedIndex

        If Trim(Username.Text) = "" Then
            MsgBox("Utilizatorul nu a fost selectat!")
        Else
            If Me.ListaNume.Items.Contains(Me.Username.Text) = False And I1 >= 0 Then

                For i = 0 To ListaUtilizatoriGrupe.Count() - 1
                    For j = 0 To ListaUtilizatoriGrupe(i).Items.Count - 1
                        If ListaUtilizatoriGrupe(i).Items(j).ToString() = ListaNume.SelectedItem.ToString() Then
                            ListaNume.Items(I1) = Me.Username.Text
                            ListaUtilizatoriGrupe(i).Items(j) = Me.Username.Text
                        End If
                    Next
                Next

                Me.Username.Clear()
            Else
                MsgBox("Elementul exista deja!")
            End If
        End If
    End Sub
    Private Sub Modifica1_Mouse_in(sender As Object, e As EventArgs) Handles Modifica1.MouseEnter
        Modifica1.BackColor = Color.CadetBlue
    End Sub
    Private Sub Modifica1_Mouse_out(sender As Object, e As EventArgs) Handles Modifica1.MouseLeave
        Modifica1.BackColor = Color.AliceBlue
    End Sub
    Private Sub Modifica2_Click(sender As Object, e As EventArgs) Handles Modifica2.Click
        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9
        I1 = ListaParole.SelectedIndex

        If Trim(Parola.Text) = "" Then
            MsgBox("Parola nu a fost selectata!")
        Else
            If Me.ListaParole.Items.Contains(Me.Parola.Text) = False And I1 >= 0 Then

                For i = 0 To ListaParoleGrupe.Count() - 1
                    For j = 0 To ListaParoleGrupe(i).Items.Count - 1
                        If ListaParoleGrupe(i).Items(j).ToString() = ListaParole.SelectedItem.ToString() Then
                            ListaParole.Items(I1) = Me.Parola.Text
                            ListaParoleGrupe(i).Items(j) = Me.Parola.Text
                        End If
                    Next
                Next

                Me.Parola.Clear()
            Else
                MsgBox("Elementul exista deja!")
            End If
        End If
    End Sub
    Private Sub Modifica2_Mouse_in(sender As Object, e As EventArgs) Handles Modifica2.MouseEnter
        Modifica2.BackColor = Color.CadetBlue
    End Sub
    Private Sub Modifica2_Mouse_out(sender As Object, e As EventArgs) Handles Modifica2.MouseLeave
        Modifica2.BackColor = Color.AliceBlue
    End Sub

    Private Sub Cautare1_CheckedChanged(sender As Object, e As EventArgs) Handles Cautare1.CheckedChanged
        If Cautare1.CheckState = CheckState.Checked Then
            Adauga.Enabled = False
            Modifica1.Enabled = False
            Modifica2.Enabled = False
            Sterge.Enabled = False
            ExitBtn.Enabled = False
            Inapoi.Enabled = False
            Urmatorul.Enabled = False
            Adauga2.Enabled = False
            Sterge2.Enabled = False

            If Trim(Username.Text) = "" Then
                MsgBox("Nu exista niciun Utilizator a de cautat!")
            Else
                For i = 0 To ListaNume.Items.Count - 1
                    If ListaNume.Items(i).ToString() = Username.Text Then
                        MsgBox("Utilizatorul apartine Listei!")
                        ListaNume.SetSelected(i, True)
                        ListaParole.SetSelected(i, True)
                        Exit For
                    Else
                        If i = ListaNume.Items.Count - 1 Then
                            MsgBox("Utilizatorul nu apartine Listei!")
                        End If
                    End If
                Next
            End If
        Else
            Adauga.Enabled = True
            Modifica1.Enabled = True
            Modifica2.Enabled = True
            Sterge.Enabled = True
            Reset.Enabled = True
            ExitBtn.Enabled = True
            Inapoi.Enabled = True
            Urmatorul.Enabled = True
            Adauga2.Enabled = True
            Sterge2.Enabled = True
            Username.Text = String.Empty
        End If

    End Sub
    Private Sub Cautare1_Mouse_in(sender As Object, e As EventArgs) Handles Cautare1.MouseEnter
        Cautare1.BackColor = Color.CadetBlue
    End Sub
    Private Sub Cautare1_Mouse_out(sender As Object, e As EventArgs) Handles Cautare1.MouseLeave
        Cautare1.BackColor = Color.Transparent
    End Sub
    Private Sub Cautare2_CheckedChanged(sender As Object, e As EventArgs) Handles Cautare2.CheckedChanged
        If Cautare2.CheckState = CheckState.Checked Then
            Adauga.Enabled = False
            Modifica1.Enabled = False
            Modifica2.Enabled = False
            Sterge.Enabled = False
            ExitBtn.Enabled = False
            Inapoi.Enabled = False
            Urmatorul.Enabled = False
            Adauga2.Enabled = False
            Sterge2.Enabled = False
            If Trim(Parola.Text) = "" Then
                MsgBox("Nu exista nicio parola de cautat")
            Else
                For i = 0 To ListaParole.Items.Count - 1
                    If ListaParole.Items(i).ToString() = Parola.Text Then
                        MsgBox("Parola apartine Listei!")
                        ListaNume.SetSelected(i, True)
                        ListaParole.SetSelected(i, True)
                        Exit For
                    Else
                        If i = ListaParole.Items.Count - 1 Then
                            MsgBox("Parola Nu apartine Listei!")
                        End If
                    End If
                Next
            End If
        Else
            Adauga.Enabled = True
            Modifica1.Enabled = True
            Modifica2.Enabled = True
            Sterge.Enabled = True
            Reset.Enabled = True
            ExitBtn.Enabled = True
            Inapoi.Enabled = True
            Urmatorul.Enabled = True
            Adauga2.Enabled = True
            Sterge2.Enabled = True
            Parola.Text = String.Empty
        End If
    End Sub
    Private Sub Cautare2_Mouse_in(sender As Object, e As EventArgs) Handles Cautare2.MouseEnter
        Cautare2.BackColor = Color.CadetBlue
    End Sub
    Private Sub Cautare2_Mouse_out(sender As Object, e As EventArgs) Handles Cautare2.MouseLeave
        Cautare2.BackColor = Color.Transparent
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub
    Private Sub ExitBtn_Mouse_in(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        ExitBtn.BackColor = Color.CadetBlue
    End Sub
    Private Sub ExitBtn_Mouse_out(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        ExitBtn.BackColor = Color.AliceBlue
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9


        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        ListaNume.Items.Clear()
        ListaParole.Items.Clear()
        ListaGrupeMembri.Items.Clear()

        For i = 0 To ListaUtilizatoriGrupe.Count - 1

            If ListaUtilizatoriGrupe(i).Visible = False Then

            Else
                For j = 0 To ListaUtilizatoriGrupe(i).Items.Count - 1
                    ListaNume.Items.Add(ListaUtilizatoriGrupe(i).Items(j))
                    ListaGrupeMembri.Items.Add("Grupa " + CStr(i + 1))
                Next
            End If


        Next

        For i = 0 To ListaParoleGrupe.Count - 1

            If ListaParoleGrupe(i).Visible = False Then

            Else
                For j = 0 To ListaParoleGrupe(i).Items.Count - 1
                    ListaParole.Items.Add(ListaParoleGrupe(i).Items(j))
                Next
            End If

        Next


        Cautare1.CheckState = CheckState.Unchecked
        Cautare2.CheckState = CheckState.Unchecked
        Username.Text = ""
        Parola.Text = ""

        If ListaParole.SelectedIndex >= 0 Then
            ListaParole.SetSelected(ListaParole.SelectedIndex, False)
        End If
        If ListaNume.SelectedIndex >= 0 Then
            ListaNume.SetSelected(ListaNume.SelectedIndex, False)
        End If
    End Sub
    Private Sub Reset_Mouse_in(sender As Object, e As EventArgs) Handles Reset.MouseEnter
        Reset.BackColor = Color.CadetBlue
    End Sub
    Private Sub Reset_Mouse_out(sender As Object, e As EventArgs) Handles Reset.MouseLeave
        Reset.BackColor = Color.AliceBlue
    End Sub

    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.CadetBlue
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.AliceBlue
    End Sub

    Private Sub Urmatorul_Click(sender As Object, e As EventArgs) Handles Urmatorul.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Urmatorul_Mouse_in(sender As Object, e As EventArgs) Handles Urmatorul.MouseEnter
        Urmatorul.BackColor = Color.CadetBlue
    End Sub
    Private Sub Urmatorul_Mouse_out(sender As Object, e As EventArgs) Handles Urmatorul.MouseLeave
        Urmatorul.BackColor = Color.AliceBlue
    End Sub

    Private Sub Grupe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grupe.SelectedIndexChanged
        I1 = Grupe.SelectedIndex
        ListaNume.Items.Clear()
        ListaParole.Items.Clear()
        ListaGrupeMembri.Items.Clear()


        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9


        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        For i = 0 To ListaUtilizatoriGrupe(I1).Items.Count - 1
            ListaNume.Items.Add(ListaUtilizatoriGrupe(I1).Items(i))
            ListaParole.Items.Add(ListaParoleGrupe(I1).Items(i))
            ListaGrupeMembri.Items.Add(Grupe.Items(Grupe.SelectedIndex))
        Next
    End Sub
    Private Sub Grupe_Mouse_in(sender As Object, e As EventArgs) Handles Grupe.MouseEnter
        Grupe.BackColor = Color.LightSalmon
    End Sub
    Private Sub Grupe_Mouse_out(sender As Object, e As EventArgs) Handles Grupe.MouseLeave
        Grupe.BackColor = Color.AliceBlue
    End Sub
    'Codurile pentru culorile combo box-urilor pentru Utilizatori:
    Private Sub UtilizatorGrupa1_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa1.MouseEnter
        UtilizatorGrupa1.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa1_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa1.MouseLeave
        UtilizatorGrupa1.BackColor = Color.AliceBlue
    End Sub

    Private Sub UtilizatorGrupa2_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa2.MouseEnter
        UtilizatorGrupa2.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa2_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa2.MouseLeave
        UtilizatorGrupa2.BackColor = Color.AliceBlue
    End Sub

    Private Sub UtilizatorGrupa3_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa3.MouseEnter
        UtilizatorGrupa3.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa3_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa3.MouseLeave
        UtilizatorGrupa3.BackColor = Color.AliceBlue
    End Sub

    Private Sub UtilizatorGrupa4_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa4.MouseEnter
        UtilizatorGrupa4.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa4_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa4.MouseLeave
        UtilizatorGrupa4.BackColor = Color.AliceBlue
    End Sub

    Private Sub UtilizatorGrupa5_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa5.MouseEnter
        UtilizatorGrupa5.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa5_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa5.MouseLeave
        UtilizatorGrupa5.BackColor = Color.AliceBlue
    End Sub
    Private Sub UtilizatorGrupa6_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa6.MouseEnter
        UtilizatorGrupa6.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa6_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa6.MouseLeave
        UtilizatorGrupa6.BackColor = Color.AliceBlue
    End Sub
    Private Sub UtilizatorGrupa7_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa7.MouseEnter
        UtilizatorGrupa7.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa7_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa7.MouseLeave
        UtilizatorGrupa7.BackColor = Color.AliceBlue
    End Sub
    Private Sub UtilizatorGrupa8_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa8.MouseEnter
        UtilizatorGrupa8.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa8_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa8.MouseLeave
        UtilizatorGrupa8.BackColor = Color.AliceBlue
    End Sub
    Private Sub UtilizatorGrupa9_Mouse_in(sender As Object, e As EventArgs) Handles UtilizatorGrupa9.MouseEnter
        UtilizatorGrupa9.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub UtilizatorGrupa9_Mouse_out(sender As Object, e As EventArgs) Handles UtilizatorGrupa9.MouseLeave
        UtilizatorGrupa9.BackColor = Color.AliceBlue
    End Sub

    'Codurile pentru culorile combo box-urilor pentru Parole:

    Private Sub ParoleGrupa1_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa1.MouseEnter
        ParoleGrupa1.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa1_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa1.MouseLeave
        ParoleGrupa1.BackColor = Color.AliceBlue
    End Sub

    Private Sub ParoleGrupa2_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa2.MouseEnter
        ParoleGrupa2.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa2_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa2.MouseLeave
        ParoleGrupa2.BackColor = Color.AliceBlue
    End Sub

    Private Sub ParoleGrupa3_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa3.MouseEnter
        ParoleGrupa3.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa3_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa3.MouseLeave
        ParoleGrupa3.BackColor = Color.AliceBlue
    End Sub

    Private Sub ParoleGrupa4_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa4.MouseEnter
        ParoleGrupa4.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa4_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa4.MouseLeave
        ParoleGrupa4.BackColor = Color.AliceBlue
    End Sub

    Private Sub ParoleGrupa5_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa5.MouseEnter
        ParoleGrupa5.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa5_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa5.MouseLeave
        ParoleGrupa5.BackColor = Color.AliceBlue
    End Sub
    Private Sub ParoleGrupa6_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa6.MouseEnter
        ParoleGrupa6.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa6_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa6.MouseLeave
        ParoleGrupa6.BackColor = Color.AliceBlue
    End Sub
    Private Sub ParoleGrupa7_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa7.MouseEnter
        ParoleGrupa7.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa7_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa7.MouseLeave
        ParoleGrupa7.BackColor = Color.AliceBlue
    End Sub
    Private Sub ParoleGrupa8_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa8.MouseEnter
        ParoleGrupa8.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa8_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa8.MouseLeave
        ParoleGrupa8.BackColor = Color.AliceBlue
    End Sub
    Private Sub ParoleGrupa9_Mouse_in(sender As Object, e As EventArgs) Handles ParoleGrupa9.MouseEnter
        ParoleGrupa9.BackColor = Color.MediumVioletRed
    End Sub
    Private Sub ParoleGrupa9_Mouse_out(sender As Object, e As EventArgs) Handles ParoleGrupa9.MouseLeave
        ParoleGrupa9.BackColor = Color.AliceBlue
    End Sub

    'Codurile pentru culorile butoanelor de editare a grupelor de prelucrare

    Private Sub Adauga2_Mouse_in(sender As Object, e As EventArgs) Handles Adauga2.MouseEnter
        Adauga2.BackColor = Color.SteelBlue
    End Sub
    Private Sub Adauga2_Mouse_out(sender As Object, e As EventArgs) Handles Adauga2.MouseLeave
        Adauga2.BackColor = Color.AliceBlue
    End Sub

    Private Sub Sterge2_Mouse_in(sender As Object, e As EventArgs) Handles Sterge2.MouseEnter
        Sterge2.BackColor = Color.SteelBlue
    End Sub
    Private Sub Sterge2_Mouse_out(sender As Object, e As EventArgs) Handles Sterge2.MouseLeave
        Sterge2.BackColor = Color.AliceBlue
    End Sub

    Public Sub Adauga2_Click(sender As Object, e As EventArgs) Handles Adauga2.Click
        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9

        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        ListaDenumiriGrupe(0) = Grupa1
        ListaDenumiriGrupe(1) = Grupa2
        ListaDenumiriGrupe(2) = Grupa3
        ListaDenumiriGrupe(3) = Grupa4
        ListaDenumiriGrupe(4) = Grupa5
        ListaDenumiriGrupe(5) = Grupa6
        ListaDenumiriGrupe(6) = Grupa7
        ListaDenumiriGrupe(7) = Grupa8
        ListaDenumiriGrupe(8) = Grupa9

        ListaLoginGrupe(0) = Form1.Grupa1
        ListaLoginGrupe(1) = Form1.Grupa2
        ListaLoginGrupe(2) = Form1.Grupa3
        ListaLoginGrupe(3) = Form1.Grupa4
        ListaLoginGrupe(4) = Form1.Grupa5
        ListaLoginGrupe(5) = Form1.Grupa6
        ListaLoginGrupe(6) = Form1.Grupa7
        ListaLoginGrupe(7) = Form1.Grupa8
        ListaLoginGrupe(8) = Form1.Grupa9

        If x = 0 Then
            x = 5
        End If
        If x <> 0 And x < 9 Then

            ListaUtilizatoriGrupe(x).Visible = True
            ListaParoleGrupe(x).Visible = True
            ListaDenumiriGrupe(x).Visible = True
            ListaLoginGrupe(x).Visible = True
            Grupe.Items.Add("Grupa " & x + 1)
            x += 1
        End If

        Label4.Text = x
    End Sub

    Public Sub Sterge2_Click(sender As Object, e As EventArgs) Handles Sterge2.Click
        ListaUtilizatoriGrupe(0) = UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = UtilizatorGrupa5
        ListaUtilizatoriGrupe(5) = UtilizatorGrupa6
        ListaUtilizatoriGrupe(6) = UtilizatorGrupa7
        ListaUtilizatoriGrupe(7) = UtilizatorGrupa8
        ListaUtilizatoriGrupe(8) = UtilizatorGrupa9

        ListaParoleGrupe(0) = ParoleGrupa1
        ListaParoleGrupe(1) = ParoleGrupa2
        ListaParoleGrupe(2) = ParoleGrupa3
        ListaParoleGrupe(3) = ParoleGrupa4
        ListaParoleGrupe(4) = ParoleGrupa5
        ListaParoleGrupe(5) = ParoleGrupa6
        ListaParoleGrupe(6) = ParoleGrupa7
        ListaParoleGrupe(7) = ParoleGrupa8
        ListaParoleGrupe(8) = ParoleGrupa9

        ListaDenumiriGrupe(0) = Grupa1
        ListaDenumiriGrupe(1) = Grupa2
        ListaDenumiriGrupe(2) = Grupa3
        ListaDenumiriGrupe(3) = Grupa4
        ListaDenumiriGrupe(4) = Grupa5
        ListaDenumiriGrupe(5) = Grupa6
        ListaDenumiriGrupe(6) = Grupa7
        ListaDenumiriGrupe(7) = Grupa8
        ListaDenumiriGrupe(8) = Grupa9

        ListaLoginGrupe(0) = Form1.Grupa1
        ListaLoginGrupe(1) = Form1.Grupa2
        ListaLoginGrupe(2) = Form1.Grupa3
        ListaLoginGrupe(3) = Form1.Grupa4
        ListaLoginGrupe(4) = Form1.Grupa5
        ListaLoginGrupe(5) = Form1.Grupa6
        ListaLoginGrupe(6) = Form1.Grupa7
        ListaLoginGrupe(7) = Form1.Grupa8
        ListaLoginGrupe(8) = Form1.Grupa9


        If x = 0 Then
            x = 5
        End If
        If x <> 0 And x <> 1 Then

            ListaUtilizatoriGrupe(x - 1).Visible = False
            ListaParoleGrupe(x - 1).Visible = False
            ListaDenumiriGrupe(x - 1).Visible = False
            ListaLoginGrupe(x - 1).Visible = False
            Grupe.Items.Remove("Grupa " & x)
            x -= 1

        End If
        Label4.Text = x
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class