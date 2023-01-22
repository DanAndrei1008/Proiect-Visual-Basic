Public Class Form3
    Dim folder As String

    Public Sub Afisare_Lista()
        If ListBox1.Items.Count > 0 Then
            ListBox1.Show()
            AxWindowsMediaPlayer1.Width = 664
        Else
            ListBox1.Hide()
            AxWindowsMediaPlayer1.Width = 979
        End If
    End Sub

    Private Sub Inapoi_Click(sender As Object, e As EventArgs) Handles Inapoi.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Inapoi_Mouse_in(sender As Object, e As EventArgs) Handles Inapoi.MouseEnter
        Inapoi.BackColor = Color.SteelBlue
    End Sub
    Private Sub Inapoi_Mouse_out(sender As Object, e As EventArgs) Handles Inapoi.MouseLeave
        Inapoi.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        End
    End Sub

    Private Sub Exit1_Mouse_in(sender As Object, e As EventArgs) Handles Exit1.MouseEnter
        Exit1.BackColor = Color.SteelBlue
    End Sub
    Private Sub Exit1_Mouse_out(sender As Object, e As EventArgs) Handles Exit1.MouseLeave
        Exit1.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.ShowDialog() 'video
        ToolStripButton2.Enabled = True
        If ListBox1.Items.Count > 0 Then
            ListBox1.Hide()
            AxWindowsMediaPlayer1.Width = 979
        Else
            ListBox1.Show()
            AxWindowsMediaPlayer1.Width = 664
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox1.Hide()
        AxWindowsMediaPlayer1.Width = 979
    End Sub

    Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click
        Try
            ToolStripButton2.Enabled = False
            FolderBrowserDialog1.ShowDialog()
            If DialogResult.OK Then
                Dim di As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath) 'Extrage toata adresa folderului selectat
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.mp3") 'Extrage doar fisiere .mp3
                Dim dra As IO.FileInfo 'Extrage informatiile unui singur .mp3
                folder = di.FullName.ToString
                ListBox1.Items.Clear()
                For Each dra In diar1 'Pentru fiecare melodie din folder
                    Dim a As Integer = 0
                    ' a = a + 1
                    ListBox1.Items.Add(dra) 'Adaugam in lista
                Next
                Afisare_Lista()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = folder & "\" & ListBox1.SelectedItem.ToString
    End Sub

    Private Sub VideosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideosToolStripMenuItem.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            If DialogResult.OK Then

                Dim di As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
                Dim diar1 As IO.FileInfo() = di.GetFiles("*.*")
                Dim dra As IO.FileInfo
                folder = di.FullName.ToString
                ListBox1.Items.Clear()
                For Each dra In diar1
                    ListBox1.Items.Add(dra)
                Next
                Afisare_Lista()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
