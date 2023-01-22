Imports System.IO
Public Class Form1
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub
    Private Sub ExitBtn_Mouse_in(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        ExitBtn.BackColor = Color.LightGray
    End Sub
    Private Sub ExitBtn_Mouse_out(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        ExitBtn.BackColor = Color.LightSteelBlue
    End Sub
    Private Sub Button1_Mouse_in(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.LightGray
    End Sub
    Private Sub Button1_Mouse_out(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Thistle
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Dim User As String
        Dim Parola As String
        Dim ListaGrupe(4) As RadioButton
        Dim ListaUtilizatoriGrupe(4) As ComboBox
        Dim ListaParoleGrupe(4) As ComboBox


        ListaGrupe(0) = Me.Grupa1
        ListaGrupe(1) = Me.Grupa2
        ListaGrupe(2) = Me.Grupa3
        ListaGrupe(3) = Me.Grupa4
        ListaGrupe(4) = Me.Grupa5


        ListaUtilizatoriGrupe(0) = Form2.UtilizatorGrupa1
        ListaUtilizatoriGrupe(1) = Form2.UtilizatorGrupa2
        ListaUtilizatoriGrupe(2) = Form2.UtilizatorGrupa3
        ListaUtilizatoriGrupe(3) = Form2.UtilizatorGrupa4
        ListaUtilizatoriGrupe(4) = Form2.UtilizatorGrupa5


        ListaParoleGrupe(0) = Form2.ParoleGrupa1
        ListaParoleGrupe(1) = Form2.ParoleGrupa2
        ListaParoleGrupe(2) = Form2.ParoleGrupa3
        ListaParoleGrupe(3) = Form2.ParoleGrupa4
        ListaParoleGrupe(4) = Form2.ParoleGrupa5


        User = TextBox1.Text
        Parola = TextBox2.Text

        For i = 1 To ListaGrupe.Length - 1
            If ListaGrupe(0).Checked = True Then
                For comboItem = 0 To ListaUtilizatoriGrupe(0).Items.Count - 1
                    If User = ListaUtilizatoriGrupe(0).Items(comboItem) And Parola = ListaParoleGrupe(0).Items(comboItem) Then
                        Me.Hide()
                        Form2.Show()
                        Exit For
                    End If

                    If comboItem = ListaUtilizatoriGrupe(0).Items.Count - 1 Then
                        MsgBox("Utilizatorul nu se afla in grupa! ")
                        Exit Sub
                    End If
                Next

            Else
                If ListaGrupe(i).Checked = True Then
                    For comboItem = 0 To ListaUtilizatoriGrupe(i).Items.Count - 1
                        If User = ListaUtilizatoriGrupe(i).Items(comboItem) And Parola = ListaParoleGrupe(i).Items(comboItem) Then
                            Me.Hide()
                            Form3.Show()
                            Exit For
                        End If
                        If comboItem = ListaUtilizatoriGrupe(i).Items.Count - 1 Then
                            MsgBox("Utilizatorul nu se afla in grupa! ")
                        End If
                    Next
                End If

            End If
        Next

    End Sub
    Private Sub Ok_Mouse_in(sender As Object, e As EventArgs) Handles Ok.MouseEnter
        Ok.BackColor = Color.LightGray
    End Sub
    Private Sub Ok_Mouse_out(sender As Object, e As EventArgs) Handles Ok.MouseLeave
        Ok.BackColor = Color.Pink
    End Sub

    Private Sub Grupa1_Mouse_in(sender As Object, e As EventArgs) Handles Grupa1.MouseEnter
        Grupa1.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa1_Mouse_out(sender As Object, e As EventArgs) Handles Grupa1.MouseLeave
        Grupa1.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa2_Mouse_in(sender As Object, e As EventArgs) Handles Grupa2.MouseEnter
        Grupa2.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa2_Mouse_out(sender As Object, e As EventArgs) Handles Grupa2.MouseLeave
        Grupa2.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa3_Mouse_in(sender As Object, e As EventArgs) Handles Grupa3.MouseEnter
        Grupa3.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa3_Mouse_out(sender As Object, e As EventArgs) Handles Grupa3.MouseLeave
        Grupa3.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa4_Mouse_in(sender As Object, e As EventArgs) Handles Grupa4.MouseEnter
        Grupa4.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa4_Mouse_out(sender As Object, e As EventArgs) Handles Grupa4.MouseLeave
        Grupa4.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa5_Mouse_in(sender As Object, e As EventArgs) Handles Grupa5.MouseEnter
        Grupa5.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa5_Mouse_out(sender As Object, e As EventArgs) Handles Grupa5.MouseLeave
        Grupa5.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa6_Mouse_in(sender As Object, e As EventArgs) Handles Grupa6.MouseEnter
        Grupa6.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa6_Mouse_out(sender As Object, e As EventArgs) Handles Grupa6.MouseLeave
        Grupa6.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa7_Mouse_in(sender As Object, e As EventArgs) Handles Grupa7.MouseEnter
        Grupa7.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa7_Mouse_out(sender As Object, e As EventArgs) Handles Grupa7.MouseLeave
        Grupa7.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa8_Mouse_in(sender As Object, e As EventArgs) Handles Grupa8.MouseEnter
        Grupa8.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa8_Mouse_out(sender As Object, e As EventArgs) Handles Grupa8.MouseLeave
        Grupa8.BackColor = Color.Transparent
    End Sub
    Private Sub Grupa9_Mouse_in(sender As Object, e As EventArgs) Handles Grupa9.MouseEnter
        Grupa9.BackColor = Color.Thistle
    End Sub
    Private Sub Grupa9_Mouse_out(sender As Object, e As EventArgs) Handles Grupa9.MouseLeave
        Grupa9.BackColor = Color.Transparent
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
    Private Sub CheckBox1_Mouse_in(sender As Object, e As EventArgs) Handles CheckBox1.MouseEnter
        CheckBox1.BackColor = Color.Thistle
    End Sub
    Private Sub CheckBox1_Mouse_out(sender As Object, e As EventArgs) Handles CheckBox1.MouseLeave
        CheckBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Grupa8_CheckedChanged(sender As Object, e As EventArgs) Handles Grupa8.CheckedChanged

    End Sub

    Private Sub Grupa1_CheckedChanged(sender As Object, e As EventArgs) Handles Grupa1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GRUPA 1
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("!U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa1")
            End If

            If line.Contains("!U") Then
                Form2.ListaNume.Items.Add(line.Replace("!U", ""))
                Form2.UtilizatorGrupa1.Items.Add(line.Replace("!U", ""))
            End If

            If line.Contains("!P") Then
                Form2.ListaParole.Items.Add(line.Replace("!P", ""))
                Form2.ParoleGrupa1.Items.Add(line.Replace("!P", ""))
            End If

        Next
        'GRUPA 2
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("@U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa2")
            End If

            If line.Contains("@U") Then
                Form2.ListaNume.Items.Add(line.Replace("@U", ""))
                Form2.UtilizatorGrupa2.Items.Add(line.Replace("@U", ""))
            End If

            If line.Contains("@P") Then
                Form2.ListaParole.Items.Add(line.Replace("@P", ""))
                Form2.ParoleGrupa2.Items.Add(line.Replace("@P", ""))
            End If

        Next
        'GRUPA 3
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("#U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa3")
            End If

            If line.Contains("#U") Then
                Form2.ListaNume.Items.Add(line.Replace("#U", ""))
                Form2.UtilizatorGrupa3.Items.Add(line.Replace("#U", ""))
            End If

            If line.Contains("#P") Then
                Form2.ListaParole.Items.Add(line.Replace("#P", ""))
                Form2.ParoleGrupa3.Items.Add(line.Replace("#P", ""))
            End If

        Next
        'GRUPA 4
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("$U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa4")
            End If

            If line.Contains("$U") Then
                Form2.ListaNume.Items.Add(line.Replace("$U", ""))
                Form2.UtilizatorGrupa4.Items.Add(line.Replace("$U", ""))
            End If

            If line.Contains("$P") Then
                Form2.ListaParole.Items.Add(line.Replace("$P", ""))
                Form2.ParoleGrupa4.Items.Add(line.Replace("$P", ""))
            End If

        Next
        'GRUPA 5
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("%U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa5")
            End If

            If line.Contains("%U") Then
                Form2.ListaNume.Items.Add(line.Replace("%U", ""))
                Form2.UtilizatorGrupa5.Items.Add(line.Replace("%U", ""))
            End If

            If line.Contains("%P") Then
                Form2.ListaParole.Items.Add(line.Replace("%P", ""))
                Form2.ParoleGrupa5.Items.Add(line.Replace("%P", ""))
            End If

        Next
        'GRUPA 6
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("^U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa6")
            End If

            If line.Contains("^U") Then
                Form2.ListaNume.Items.Add(line.Replace("^U", ""))
                Form2.UtilizatorGrupa6.Items.Add(line.Replace("^U", ""))
            End If

            If line.Contains("^P") Then
                Form2.ListaParole.Items.Add(line.Replace("^P", ""))
                Form2.ParoleGrupa6.Items.Add(line.Replace("^P", ""))
            End If

        Next
        'GRUPA 7
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("&U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa7")
            End If

            If line.Contains("&U") Then
                Form2.ListaNume.Items.Add(line.Replace("&U", ""))
                Form2.UtilizatorGrupa7.Items.Add(line.Replace("&U", ""))
            End If

            If line.Contains("&P") Then
                Form2.ListaParole.Items.Add(line.Replace("&P", ""))
                Form2.ParoleGrupa7.Items.Add(line.Replace("&P", ""))
            End If

        Next
        'GRUPA 8
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("*U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa8")
            End If

            If line.Contains("*U") Then
                Form2.ListaNume.Items.Add(line.Replace("*U", ""))
                Form2.UtilizatorGrupa8.Items.Add(line.Replace("*U", ""))
            End If

            If line.Contains("*P") Then
                Form2.ListaParole.Items.Add(line.Replace("*P", ""))
                Form2.ParoleGrupa8.Items.Add(line.Replace("*P", ""))
            End If

        Next
        'GRUPA 9
        For Each line As String In File.ReadLines("C:\Users\User\Desktop\Data.txt")

            If line.Contains("(U") Then
                Form2.ListaGrupeMembri.Items.Add("Grupa9")
            End If

            If line.Contains("(U") Then
                Form2.ListaNume.Items.Add(line.Replace("(U", ""))
                Form2.UtilizatorGrupa9.Items.Add(line.Replace("(U", ""))
            End If

            If line.Contains("(P") Then
                Form2.ListaParole.Items.Add(line.Replace("(P", ""))
                Form2.ParoleGrupa9.Items.Add(line.Replace("(P", ""))
            End If

        Next
        MsgBox("Datele au fost introduse cu success.")

    End Sub
End Class
