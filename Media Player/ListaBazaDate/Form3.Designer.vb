<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Inapoi = New System.Windows.Forms.Button()
        Me.Exit1 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inapoi
        '
        Me.Inapoi.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Inapoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Inapoi.Font = New System.Drawing.Font("Bahnschrift", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inapoi.ForeColor = System.Drawing.Color.Black
        Me.Inapoi.Location = New System.Drawing.Point(1125, 671)
        Me.Inapoi.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Inapoi.Name = "Inapoi"
        Me.Inapoi.Size = New System.Drawing.Size(165, 75)
        Me.Inapoi.TabIndex = 34
        Me.Inapoi.Text = "Inapoi"
        Me.Inapoi.UseVisualStyleBackColor = False
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exit1.Font = New System.Drawing.Font("Bahnschrift", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit1.ForeColor = System.Drawing.Color.Black
        Me.Exit1.Location = New System.Drawing.Point(16, 661)
        Me.Exit1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(181, 76)
        Me.Exit1.TabIndex = 45
        Me.Exit1.Text = "EXIT"
        Me.Exit1.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 51)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(979, 472)
        Me.AxWindowsMediaPlayer1.TabIndex = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton5, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1304, 31)
        Me.ToolStrip1.TabIndex = 60
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ListaBazaDate.My.Resources.Resources.open1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(71, 28)
        Me.ToolStripButton1.Text = "OPEN"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton2.Text = "PLAY"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(77, 28)
        Me.ToolStripButton3.Text = "PAUSE"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(91, 28)
        Me.ToolStripButton5.Text = "RESUME"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton4.Text = "STOP"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrariesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 30)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LibrariesToolStripMenuItem
        '
        Me.LibrariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MusicToolStripMenuItem, Me.VideosToolStripMenuItem})
        Me.LibrariesToolStripMenuItem.Name = "LibrariesToolStripMenuItem"
        Me.LibrariesToolStripMenuItem.Size = New System.Drawing.Size(83, 26)
        Me.LibrariesToolStripMenuItem.Text = "Libraries"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(135, 26)
        Me.VideosToolStripMenuItem.Text = "Videos"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(885, 63)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(419, 580)
        Me.ListBox1.TabIndex = 62
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ListaBazaDate.My.Resources.Resources.pawel_czerwinski_7K8d5gCdy2o_unsplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 755)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.Inapoi)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form3"
        Me.Text = "Media Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inapoi As Button
    Friend WithEvents Exit1 As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LibrariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
